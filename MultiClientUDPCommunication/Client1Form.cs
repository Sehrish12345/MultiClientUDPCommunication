using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;

namespace MultiClientUDPCommunication
{
    public partial class Client1Form : Form
    {
        private UdpClient udpClient;
        private int clientPort = 5001;

        public Client1Form()
        {
            InitializeComponent();

            lblClientStatus.Text = "● Disconnected";
            lblClientStatus.ForeColor = Color.Red;
        }
 

        private async Task ReceiveMessages()
        {
            while (true)
            {
                UdpReceiveResult result = await udpClient.ReceiveAsync();

                string message = Encoding.UTF8.GetString(result.Buffer);

                this.Invoke((MethodInvoker)delegate
                {
                    if (message == "REGISTERED")
                    {
                        lblClientStatus.Text = "● Connected - Port 5001";
                        lblClientStatus.ForeColor = Color.Green;

                        MessageBox.Show("Client 1 registered successfully!");
                    }
                    else
                    {
                        rtbClientMessages.AppendText(
                            message + Environment.NewLine);
                    }
                });
            }
        }

        private void grpClientMessages_Enter(object sender, EventArgs e)
        {

        }


        private void btnSendMessage_Click(object sender, EventArgs e)
        {
            if (lblClientStatus.Text == "● Disconnected")
            {
                MessageBox.Show("Please register with the server first.");
                return;
            }
            if (cmbRecipient.SelectedItem == null)
            {
                MessageBox.Show("Please select a recipient first.");
                return;
            }

            string message = rtbMessageInput.Text.Trim();

            if (message == "")
            {
                MessageBox.Show("Please enter a message.");
                return;
            }

            string recipient = cmbRecipient.SelectedItem.ToString();

            string fullMessage = recipient + "|" + message;

            byte[] data = Encoding.UTF8.GetBytes(fullMessage);

            udpClient.Send(data, data.Length, "127.0.0.1", 5000);

            rtbMessageInput.Clear();
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (udpClient == null)
            {
                udpClient = new UdpClient(clientPort);

                _ = ReceiveMessages();
            }

            string message = "REGISTER";

            byte[] data = Encoding.UTF8.GetBytes(message);

            udpClient.Send(data, data.Length, "127.0.0.1", 5000);
        }

    }
}
