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
