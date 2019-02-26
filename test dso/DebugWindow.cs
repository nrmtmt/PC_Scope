using DSO.DataFrames;
using DSO.DataFrames.DSO068;
using DSO.DataFrames.DSO112;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DSO.DataFrames.ScopeControlDataFrames;
using DSO;
using DSO.Exceptions;
using DSO.Utilities;

namespace test_dso
{
    public partial class DebugWindow : Form
    {
        byte[] output;

        public DebugWindow()
        {
            InitializeComponent();
        }

        public event EventHandler ForceScopeMode = delegate { };
        public delegate void ForceScopeModeEventHandler();


        private void DebugWindow_Load(object sender, EventArgs e)
        {
            //to parameters event in groupbox
            cbxCouple.SelectedIndexChanged += new System.EventHandler(ParametersChanged);
            cbxHSens.SelectedIndexChanged += new System.EventHandler(ParametersChanged);
            cbxRecLength.SelectedIndexChanged += new System.EventHandler(ParametersChanged);
            cbxTrigLevel.SelectedIndexChanged += new System.EventHandler(ParametersChanged);
            cbxTrigPos.SelectedIndexChanged += new System.EventHandler(ParametersChanged);
            cbxTrigSlope.SelectedIndexChanged += new System.EventHandler(ParametersChanged);
            cbxTrigType.SelectedIndexChanged += new System.EventHandler(ParametersChanged);
            cbxVpos.SelectedIndexChanged += new System.EventHandler(ParametersChanged);
            cbxVSens.SelectedIndexChanged += new System.EventHandler(ParametersChanged);


            foreach (var couple in (int[])Enum.GetValues(typeof(DSO.Config.Coupling)))
            {
                cbxCouple.Items.Add((DSO.Config.Coupling)couple);
            }
            foreach (var Vsens in (int[])Enum.GetValues(typeof(DSO.Config.VerticalSensitivity)))
            {
                cbxVSens.Items.Add((DSO.Config.VerticalSensitivity)Vsens);
            }
            foreach (var slope in (int[])Enum.GetValues(typeof(DSO.Config.Slope)))
            {
                cbxTrigSlope.Items.Add((DSO.Config.Slope)slope);
            }
            foreach (var type in (int[])Enum.GetValues(typeof(DSO.Config.TriggerMode)))
            {
                cbxTrigType.Items.Add((DSO.Config.TriggerMode)type);
            }
            foreach (var type in (int[])Enum.GetValues(typeof(DSO.Config.Timebase)))
            {
                cbxHSens.Items.Add((DSO.Config.Timebase)type);
            }
            foreach (var item in (int[])Enum.GetValues(typeof(DSO.Config.RecordLength)))
            {
                cbxRecLength.Items.Add((int)(DSO.Config.RecordLength)item);
            }
            for (int i = -255; i < 256; i++)
            {
                cbxTrigPos.Items.Add(i);
                cbxTrigLevel.Items.Add(i);
                cbxVpos.Items.Add(i);
            }

            foreach (var p in SerialPort.GetPortNames())
            {
                cbxComName.Items.Add(p);
            }
            for (int i = 1; i < 200; i++)
            {
                cbxReadDelay.Items.Add(i);
            }
            int[] baudRate = { 1200, 2400, 4800, 9600, 19200, 38400, 57600, 115200 };
            foreach (var rate in baudRate)
            {
                cbxComSpeed.Items.Add(rate);
            }
            if (cbxComName.Items.Count > 0)
            {
                cbxCommandSelect.Items.Add(new EnterUSBScopeMode());
                cbxCommandSelect.Items.Add(new ExitUSBScopeMode());
                cbxCommandSelect.Items.Add(new GetParameters());
                cbxCommandSelect.Items.Add(new GetData());
                cbxCommandSelect.Items.Add(new GetConfig());
                cbxCommandSelect.Items.Add(new GetScopeType());
                cbxCommandSelect.Items.Add(new CurrParamDataFrame((DSO.Config.VerticalSensitivity)8,
                                                             (DSO.Config.Timebase)27,
                                                             (DSO.Config.Slope)0,
                                                             (DSO.Config.TriggerMode)0,
                                                             (DSO.Config.Coupling)1,
                                                             (byte)127,
                                                             (byte)50,
                                                             (DSO.Config.RecordLength)(int)512,
                                                             127));

                cbxComName.SelectedIndex = 0;
                cbxComSpeed.SelectedIndex = 7;
                cbxReadDelay.SelectedIndex = 49;
                cbxCommandSelect.SelectedIndex = 0;
                EnableConfigComboboxes(false);
            }
            else
            {
                EnableConfigComboboxes(false);
            }
        }

