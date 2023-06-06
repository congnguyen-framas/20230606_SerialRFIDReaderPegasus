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

namespace AnserU2_cSharp
{
    public partial class Form1 : Form
    {
        public SerialPort _serialPort;

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


            //SerialportConnect();
        }

        public void SerialportConnect()
        {
            DateTime dt = DateTime.Now;
            String dtn = dt.ToShortTimeString();

            _serialPort = new System.IO.Ports.SerialPort($"{_ccbComPort.Text}", 9600, Parity.None, 8, StopBits.One);
            try
            {
                _serialPort.DataReceived += new SerialDataReceivedEventHandler(SerialPort_DataReceived);
                _serialPort.Open();
                Console.WriteLine("[" + dtn + "] " + "Connected\n");
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString(), "Error"); }
        }

        private void SerialClose()
        {
            DateTime dt = DateTime.Now;
            String dtn = dt.ToShortTimeString();

            if (_serialPort.IsOpen)
            {
                _serialPort.Close();
                _serialPort.Dispose();
            }
        }

        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            //try
            {
                System.Threading.Thread.Sleep(100);
                string dataRCV = _serialPort.ReadExisting(); // Read
                if (string.IsNullOrEmpty(dataRCV))
                {
                    return;
                }

                var rcvArr = Encoding.ASCII.GetBytes(dataRCV);

                Console.WriteLine(dataRCV);
            }
            //catch (Exception)
            //{

            //    throw;
            //}
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
                SerialportConnect();
        }
    }
}
