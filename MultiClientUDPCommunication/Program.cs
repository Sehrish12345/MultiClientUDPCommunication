
namespace MultiClientUDPCommunication
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {

            ApplicationConfiguration.Initialize();

            ServerForm server = new ServerForm();
            server.StartPosition = FormStartPosition.Manual;
            server.Location = new Point(20, 20);
            server.Show();

            Client2Form client2 = new Client2Form();
            client2.StartPosition = FormStartPosition.Manual;
            client2.Location = new Point(760, 20);
            client2.Show();

            Client3Form client3 = new Client3Form();
            client3.StartPosition = FormStartPosition.Manual;
            client3.Location = new Point(760, 460);
            client3.Show();

            Client1Form client1 = new Client1Form();
            client1.StartPosition = FormStartPosition.Manual;
            client1.Location = new Point(20, 460);

            Application.Run(client1);
        }
    }
}
