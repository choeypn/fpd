using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

using System.Net;
using System.Net.Sockets;
using MySql.Data.MySqlClient;

namespace server
{
    class Program
    {
        static void Main(string[] args)
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.UserID = "root";
            builder.Password = "";
            builder.Server = "localhost";
            builder.Port = 3306;
            builder.Database = "fpdtrafficstops";
            MySqlConnection connection = new MySqlConnection(builder.ConnectionString);
            
            TcpListener server = new TcpListener(IPAddress.Any, 9999);
            server.Start();
            while (true)
            {
<<<<<<< HEAD
                TcpClient clientSocket = server.AcceptTcpClient();

                NetworkStream ns = clientSocket.GetStream();
=======
                TcpClient client = server.AcceptTcpClient();

                NetworkStream ns = client.GetStream();
>>>>>>> 29a1eb41cb734f9eb1358f77275b9ee616be6c1b

                byte[] test = new byte[100];
               // test = Encoding.Default.GetBytes("test 1 2 3");

                ns.Write(test, 0, test.Length);

                ClientHandler client = new ClientHandler();
                client.clientOperation(clientSocket);
                

<<<<<<< HEAD

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
=======
                ns.Write(test, 0, test.Length);

                while (client.Connected)
>>>>>>> 29a1eb41cb734f9eb1358f77275b9ee616be6c1b
                {
                    byte[] ctest = new byte[1024];
                    Console.WriteLine("Waiting to receive data");
                    ns.Read(ctest, 0, ctest.Length); //Once JSON is implemented, this is where you will re
                    Console.WriteLine("Data received"); //The reports

                    Console.WriteLine(Encoding.Default.GetString(ctest));
<<<<<<< HEAD
                    ns.Flush();
=======
>>>>>>> 29a1eb41cb734f9eb1358f77275b9ee616be6c1b
                }
            }
            
        }

        static void recordReport(MySqlConnection connection, String date, String time, String race, String ethnicity, String gender, String reason, String disposition)
        {
            Console.WriteLine("Record started");
            MySqlCommand command = new MySqlCommand("INSERT INTO reports (stopDate, stopTime, race, ethnicity, gender, reason, disposition)" +
                " VALUES ('" + date + "', '" + time + "', '" + race + "', '" + ethnicity + "', '" + gender + "', '" + reason + "', '" + disposition + "')", connection);
            Console.WriteLine("Command created");
            connection.Open();
            Console.WriteLine("Connection opened");
            command.ExecuteNonQuery();
            Console.WriteLine("Insert completed");
            connection.Close();
        }
    }
}
