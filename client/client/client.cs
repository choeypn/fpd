using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Net;
using System.Net.Sockets;
using System.Text;
using Newtonsoft.Json;
namespace @finally
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// Make one button interactable.
        [STAThread]
        static void Main()
        {
            try
            {

            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            TcpClient client = new TcpClient();
            client.Connect("127.0.0.1", 9999);
            String message = "hello";
            // Translate the passed message into ASCII and store it as a Byte array.
            Byte[] data = System.Text.Encoding.ASCII.GetBytes(message);

            // Get a client stream for reading and writing.

            NetworkStream stream = client.GetStream();

            // read message from server
                if (stream.CanRead)
                {
                    byte[] myReadBuffer = new byte[1024];
                    StringBuilder myCompleteMessage = new StringBuilder();
                    int numberOfBytesRead = 0;

                    // Incoming message may be larger than the buffer size.
                    do
                    {
                        numberOfBytesRead = stream.Read(myReadBuffer, 0, myReadBuffer.Length);

                        myCompleteMessage.AppendFormat("{0}", Encoding.ASCII.GetString(myReadBuffer, 0, numberOfBytesRead));
                    }
                    while (stream.DataAvailable);

                    // Print out the received message to the console.
                    Console.WriteLine("You received the following message : " +
                                                 myCompleteMessage);
                }
                else
                {
                    Console.WriteLine("Sorry.  You cannot read from this NetworkStream.");
                }


                // Send the message to the connected TcpServer. 
                stream.Write(data, 0, data.Length);

            Console.WriteLine("Sent: {0}", message);

            // Receive the TcpServer.response.

            // Buffer to store the response bytes.
            data = new Byte[256];

            // String to store the response ASCII representation.
            String responseData = String.Empty;

            // Read the first batch of the TcpServer response bytes.
            Int32 bytes = stream.Read(data, 0, data.Length);
            responseData = System.Text.Encoding.ASCII.GetString(data, 0, bytes);
            Console.WriteLine("Received: {0}", responseData);

            // Close everything.
            stream.Close();
            client.Close();
            }

            catch (ArgumentNullException e)
            {
                Console.WriteLine("ArgumentNullException: {0}", e);
            }
            catch (SocketException e)
            {
                Console.WriteLine("SocketException: {0}", e);
            }

            Console.WriteLine("\n Press Enter to continue...");
            Console.Read();
        }
        private static string prepareJson(Report report)
        {
            return JsonConvert.SerializeObject(report);
        }
    }

    class Report
    {
        String race;
        String hispanic;
        String gender;
        String reason;
        String disposition;
        String date;
    }

    

}