using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.IO.Ports;
using System.Windows.Forms;

namespace co2
{
    public partial class Form_EntrerBadge : Form
    {
        public Form_EntrerBadge()
        {
            InitializeComponent();
            foreach (string s in System.IO.Ports.SerialPort.GetPortNames())
            {
                t_com.Items.Add(s);
            }
        }
        SerialPort my_serie;
        string baudrate = "9600";

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                my_serie = new System.IO.Ports.SerialPort(t_com.Text);
                my_serie.BaudRate = Convert.ToInt32(baudrate);
                my_serie.DataBits = 8;
                my_serie.StopBits = StopBits.One;
                my_serie.Parity = Parity.None;
                my_serie.Handshake = Handshake.None;
                my_serie.Open();
                my_serie.DataReceived += new SerialDataReceivedEventHandler(ReceptionSerie);
                //"Ouverture du port " + portCom;
                if (my_serie.IsOpen) MessageBox.Show("Vous êtes connecté !");
            }
            catch { }
        }

        delegate void SetTextCallback(string text);
        private void ReceptionSerie(object sender, SerialDataReceivedEventArgs e)
        {

            Thread.Sleep(750);///attente pour les gros paquets de données
            string data = my_serie.ReadExisting();
            byte[] bytes = Encoding.UTF8.GetBytes(data);
            SetText(data);

        }

        private void SetText(string textCOM)
        {

            if (labeldata.InvokeRequired)
            {

                SetTextCallback d = new SetTextCallback(SetText);
                labeldata.Invoke(d, new object[] { textCOM });

                string input = this.labeldata.Text;
                char[] values = input.ToCharArray();
                textCOM = string.Empty;
                foreach (char letter in values)
                {
                    int value = Convert.ToInt32(letter);
                    textCOM += String.Format("{0:X}", value); ;
                }
            }
            else
            {
                labeldata.Text = textCOM;

            }
        }
    }
}
