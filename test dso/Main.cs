using DSO.Exceptions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace test_dso
{
    public partial class Main : Form
    {
        public string version = "1.18.12.27 - GIT update 19.02.27";
      
        public static DSO.JyeScope scope;
        public static SerialPort port = null;
        float minTrig = 0;
        float maxTrig = 0;
        float curTrig = 0;
        float currVerticalPosition = 0;
        int curPos = 0;
        float AutoTrigVal = 0;
        int WindowPointsLength = 0;
        int DisplayStartPoint = 0;
        int gridCount = 10;
        Queue<float> BufferQueue = new Queue<float>();

        bool TriggerLevelChanged = false; //to tbTrigg mouse down event
        bool ScopeCaptureStopped = false; //to stop updatng Queue and allow to manipulate data set
        bool CursorMeasurements = false;

        Series d1 = new Series()
        {
            Color = Color.Blue,
            BorderWidth = 1
        };//data line
        Series t1 = new Series()
        {
            Color = Color.Green,
            BorderWidth = 1
        };//trigger line

        Series r1 = new Series()
        {
            Color = Color.Red,
            BorderWidth = 2
        };//right cursor
        Series l1 = new Series()
        {
            Color = Color.Orange,
            BorderWidth = 2
        };//left cursor

        ToolTip tooltip = new ToolTip(); 
        DebugWindow window = new DebugWindow();

        public Main()
        {
            try
            {
                InitializeComponent();
                SerialConfig.Instance.SerialPortCreated += Instance_SerialPortCreated;
                chrt1.Series.Add(d1);
                chrt1.Series.Add(t1);
                chrt1.Series.Add(l1);
                chrt1.Series.Add(r1);
                this.chrt1.GetToolTipText += this.chrt1_GetToolTipText;
                tooltip.AutoPopDelay = 10000;
                tooltip.InitialDelay = 10000;
                tooltip.ReshowDelay = 50;
                // Force the ToolTip text to be displayed whether or not the form is active.
                tooltip.ShowAlways = true;
                lblMode.Visible = false;
                for (int i = 1; i < 200; i++)
                {
                    cbxReadDelay.Items.Add(i); //populate delay combobox
                }
                DisableControls();
            }
            catch(Exception ex)
            {
                ErrorHandler("Error while loading main window (in Main)", ex);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                btnPlay.Text = char.ConvertFromUtf32(0x25B6);
                btnPause.Text = char.ConvertFromUtf32(0x23F8);
                gpbCursorMeasure.Visible = false;
                window = new DebugWindow();

                foreach (var series in chrt1.Series)
                {
                    series.IsVisibleInLegend = false;
                    series.ChartType = SeriesChartType.StepLine;
                }
            }
            catch(Exception ex)
            {
                ErrorHandler("Error while loading main window (in form_load)", ex);
            }
        }

        //tMenuItems
        private void connectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (port != null)
            {
                try
                {
                    DSO.Utilities.SerialPortAdapter adapter = new DSO.Utilities.SerialPortAdapter(port);
                    scope = DSO.Initialization.GetScope(adapter);
                    if (scope.Connect())
                    {
                        lblScopeType.Text = scope.ScopeName;
                        PopulateConfig();
                        DisplayCurrentParameters();
                        SetCurrentWindowSize(10);
                        scope.StartCapture();
                        EnableControls();
                        scope.NewDataInBuffer += Scope_NewDataInBuffer;
                        scope.Info += Scope_Info;
                        DisplayInfo("Scope connected. Scope type: "+scope.ScopeName);
                    }
                    else
                    {
                        MessageBox.Show("Cannot establish connection with scope.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop); ScopeDispose();
                    }
                }
                catch (DSO.Exceptions.ScopeNotSupportedException ex)
                {
                    ErrorHandler("Cannot establish connection with scope.", ex);
                }
                catch (DSO.Exceptions.ScopeNotRecognizedException ex)
                {
                    ErrorHandler("Cannot establish connection with scope.", ex);
                }
                catch (DSO.Exceptions.ScopeNotDetectedException ex)
                {
                    ErrorHandler("Cannot establish connection with scope.", ex);
                }
                catch (System.IO.IOException ex)
                {
                    ErrorHandler("Cannot establish connection with scope.", ex);
                }
                catch (System.NullReferenceException ex)
                {
                    ErrorHandler("Cannot establish connection with scope.", ex);
                }
            }
            else
            {
                DisableControls();
                if (scope != null) { scope.Dispose(); }
                MessageBox.Show("Please set serial communication properly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop); ScopeDispose();
            }
        }

        private void disconnectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ScopeDispose();
            DisableControls();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ScopeCaptureStopped = false;
            if (scope.StartCapture() == true)
            {
                DisplayCurrentParameters();
                DisplayInfo("Capture started");
            }
            else
            {
                ErrorHandler("Error while connectiong with scope", new System.IO.IOException());
            }
        }

        private void stopCaptureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ScopeCaptureStopped = true;

            if (scope.StopCapture() == true)
            {
                DisplayCurrentParameters();
                DisplayInfo("Capture stopped");
            }
            else
            {
                ErrorHandler("Error while connectiong with scope", new System.IO.IOException());
            }
            ScopeCaptureStopped = false;
        }

        private void portConfigToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SerialConfig.Instance.ShowDialog();
        }

        private void debugWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (window.IsDisposed != true)
            {
                window.Show();
                window.ForceScopeMode += ForceScope;
            }
            else
            {
                window = new DebugWindow();
                window.ForceScopeMode += ForceScope;
                window.Show();
            }
        }

        private void saveBufferToCSVFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var DateTimeStamp = DateTime.Now.ToString("yyMMddHHmmss");
            string ParameterLine = scope.DataSamplesPerDiv.ParameterName + ";" + scope.DataSamplesPerDiv.ParameterUnit + ";" + scope.DataSamplesPerDiv.ParameterValue + ";" + System.Environment.NewLine
                                 + scope.Sensitivity.ParameterName + ";" + scope.Sensitivity.ParameterUnit + ";" + scope.Sensitivity.ParameterValue +";" + System.Environment.NewLine
                                 + scope.TimeBase.ParameterName + ";" + scope.TimeBase.ParameterUnit + ";" + scope.TimeBase.ParameterValue + ";" + System.Environment.NewLine
                                 + "Data samples unit" + ";" + scope.CurrentVoltageLimit.ParameterUnit + ";" + System.Environment.NewLine;
            System.IO.File.WriteAllText($"{DateTimeStamp}.csv", ParameterLine + string.Join(";", BufferQueue.ToArray()));
            DisplayInfo("Output saved with file name: "+DateTimeStamp);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Assembly assembly = Assembly.LoadFrom("DSO.dll");
            Version ver = assembly.GetName().Version;
            var size = IntPtr.Size;  //4 - 32bit 8 - 64bit
            if(size == 4)
            {
                version += " (x86)";
            }
            string DLLversion = ver.ToString();
            MessageBox.Show($"PC Scope  v. {version}" + System.Environment.NewLine + $"DSO.dll  v. {DLLversion}" + System.Environment.NewLine + "(C) Kamil Karlowicz 2018", "About", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        //ScopeParameters events
        private void cbxHSens_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                scope.TimeBase = (DSO.Interfaces.IParameter<DSO.Config.Timebase>)cbxHSens.SelectedItem;
            }
            catch (ParametersNotSetException ex)
            {
                DisplayInfo("Error while setting parameters");
                DisplayCurrentParameters();
            }
        }

        private void cbxVSens_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                scope.Sensitivity = (DSO.Interfaces.IParameter<DSO.Config.VerticalSensitivity>)cbxVSens.SelectedItem;
            }
            catch (ParametersNotSetException ex)
            {
                DisplayInfo("Error while setting parameters");
                DisplayCurrentParameters();
            }
        }

        private void cbxTrigType_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                scope.TriggerMode = (DSO.Interfaces.IParameter<DSO.Config.TriggerMode>)cbxTrigType.SelectedItem;
            }
            catch (ParametersNotSetException ex)
            {
                DisplayInfo("Error while setting parameters");
                DisplayCurrentParameters();
            }
        }

        private void cbxTrigSlope_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                scope.TriggerSlope = (DSO.Interfaces.IParameter<DSO.Config.Slope>)cbxTrigSlope.SelectedItem;
            }
            catch (ParametersNotSetException ex)
            {
                DisplayInfo("Error while setting parameters");
                DisplayCurrentParameters();
            }
        }

        private void cbxCouple_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                scope.Couple = (DSO.Interfaces.IParameter<DSO.Config.Coupling>)cbxCouple.SelectedItem;
            }
            catch (ParametersNotSetException ex)
            {
                DisplayInfo("Error while setting parameters");
                DisplayCurrentParameters();
            }
        }

        private void cbxRecLength_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                scope.RecordLength = (DSO.Interfaces.IParameter<DSO.Config.RecordLength>)cbxRecLength.SelectedItem;
                SetCurrentWindowSize(gridCount);
            }
            catch (ParametersNotSetException ex)
            {
                DisplayInfo("Error while setting parameters");
                DisplayCurrentParameters();
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            scope.ReadDelay = (int)cbxReadDelay.SelectedItem;
        }
        private void GetCursorMeasurements()
        {
            float RightValue = (float)(Math.Round(((double)tbTrigg.Value / 10000), 2));
            float LeftValue = (float)(Math.Round(((double)tbPos.Value / 10000), 2));
            float DeltaValue = RightValue - LeftValue;
            lblCursorLeftValue.Text = Convert.ToString(LeftValue);
            lblCursorRightValue.Text = Convert.ToString(RightValue);
            lblDeltaValue.Text = Convert.ToString(DeltaValue);
        }

        //Trackbars scrolls
        private void tbTrigg_Scroll(object sender, EventArgs e)
        {
            if (CursorMeasurements)
            {
                GetCursorMeasurements();
                DataReceived(BufferQueue.ToArray());
            }
            else
            {
                curTrig = (float)(0.0001 * (tbTrigg.Value - tbPos.Value));
                lbltrig.Text = Convert.ToString(curTrig.ToString(("0.000") + scope.CurrentVoltageLimit.ParameterUnit));
                TriggerLevelChanged = true;
            }
        }
 
        private void tbTrigg_MouseLeave(object sender, EventArgs e)
        {

            if (TriggerLevelChanged)
            {
                try
                {
                    scope.TriggerLevel = curTrig;
                }
                catch (ParametersNotSetException)
                {
                    DisplayCurrentParameters();
                }
                TriggerLevelChanged = false;
            }

        }
        private void tbVerticalPosition_Scroll(object sender, EventArgs e)
        {
            DisplayStartPoint = tbVerticalPosition.Value;
            if (ScopeCaptureStopped)
            {
                DataReceived(BufferQueue.ToArray());
            }
        }

        private void tbPos_Scroll(object sender, EventArgs e)
        {
            if (!CursorMeasurements)
            {
                if (!ScopeCaptureStopped)
                {
                    TrackbarSetValue(tbTrigg, tbPos.Value);
                }
                else
                {
                    DataReceived(BufferQueue.ToArray());
                }
                currVerticalPosition = tbPos.Value;
            }
            else
            {
                GetCursorMeasurements();
                DataReceived(BufferQueue.ToArray());
            }
        }

        
        //buttons
        private void btnPause_Click(object sender, EventArgs e)
        {
            DisableControls(true);
            btnPause.Enabled = false;
            btnPlay.Enabled = true;
            ScopeCaptureStopped = true;
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            EnableControls();
            btnPlay.Enabled = false;
            btnPause.Enabled = true;
            ScopeCaptureStopped = false;
        }

        private void btnGetParam_Click_1(object sender, EventArgs e)
        {
            tbPos.Value = 0;
            currVerticalPosition = tbPos.Value;
            DisplayCurrentParameters();
        }

        private void btnAutoTrig_Click(object sender, EventArgs e)
        {
            tbPos.Value = 0;
            currVerticalPosition = tbPos.Value;
            try
            {
                scope.TriggerLevel = AutoTrigVal;
                tbTrigg.Value = Convert.ToInt16(AutoTrigVal * 10000);
            }
            catch (DSO.Exceptions.ParametersNotSetException)
            {
                tbTrigg.Value = Convert.ToInt16(scope.TriggerLevel * 10000);
            }
            curTrig = (float)(0.0001 * (tbTrigg.Value - tbPos.Value));
            lbltrig.Text = Convert.ToString(curTrig.ToString(("0.000") + scope.CurrentVoltageLimit.ParameterUnit));
        }
        private void btnAddCell_Click(object sender, EventArgs e)
        {
            int cellGrid = gridCount;
            SetCurrentWindowSize(++cellGrid);
        }

        private void btnRemoveCell_Click(object sender, EventArgs e)
        {
            int cellGrid = gridCount;
            SetCurrentWindowSize(--cellGrid);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            SetCurrentWindowSize(10);
            UpdateTrackbarLimits();
            tbVerticalPosition.Value = Convert.ToInt16(tbVerticalPosition.Maximum) / 2;
        }

        private void btnCursorFunction_Click_1(object sender, EventArgs e)
        {
            if (btnCursorFunction.Text == "Measure")
            {
                DisplayInfo("Measure cursors enabled.");
                gpbCursorMeasure.Visible = true;
                btnCursorFunction.Text = "Adjust";
                CursorMeasurements = true;
            }
            else if (btnCursorFunction.Text == "Adjust")
            {
                DisplayInfo("Measure cursors disabled.");
                gpbCursorMeasure.Visible = false;
                btnCursorFunction.Text = "Measure";
                CursorMeasurements = false;
                tbPos.Value = (int)currVerticalPosition;
                tbTrigg.Value = Convert.ToInt16(10000 * curTrig);
            }
            if (ScopeCaptureStopped)
            {
                DisableControls(true);
            }
        }

        //Scope serial port created event handler
        private void Instance_SerialPortCreated(object sender, EventArgs e)
        {
            port = (SerialPort)sender; //event fired from serial config window
        }
        //Force scope mode event from debug Window
        private void ForceScope(object sender, EventArgs e)
        {
            DisableControls();
            scope = (DSO.JyeScope)sender; //event fired from serial config window
            try
            {
                if (scope.Connect())
                {
                    lblScopeType.Text = scope.ScopeName;
                    PopulateConfig();
                    DisplayCurrentParameters();
                    SetCurrentWindowSize(10);
                    scope.StartCapture();
                    EnableControls();
                    scope.NewDataInBuffer += Scope_NewDataInBuffer;
                    scope.Info += Scope_Info;
                }
                else
                {
                    MessageBox.Show("Cannot establish connection with scope.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop); ScopeDispose();
                }
            }catch(Exception ex)
            {
                ErrorHandler("Cannot establish connection with scope.", ex);
            }
           
        }

        //IScope new data event handler
        private void Scope_NewDataInBuffer(object sender, EventArgs e) //IScope event
        {
            float[] values = (float[])sender;
            BeginInvoke((Action)(() =>
            {
                if (cbxVSens.Enabled == false)
                {
                    cbxVSens.SelectedItem = scope.Sensitivity;
                }
                if (cbxCouple.Enabled == false)
                {
                    cbxCouple.SelectedItem = scope.Couple;
                }
            }));

            if (!ScopeCaptureStopped) //To not update queue while pause button is clicked
            {
                foreach (float data in values)
                {
                    BufferQueue.Enqueue(data);
                }
                while (BufferQueue.Count() > Convert.ToInt16(scope.RecordLength.ParameterValue))
                {
                    BufferQueue.Dequeue();
                }

                DataReceived(BufferQueue.ToArray());

                try
                {
                    AutoTrigVal = values.Average();
                }
                catch (Exception ex)
                {
                }
            }
        }

        //Data received event handler
        private void DataReceived(float[] data)
        {
            List<float> tempArray = new List<float>();
            try
            {
                for (int i = DisplayStartPoint; i <= WindowPointsLength + DisplayStartPoint - 1; i++)
                {
                    tempArray.Add(data[i]);
                }
            }
            catch (System.IndexOutOfRangeException)
            {
            }
            UpdateTrackbarLimits();
            DisplayGrid();
            DisplayData(tempArray.ToArray());
        }

        //Tooltip display event handler
        private void chrt1_GetToolTipText(object sender, ToolTipEventArgs e)
        {
            // Check selected chart element and set tooltip text for it
            if (e.HitTestResult.ChartElementType == ChartElementType.DataPoint)
            {
                //Get selected data point
                DataPoint dataPoint = (DataPoint)e.HitTestResult.Object;

                e.Text = Math.Round(dataPoint.YValues[0], 3).ToString();
                tooltip.SetToolTip(this.chrt1, e.Text);
            }
        }

        //Functions

        private void ScopeDispose()
        {
            if (scope != null)
            {
                scope.Destroy();
            }
            if( port != null)
            {
                port.Dispose();
                port = null;
            }
        }

        private void DisableControls(bool KeepTrackBarsActive = false)
        {
            foreach (Control control in this.Controls)
            {
                control.Enabled = false;
            }
            menuStrip.Enabled = true;
            tMenuConnect.Enabled = true;
            tMenuStartCapture.Enabled = false;
            tMenuStopCapture.Enabled = false;
            tMenuSaveAsCSV.Enabled = false;
            if (KeepTrackBarsActive)
            {
                btnCursorFunction.Enabled = true;
                gpbCursorMeasure.Enabled = true;
                foreach (Control control in this.Controls)
                {
                    if(control is TrackBar)
                    {
                        control.Enabled = true;
                    }
                }
                if (!CursorMeasurements) //to allow to manipulate cursors even in pause mode
                {
                    tbTrigg.Enabled = false;
                }
                if (ScopeCaptureStopped)
                {
                    btnPlay.Enabled = true;
                }
                chrt1.Enabled = true;
                tMenuSaveAsCSV.Enabled = true;
                lblMode.Enabled = true;
            }
        }
        private void EnableControls()
        {
            foreach (Control control in this.Controls)
            {
                control.Enabled = true;
            }
            tMenuConnect.Enabled = false;
            btnPlay.Enabled = false;
            tMenuStartCapture.Enabled = true;
            tMenuStopCapture.Enabled = true;
            tMenuSaveAsCSV.Enabled = true;
        }
        private void SetCurrentWindowSize(int value = 10)
        {
            int curRecLength = Convert.ToInt16(((DSO.Interfaces.IParameter<DSO.Config.RecordLength>)cbxRecLength.SelectedItem).ParameterValue);
            int pointPerDiv = scope.DataSamplesPerDiv.GetParameter;
            if ((value <= Convert.ToInt16(curRecLength / pointPerDiv) && value >= 5))
            {
                gridCount = value;
            }
            else if (value > Convert.ToInt16(curRecLength / pointPerDiv))
            {
                gridCount = Convert.ToInt16(curRecLength / pointPerDiv);
            }
            else
            {
                gridCount = 5;
            }
            TrackbarSetValue(tbVerticalPosition, DisplayStartPoint);
            lblCellCount.Text = Convert.ToString(gridCount);
        }

        private void TrackbarSetValue(TrackBar trackbar, int value)
        {
            if (value <= trackbar.Maximum && value >= trackbar.Minimum)
            {
                trackbar.Value = value;
            }
            else if (value > trackbar.Maximum)
            {
                value = trackbar.Maximum;
            }
            else
            {
                value = trackbar.Minimum;
            }
        }

        private void ErrorHandler (string message, Exception ex)
        {
            MessageBox.Show(message + Environment.NewLine + "Add. info: "+ ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            DisableControls();
            ScopeDispose();
        }

        private void DisplayData(float[] data)
        {
            try
            {
                BeginInvoke((Action)(() =>
                {
                    lblVRMS.Text = "";
                    lblVmax.Text = "";
                    lblVmin.Text = "";
                    lblVAvg.Text = "";

                    d1.Points.Clear();
                    t1.Points.Clear();
                    l1.Points.Clear();
                    r1.Points.Clear();

                    this.chrt1.ChartAreas[0].AxisY.Maximum = Math.Round(scope.CurrentVoltageLimit.GetParameter, 2);
                    this.chrt1.ChartAreas[0].AxisY.Minimum = Math.Round(-scope.CurrentVoltageLimit.GetParameter, 2);
                }));

                BeginInvoke((Action)(() =>
                {
                    chrt1.Series.SuspendUpdates();
                    foreach (float value in data)
                    {
                            
                            d1.Points.Add(value + ((float)(0.0001 * (currVerticalPosition))));
                            if (CursorMeasurements)
                            {
                                l1.Points.Add(((float)(0.0001 * (tbPos.Value))));
                                r1.Points.Add((float)(0.0001 * (tbTrigg.Value)));
                            }
                            else
                            {
                                t1.Points.Add((float)(0.0001 * (tbTrigg.Value)));
                            }
                    }
                    chrt1.Series.ResumeUpdates();
                }));

                BeginInvoke((Action)(() =>
                {
                    this.chrt1.Refresh();
                    maxTrig = scope.CurrentVoltageLimit.GetParameter;
                    minTrig = -scope.CurrentVoltageLimit.GetParameter;
                    var rms = new RMS();
                    if(data.Count()> 0)
                    {
                        lblVRMS.Text = rms.calculateMaxRMS(data.ToList(), 256).ToString("0.000"); ;
                        lblVmax.Text = data.Max().ToString("0.000");
                        lblVmin.Text = data.Min().ToString("0.000");
                        lblVAvg.Text = AutoTrigVal.ToString("0.000");
                        var max = (Convert.ToSingle(lblVmax.Text));
                        var min = (Convert.ToSingle(lblVmin.Text));
                        var vpp = Math.Abs(min - max);
                        lblVpp.Text = vpp.ToString();
                    }
                }));
            }
            catch (Exception)
            {
            }
        }

        private void DisplayGrid()
        {
            if (chrt1.InvokeRequired)
            {
                BeginInvoke((Action)(() =>
                {
                    WindowPointsLength = gridCount * scope.DataSamplesPerDiv.GetParameter;
                    this.chrt1.ChartAreas[0].AxisX.LabelStyle.Enabled = false;
                    this.chrt1.ChartAreas[0].AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
                    this.chrt1.ChartAreas[0].AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
                    this.chrt1.ChartAreas[0].AxisX.MajorGrid.Interval = scope.DataSamplesPerDiv.GetParameter;
                    this.chrt1.ChartAreas[0].AxisY.MajorGrid.Interval = scope.CurrentVoltageLimit.GetParameter / 6; //div by 6 because voltagelimit is actually 6 times voltage/div
                    this.chrt1.ChartAreas[0].AxisY.MajorTickMark.Interval = Math.Round(scope.CurrentVoltageLimit.GetParameter / 6, 2);
                    this.chrt1.ChartAreas[0].AxisY.Interval = Math.Round(scope.CurrentVoltageLimit.GetParameter / 6, 2);
                }));
            }
        }

        private void Scope_Info(object sender, EventArgs e)
        {
            try
            {
                 BeginInvoke((Action)(() =>
            {
                this.lblConnectionInfo.Text = Convert.ToString(((byte[])sender).Length);
            }));

            }
            catch (Exception)
            {
            }
        }

        private void PopulateConfig()
        {
                cbxVSens.DataSource = new BindingSource(scope.AvailableSenitivitySettings, null);
                cbxCouple.DataSource = new BindingSource(scope.AvailableCoupleSettings, null);
                cbxTrigSlope.DataSource = new BindingSource(scope.AvailableTriggerSlopeSettings, null);
                cbxTrigType.DataSource = new BindingSource(scope.AvailableTriggerModeSettings, null);
                cbxHSens.DataSource = new BindingSource(scope.AvailableTimebaseSettings, null);
                cbxRecLength.DataSource = new BindingSource(scope.AvailableRecordLength, null);

                cbxCouple.Enabled = !scope.AvailableCoupleSettings.First().IsReadOnly;
                cbxVSens.Enabled = !scope.AvailableSenitivitySettings.First().IsReadOnly;
                TrackbarSetValue(tbVerticalPosition, Convert.ToInt16(tbVerticalPosition.Maximum / 2));
                DisplayStartPoint = tbVerticalPosition.Value;
        }

        private void DisplayCurrentParameters()
        {
            foreach (Control cbx in this.groupBox1.Controls)
            {
                if (cbx.GetType() == typeof(ComboBox))
                {
                    var curCBX = (ComboBox)cbx;
                    curCBX.Enabled = false;
                }
            }
            UpdateTrackbarLimits();
            cbxCouple.SelectedItem = scope.Couple;
            cbxHSens.SelectedItem = scope.TimeBase;
            cbxTrigSlope.SelectedItem = scope.TriggerSlope;
            cbxTrigType.SelectedItem = scope.TriggerMode;
            cbxVSens.SelectedItem = scope.Sensitivity;
            cbxRecLength.SelectedItem = scope.RecordLength;
            curTrig = (float)Math.Round(scope.TriggerLevel, 3);
            curPos = scope.VerticalPosition;
            lbltrig.Text = Convert.ToString(scope.TriggerLevel + scope.CurrentVoltageLimit.ParameterUnit);
            TrackbarSetValue(tbTrigg, (int)Math.Round(scope.TriggerLevel * 10000, 0));
            cbxReadDelay.SelectedItem = scope.ReadDelay;

            foreach (Control cbx in this.groupBox1.Controls)
            {
                if (cbx.GetType() == typeof(ComboBox))
                {
                    var curCBX = (ComboBox)cbx;
                    curCBX.Enabled = true;
                }
            }
            cbxCouple.Enabled = !scope.AvailableCoupleSettings.First().IsReadOnly;
            cbxVSens.Enabled = !scope.AvailableSenitivitySettings.First().IsReadOnly;
            SetCurrentWindowSize(gridCount);
        }

        private void UpdateTrackbarLimits()
        {
            if (tbTrigg.InvokeRequired)
            {
                BeginInvoke((Action)(() =>
                {
                    tbTrigg.Maximum = (int)(Math.Round(10000 * scope.CurrentVoltageLimit.GetParameter, 2)); //because trackbar  values are int so need to multiply to get two decimal points after divide / 10000
                    tbTrigg.Minimum = (int)(Math.Round(10000 * -scope.CurrentVoltageLimit.GetParameter, 2));

                    tbPos.Maximum = (int)(Math.Round(10000 * scope.CurrentVoltageLimit.GetParameter, 2));
                    tbPos.Minimum = (int)(Math.Round(10000 * -scope.CurrentVoltageLimit.GetParameter, 2));

                    tbVerticalPosition.Maximum = Convert.ToInt16(scope.RecordLength.ParameterValue) - WindowPointsLength;
                    tbVerticalPosition.Minimum = 1;
                    DisplayStartPoint = tbVerticalPosition.Value;
                    
                }));
            }
        }
        private void DisplayInfo(String message, int Interval = 2000)
        {
            lblMode.Visible = true;
            lblMode.Text = message;
            var t = new Timer();
            t.Interval = Interval;
            t.Tick += (s, e) =>
            {
                lblMode.Visible = false;
                t.Stop();
            };
            t.Start();
        }
        private void DelayedAction(Action method, int delay = 500)
        {
            var t = new Timer();
            t.Interval = delay;
            t.Tick += (s, e) =>
            {
                method();
                t.Stop();
            };
            t.Start();
        }

        private void FunctionNotImplemented()
        {
            MessageBox.Show("Function not implemented");
        }

      

    }
}