        public void EnableConfigComboboxes(bool enable)
        {
            foreach (var control in gpbParams.Controls)
            {
                if (control is ComboBox)
                {
                    ((ComboBox)control).Enabled = enable;
                }
                gpbParams.Enabled = enable;
            }
        }

        public void SetValuesInInfoToBlank()
        {
            lblCplChangeable.Text = "-";
            lblMinMaxCpl.Text = "-";
            lblMinMaxRecLength.Text = "-";
            lblMinMaxSens.Text = "-";
            lblMinMaxTb.Text = "-";
            lblMinMaxTrigLevel.Text = "-";
            lblMinMaxTrigMode.Text = "-";
            lblMinMaxTrigPos.Text = "-";
            lblMinMaxTrigSlope.Text = "-";
            lblNoOfChannels.Text = "-";
            lblSensChangeable.Text = "-";
        }


        private SerialPort GetSerialPort()
        {

            try
            {
                SerialPort port = new SerialPort();
                port.PortName = (string)cbxComName.SelectedItem;
                port.Parity = Parity.None;
                port.BaudRate = Convert.ToInt32(cbxComSpeed.SelectedItem);
                port.DataBits = 8;
                port.StopBits = StopBits.One;

                if (port.IsOpen != true) { port.Open(); };
                return port;
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("Selected port is currently in use.");
                return null;
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("No port selected.");
                return null;
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("No port selected.");
                return null;
            }
        }

        private string properHex(string hex)
        {
            if (hex.Length < 2 && hex != " ")
            {
               return  "0" + hex;
            }
            else
            {
                return hex;
            }
        }


