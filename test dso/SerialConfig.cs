using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace test_dso
{
    public partial class SerialConfig : Form
    {
        public event EventHandler SerialPortCreated = delegate { };
        public delegate void SerialPortCreatedEventHandler();

        private static SerialConfig instance = null;
        private static readonly object padlock = new object();
        SerialConfig()
        {
            InitializeComponent();
            int[] baudRate = { 115200 };
            foreach(var rate in baudRate)
            {
                cbxComSpeed.Items.Add(rate);
            }
        }
        public static SerialConfig Instance
        {
            get
            {
                lock (padlock)
                {
                    if(instance == null)
                    {
                        instance = new SerialConfig();
                    }
                    instance.cbxComName.Items.Clear();
                    foreach (var p in SerialPort.GetPortNames())
                    {
                        instance.cbxComName.Items.Add(p);
                    }
                    if (instance.cbxComName.Items.Count > 0)
                    {
                        instance.cbxComName.SelectedIndex = 0;
                        instance.cbxComSpeed.SelectedIndex = 0;
                    }else
                    {
                        instance.cbxComName.Text = "";
                        instance.cbxComSpeed.Text = "";
                    }

                    return instance;
                }
            }
        }

        private void SerialConfig_Load(object sender, EventArgs e)
        {

        }
      

        private void btnApply_Click(object sender, EventArgs e)
        {
            try
            {
                SerialPort port = new SerialPort();
                port = new SerialPort();
                port.PortName = (string)cbxComName.SelectedItem;
                port.Parity = Parity.None;
                port.BaudRate = Convert.ToInt32(cbxComSpeed.SelectedItem);
                port.DataBits = 8;
                port.StopBits = StopBits.One;
                port.Open();
                SerialPortCreated(port, null);
                this.Close();
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("No port selected");
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("Port is in use");
            }
            catch (System.IO.IOException)
            {
                MessageBox.Show("Port not exist");
            }

        }
    }
}
