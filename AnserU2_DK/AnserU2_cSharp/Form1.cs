using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnserU2_cSharp
{
    public partial class Form1 : Form
    {
        public SerialPort _serialPort;

        private System.Windows.Forms.Timer _timer = new System.Windows.Forms.Timer();
        private bool _status = false;

        public Form1()
        {
            InitializeComponent();
            Load += Form1_Load;
            FormClosing += Form1_FormClosing;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SerialClose();


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            foreach (var item in ports)
            {
                _ccbComPort.Items.Add(item);
            }

            SerialportConnect();

            //_timer.Interval = 1000;
            //_timer.Tick += _timer_Tick;
            //_timer.Enabled = false;
            //_timer.Start();
            //SerialportConnect();
        }

        private void _timer_Tick(object sender, EventArgs e)
        {
            _timer.Enabled = false;

            if (!_status)
            {
                SerialClose();

                Thread.Sleep(1000);

                SerialportConnect();

                Debug.WriteLine($"Reconnect");
            }

            _timer.Enabled = true;
        }

        public void SerialportConnect()
        {
            DateTime dt = DateTime.Now;
            String dtn = dt.ToShortTimeString();

            _serialPort = new System.IO.Ports.SerialPort($"COM17", 9600, Parity.None, 8, StopBits.One);
            try
            {
                _serialPort.DataReceived += new SerialDataReceivedEventHandler(SerialPort_DataReceived);
                _serialPort.Open();
                Console.WriteLine("[" + dtn + "] " + "Connected\n");
                _status = true;
                _timer.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
                _status = false;
            }
        }

        private void SerialClose()
        {
            DateTime dt = DateTime.Now;
            String dtn = dt.ToShortTimeString();
            try
            {
                _serialPort = null;
                _serialPort = new SerialPort();

                //if (_serialPort.IsOpen)
                //{
                //    _serialPort.Close();
                //    _serialPort.Dispose();
                //}
            }
            catch (Exception)
            {

            }
        }

        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                System.Threading.Thread.Sleep(100);
                string dataRCV = _serialPort.ReadExisting(); // Read
                var dataRCVArray = dataRCV.Split('\r');
                var employeeId = dataRCVArray[0].Substring(dataRCVArray[0].Length - 5, 5);

                if (string.IsNullOrEmpty(dataRCV))
                {
                    return;
                }

                var rcvArr = Encoding.ASCII.GetBytes(dataRCV);

                this.Invoke((MethodInvoker)delegate
                {
                    _labEmpId.Text = employeeId;
                });
                Console.WriteLine(dataRCV);
            }
            catch (Exception)
            {
                
            }
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            //SerialportConnect();
            var nf = new Form2();
            nf.ShowDialog();
        }
    }
}