        private void SetCommandText(DataFrame frame)
        {
            txtEditCommand.Clear();
            var tempText = "";
            foreach (string val in frame.HexData)
            {
               tempText += properHex(val)+ " "; 
            }
            if (tempText.Length > 0)
            {
                txtEditCommand.Text = (tempText.Remove(tempText.Length - 1));
            }
        }
        private void SetParamToComboboxes(CurrParamDataFrame config)
        {
            gpbParams.Enabled = false;
            foreach (var cbx in gpbParams.Controls)
            {
                if (cbx is ComboBox)
                {
                    ((ComboBox)cbx).Text = null;
                }
            }
            cbxCouple.SelectedItem = config.Couple;
            cbxHSens.SelectedItem = config.TBase;
            cbxRecLength.SelectedText = (Convert.ToString((int)config.RecordLength));
            cbxTrigPos.SelectedText = (Convert.ToString(config.TriggerPosition));
            cbxTrigSlope.SelectedItem = config.TriggerSlope;
            cbxTrigType.SelectedItem = config.TriggerMode;
            cbxTrigLevel.SelectedText = (Convert.ToString(config.TriggerLevel));
            cbxVSens.SelectedItem = config.VSensitivity;
            cbxVpos.SelectedText = (Convert.ToString(config.VPosition));
            gpbParams.Enabled = true;
        }
        private void ClearSelectionInComboboxes()
        {
             foreach (var cbx in gpbParams.Controls)
            {
                if (cbx is ComboBox)
                {
                    ((ComboBox)cbx).Text = null;
                }
            }
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            foreach (var cb in this.Controls)
            {
                if (cb is CheckBox)
                {
                    ((CheckBox)cb).Checked = false;
                }

            }

            txtBufferOutput.Clear();
            var port = GetSerialPort();


            if (port != null)
            {
                if (txtEditCommand.Text != "")
                {
                    var bytes = txtEditCommand.Text.Split(' ');
                    List<byte> proper = new List<byte>();
                    foreach (var value in bytes)
                    {if (value != "")
                        {
                            proper.Add(byte.Parse(value, System.Globalization.NumberStyles.HexNumber));
                        }
                    }
                    port.Write(proper.ToArray(), 0, proper.ToArray().Count());
                }
                else
                {
                    // WriteFrame((DataFrame)cbxCommandSelect.SelectedItem, port);
                }
                System.Threading.Thread.Sleep(Convert.ToInt16(cbxReadDelay.Text));
                output = InstReadBuffer(port);
                port.Dispose();
                var tempText = "";
                foreach (byte val in output)
                {
                    tempText += val + ", ";
                }
                if (tempText.Length > 0)
                {
                    txtBufferOutput.Text = (tempText.Remove(tempText.Length - 2));
                }
                port.Close();
                port.Dispose();

                try
                {
                    DSO.DataFrames.DSO068.CurrConfigDataFrame config = new DSO.DataFrames.DSO068.CurrConfigDataFrame(output);
                    cbCurrConf.Checked = true;
                }
                catch (InvalidDataFrameException)
                {
                    cbCurrConf.Checked = false;
                }
                try
                {
                    DSO.DataFrames.DSO112.CurrConfigDataFrame config = new DSO.DataFrames.DSO112.CurrConfigDataFrame(output);
                    cbCurrConf.Checked = true;
                }
                catch (InvalidDataFrameException)
                {
                    cbCurrConf.Checked = false;
                }
                try
                {
                    CurrParamDataFrame config = new CurrParamDataFrame(output);
                    SetParamToComboboxes(config);
                    EnableConfigComboboxes(false);
                    cbCurrParam.Checked = true;
                }
                catch (InvalidDataFrameException)
                {
                    cbCurrParam.Checked = false;
                }
                try
                {
                    DataBlockDataFrame config = new DataBlockDataFrame(output);
                    cbDataBlock.Checked = true;
                }
                catch (InvalidDataFrameException)
                {
                    cbDataBlock.Checked = false;
                }
                try
                {
                    DataSampleDataFrame config = new DataSampleDataFrame(output);
                    cbDataSample.Checked = true;
                }
                catch (InvalidDataFrameException)
                {
                    cbDataSample.Checked = false;
                }
                try
                {
                    ScopeReady config = new ScopeReady(output);
                    cbScopeReady.Checked = true;
                }
                catch (InvalidDataFrameException)
                {
                    cbScopeReady.Checked = false;
                }
                try
                {
                    USBScopeModeExited config = new USBScopeModeExited(output);
                    cbExitedScope.Checked = true;
                }
                catch (InvalidDataFrameException)
                {
                    cbExitedScope.Checked = false;
                }
                try
                {
                   CommandAcknowledgedDataFrame config = new CommandAcknowledgedDataFrame(output);
                    cbCommandAck.Checked = true;
                }
                catch (InvalidDataFrameException)
                {
                    cbCommandAck.Checked = false;
                }
            }
        }

        private bool WriteFrame(DataFrame frame, SerialPort port)
        {
            port.Write(frame.Data, 0, frame.Data.Count());
            return true;
        }
        public byte[] InstReadBuffer(SerialPort port)
        {
            int bufferSize = port.BytesToRead;
            byte[] buffer = new byte[bufferSize];
            port.Read(buffer, 0, bufferSize);
            return buffer;
        }

