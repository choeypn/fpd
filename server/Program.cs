using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
                TcpClient client = server.AcceptTcpClient();

                NetworkStream ns = client.GetStream();

                byte[] test = new byte[100];
                test = Encoding.Default.GetBytes("test 1 2 3");

                ns.Write(test, 0, test.Length);

                while (client.Connected)
                {
                    byte[] ctest = new byte[1024];
                    ns.Read(ctest, 0, ctest.Length);
                    Console.WriteLine(Encoding.Default.GetString(ctest));
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
