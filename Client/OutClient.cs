using System.Net.Sockets;
using System.Text;

namespace Client
{
    class OutClient
    {
        TcpClient client;
        StreamWriter sReader;

      public  OutClient()
        {
            client = new TcpClient("127.0.0.1", 5555);
            sReader = new StreamWriter(client.GetStream());

            HandleCommunication();
        }

        void HandleCommunication()
        {
            while(true)
            {
                Console.Write("> ");
                string message = Console.ReadLine();
                sReader.WriteLine(message);
                sReader.Flush();
            }
        }
    }

}
