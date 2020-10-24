using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

using System.Net;
using System.Net.Sockets;
namespace server
{
    class Program
    {
        static void Main(string[] args)
        {
            TcpListener server = new TcpListener(IPAddress.Any, 9999);
            server.Start();
            while (true)
            {
                TcpClient clientSocket = server.AcceptTcpClient();

                NetworkStream ns = clientSocket.GetStream();

                byte[] test = new byte[100];
               // test = Encoding.Default.GetBytes("test 1 2 3");

                ns.Write(test, 0, test.Length);

                ClientHandler client = new ClientHandler();
                client.clientOperation(clientSocket);
                


            }
        }
    }

    public class ClientHandler
    {
        TcpClient currentClient;
        public void clientOperation(TcpClient clientSocket)
        {
            Console.WriteLine("You are have a new client");
            currentClient = clientSocket;
            Thread uploadThread = new Thread(Upload); //start new thread for the client
            uploadThread.Start();
        }

        private void Upload()
        {
            NetworkStream ns = currentClient.GetStream();
            byte[] test = new byte[100];
            test = Encoding.Default.GetBytes("test 1 2 3");

            ns.Write(test, 0, test.Length);

            while (currentClient.Connected)
            {
                if (currentClient.Available != 0)
                {
                    byte[] ctest = new byte[1024];
                    Console.WriteLine("Waiting to receive data");
                    ns.Read(ctest, 0, ctest.Length); //Once JSON is implemented, this is where you will re
                    Console.WriteLine("Data received"); //The reports

                    Console.WriteLine(Encoding.Default.GetString(ctest));
                    ns.Flush();
                }
            }
        }
    }
}
