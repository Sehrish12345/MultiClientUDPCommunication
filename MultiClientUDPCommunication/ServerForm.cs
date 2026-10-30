using System.Net.Sockets;
using System.Text;
using System.Net;
using System.Collections.Generic;

namespace MultiClientUDPCommunication
{
    public partial class ServerForm : Form
    {
        private UdpClient udpServer;
        private List<IPEndPoint> connectedClients = new List<IPEndPoint>();
        public ServerForm()
        {
            InitializeComponent();
        }

        private void ServerForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lstConnectedClients_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void grpServerControl_Enter(object sender, EventArgs e)
        {

        }

        private void btnStartServer_Click(object sender, EventArgs e)
        {
            try
            {
                udpServer = new UdpClient(5000);

                _ = ReceiveMessages();

                lblServerStatus.Text = "● Started - Port 5000";
                lblServerStatus.ForeColor = Color.Green;

                btnStartServer.Enabled = false;

                MessageBox.Show("UDP Server Started Successfully!");
            }
            catch (SocketException)
            {
                MessageBox.Show("Port 5000 is already in use.");
            }
        }



        private async Task ReceiveMessages()
        {
            while (true)
            {
                UdpReceiveResult result = await udpServer.ReceiveAsync();

                string fullMessage = Encoding.UTF8.GetString(result.Buffer);

                IPEndPoint senderAddress = result.RemoteEndPoint;

                // Check registration request
                if (fullMessage == "REGISTER")
                {
                    if (!connectedClients.Contains(senderAddress))
                    {
                        connectedClients.Add(senderAddress);

                        this.Invoke((MethodInvoker)delegate
                        {
                            ListViewItem item = new ListViewItem(
                                "Client " + senderAddress.Port);

                            item.SubItems.Add(senderAddress.Address.ToString());

                            lvConnectedClients.Items.Add(item);

                            rtbServerMessages.AppendText(
                                "Client " + senderAddress.Port +
                                " registered successfully." +
                                Environment.NewLine);
                        });
                    }

                    // Send registration confirmation
                    string response = "REGISTERED";

                    byte[] responseData = Encoding.UTF8.GetBytes(response);

                    udpServer.Send(
                        responseData,
                        responseData.Length,
                        senderAddress);

                    continue;
                }

                // Reject messages from unregistered clients
                if (!connectedClients.Contains(senderAddress))
                {
                    continue;
                }

                // Process normal chat messages
                string[] parts = fullMessage.Split('|');

                if (parts.Length < 2)
                {
                    continue;
                }

                string recipient = parts[0];
                string message = parts[1];

                int targetPort = 0;

                if (recipient == "Client 1")
                    targetPort = 5001;
                else if (recipient == "Client 2")
                    targetPort = 5002;
                else if (recipient == "Client 3")
                    targetPort = 5003;

                IPEndPoint targetClient = null;

                foreach (IPEndPoint client in connectedClients)
                {
                    if (client.Port == targetPort)
                    {
                        targetClient = client;
                        break;
                    }
                }

                if (targetClient != null)
                {
                    string senderName = "Client " + (senderAddress.Port - 5000);

                    string displayMessage = senderName + " : " + message;

                    byte[] data = Encoding.UTF8.GetBytes(displayMessage);

                    udpServer.Send(data, data.Length, targetClient);

                    this.Invoke((MethodInvoker)delegate
                    {
                        rtbServerMessages.AppendText(
                            "Client " + senderAddress.Port + " → "
                            + recipient + ": " + message
                            + Environment.NewLine);
                    });
                }
                else
                {
                    this.Invoke((MethodInvoker)delegate
                    {
                        rtbServerMessages.AppendText(
                            recipient + " is not registered yet."
                            + Environment.NewLine);
                    });
                }
            }
        }



    }
}