        private void txtBufferOutput_Click(object sender, EventArgs e)
        {
            var tempText = "";
            try
            {
                var values = txtBufferOutput.Text.Split(',');
                List<String> HexBytes = new List<String>();
                foreach (string val in values)
                {
                    HexBytes.Add(Convert.ToByte(val).ToHex());
                }
                foreach (string val in HexBytes)
                {
                        tempText += properHex(val) + " ";
                }
                if (tempText.Length > 0)
                {
                    txtBufferOutput.Text = (tempText.Remove(tempText.Length - 1));
                }
            }
            catch (Exception)
            {
                if (output != null)
                {
                    foreach (byte val in output)
                    {
                        tempText += val + ", ";
                    }
                    if (tempText.Length > 0)
                    {
                        txtBufferOutput.Text = (tempText.Remove(tempText.Length - 2));
                    }
                }
            }
        }

        private void cbxCommandSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = ((DataFrame)((ComboBox)sender).SelectedItem);

            if (item is CurrParamDataFrame)
            {
                if (cbxHSens.SelectedItem == null)
                {
                    SetParamToComboboxes((CurrParamDataFrame)item);
                } 
                EnableConfigComboboxes(true);
            }
            else
            {
                EnableConfigComboboxes(false);
            }
            SetCommandText(item);
        }

        private void lblPopulateConfig_Click(object sender, EventArgs e)
        {
            SetValuesInInfoToBlank();
            var port = GetSerialPort();
            if (port != null)
            {
                var config = new GetConfig();
                var connect = new EnterUSBScopeMode();
                var disconnect = new ExitUSBScopeMode();

                //Getting name of scope
                WriteFrame(disconnect, port);
                System.Threading.Thread.Sleep((Convert.ToInt16(cbxReadDelay.Text)));
                WriteFrame(connect, port);
                System.Threading.Thread.Sleep((Convert.ToInt16(cbxReadDelay.Text)));
                var bytes = InstReadBuffer(port);

                ScopeReady Ready = (ScopeReady)GetResponse(connect, port);
                if (Ready != null)
                {
                    Config.ScopeType properScope = Ready.ScopeType;
                    lblModel.Text = "Detected: " + Convert.ToString(properScope) + System.Environment.NewLine + "Readed: \"" + GetScopeName(Ready.Data) + "\"";
                }
                else
                {
                    GetScopeType type = new GetScopeType();
                    Ready = (ScopeReady)GetResponse(type, port);

                    if (Ready != null)
                    {
                        Config.ScopeType properScope = Ready.ScopeType;
                        lblModel.Text = "Detected: " + Convert.ToString(properScope) + "  Readed: \"" + GetScopeName(Ready.Data) + "\"";
                    }
                    else
                    {
                        lblModel.Text = "Scope not detected:   \"" + GetScopeName(InstReadBuffer(port)) + "'";
                    }
                }
                //Getting config of scope

                DSO.Interfaces.ICurrentConfig cfg = (DSO.Interfaces.ICurrentConfig)GetResponse(config, port);
                if (cfg != null)
                {
                    lblCplChangeable.Text = cfg.CoupleChangeableByHost.ToString();
                    lblMinMaxCpl.Text = cfg.MinCoupleSetting + "/" + cfg.MaxCoupleSetting;
                    lblMinMaxRecLength.Text = cfg.MinRecordLength + "/" + cfg.MaxRecordLength;
                    lblMinMaxSens.Text = cfg.MinVerticalSensitivity + "/" + cfg.MaxVerticalSensitivity;
                    lblMinMaxTb.Text = cfg.MinTimebaseSetting + "/" + cfg.MaxTimebaseSetting;
                    lblMinMaxTrigLevel.Text = cfg.MinTriggerLevel + "/" + cfg.MaxTriggerLevel;
                    lblMinMaxTrigMode.Text = cfg.MinTriggerModeSetting + "/" + cfg.MaxTriggerModeSetting; ;
                    lblMinMaxTrigPos.Text = cfg.MinTriggerPosition + "/" + cfg.MaxTriggerPosition; ;
                    lblMinMaxTrigSlope.Text = cfg.MinSlopeModeSetting + "/" + cfg.MaxSlopeModeSetting;

                    if (cfg.Ch1Present == true && cfg.Ch2Present == true)
                    {
                        lblNoOfChannels.Text = "2";
                    }
                    else if (cfg.Ch1Present == false || cfg.Ch2Present == false)
                    {
                        lblNoOfChannels.Text = "1";
                    }

                    lblSensChangeable.Text = cfg.SensitivityChangeableByHost.ToString();
                }
                port.Dispose();
            }
        }

