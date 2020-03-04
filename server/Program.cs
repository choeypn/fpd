using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
            while(true){
                TcpClient client = server.AcceptTcpClient();
                
                NetworkStream ns = client.GetStream();
                
                byte[] test = new byte[100];
                test = Encoding.Default.GetBytes("test 1 2 3");

                ns.Write(test,0,test.Length);

                while(client.Connected){
                    byte[] ctest = new byte[1024];
                    ns.Read(ctest, 0, ctest.Length);
                    Console.WriteLine(Encoding.Default.GetString(ctest));
            }
        }
    }
}
