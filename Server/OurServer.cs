using System.Net.Sockets;
using System.Text;


namespace Server
{
    class OurServer
    {
        TcpListener server;

        public OurServer()
        {
            server= new TcpListener(ipAdress.Parse("127.0.0.1"),5555);
            server.Start();

            LoopClients();
        }
        void LoopClients()
        {
            while(true)
            {
                TcpClient client = server.AcceptTcpClient();

                Thread thread = new Thread(() => HandleClient(client));
                thread.Start();


            }
        }

        void HandleClient()
        {
            StreamReader sReader = new StreamReader(client.GetStream(),Encoding.UTFB);

            while(true)
            {
                string message= sReader.ReadLine();
                Console.WriteLine("Клиент написал - {message}");
            }
        }
    }
}