        private string StrFromAscii(byte[] values)
        {
            string output = "";
            foreach (var value in values)
            {
                output += char.ConvertFromUtf32(value);
            }
            return output;
        }

        private string GetScopeName(byte[] values)
        {
            string output = "";
            for (int i = 4; i <= values.Length - 1; i++)
            {
                output += char.ConvertFromUtf32(values[i]);
            }
            return output;
        }

        private DSO.DataFrames.DataFrame GetResponse(DataFrame frame, SerialPort port)
        {
            port.DiscardInBuffer();
            WriteFrame(frame, port);
            System.Threading.Thread.Sleep(2*(Convert.ToInt16(cbxReadDelay.Text)));
            var bytes = InstReadBuffer(port);

            try
            {
                ScopeReady config = new ScopeReady(bytes);
                return config;
            }
            catch (InvalidDataFrameException)
            {
            }

            try
            {
                DSO.DataFrames.DSO068.CurrConfigDataFrame config = new DSO.DataFrames.DSO068.CurrConfigDataFrame(bytes);
                return config;
            }
            catch (InvalidDataFrameException)
            {

            }
            catch (IndexOutOfRangeException)
            {

            }


            try
            {
                DSO.DataFrames.DSO112.CurrConfigDataFrame config = new DSO.DataFrames.DSO112.CurrConfigDataFrame(bytes);
                return config;
            }
            catch (InvalidDataFrameException)
            {

            }
            catch (IndexOutOfRangeException)
            {

            }

            return null;
        }

        private void GenerateFrame()
        {
            try
            {
                DSO.DataFrames.CurrParamDataFrame param = new CurrParamDataFrame
                ((Config.VerticalSensitivity)cbxVSens.SelectedItem,
                (Config.Timebase)cbxHSens.SelectedItem,
                (Config.Slope)cbxTrigSlope.SelectedItem,
                (Config.TriggerMode)cbxTrigType.SelectedItem,
                (Config.Coupling)cbxCouple.SelectedIndex,
                (Convert.ToInt16(cbxTrigLevel.Text)),
                (Convert.ToByte(cbxTrigPos.Text)),
                (Config.RecordLength)(Convert.ToInt16(cbxRecLength.Text)),
                (Convert.ToInt16(cbxVpos.Text)));
                SetCommandText(param);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + Environment.StackTrace);
            }
        }

        private void ParametersChanged(object sender, EventArgs e)
        {
            if (gpbParams.Enabled == true)
            {
                GenerateFrame();
            }
        }

        private void btnForceDSO068_Click(object sender, EventArgs e)
        {
            var port = GetSerialPort();
            if(port != null)
            {
                DSO.Utilities.SerialPortAdapter adapter = new DSO.Utilities.SerialPortAdapter(port);
                DSO.DSO068 scope = new DSO068(adapter);
                ForceScopeMode(scope, null);
                this.Close();
            }
           

        }

        private void btnForceDSO112_Click(object sender, EventArgs e)
        {
            var port = GetSerialPort();
            if (port != null)
            {
                DSO.Utilities.SerialPortAdapter adapter = new DSO.Utilities.SerialPortAdapter(port);
                DSO.DSO112 scope = new DSO112(adapter);
                ForceScopeMode(scope, null);
                this.Close();
            }
        }
    }
}

