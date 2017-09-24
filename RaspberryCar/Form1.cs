using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Net.Sockets;

namespace RaspberryCar
{
    public partial class MainForm : Form
    {
        private Socket soc;
        public MainForm()
        {
            InitializeComponent();
            
        }

        private void btnConn_Click(object sender, EventArgs e)
        {
            if (btnConnect.Text == "Connect")
            {
                soc = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                System.Net.IPAddress ipAdd = System.Net.IPAddress.Parse(txtIPAdress.Text.ToString());
                System.Net.IPEndPoint remoteEP = new IPEndPoint(ipAdd, Convert.ToInt32(txtPort.Text.ToString()));
                soc.Connect(remoteEP);
                MainForm.ActiveForm.Focus();
                btnConnect.Text = "Disonnect";
                stsConnect.Text = "Connected";
            }
            else
            {
                soc.Close();
                btnConnect.Text = "Connect";
                stsConnect.Text = "Disconnected";
            }
        }

        private void ServoControl(string ctrString)
        {
            try
            {
                byte[] byData = System.Text.Encoding.ASCII.GetBytes(ctrString);
                soc.Send(byData);
            }
            catch { }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                soc.Close();
            }
            catch { }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            ServoControl("Up");
        }

        private void btnDe_Click(object sender, EventArgs e)
        {
            ServoControl("Down");
        }
    }
}
