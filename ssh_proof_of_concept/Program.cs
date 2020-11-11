using System;
using Renci.SshNet;
using Renci.SshNet.Sftp;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* String host = "linux-02.cs.wwu.edu";
            int port = 922;
            String username = "ander699";
            String password = "PASSWORD";
            String filePath = "C:/Users/Ferri/source/repos/TextFile1.txt";
            FileInfo f = new FileInfo(filePath);

            using (var sftpclient = new SftpClient(host, port, username, password))
            {
                sftpclient.Connect();
                if (sftpclient.IsConnected)
                {
                    var fileStream = new FileStream(filePath, FileMode.Open);
                    if (fileStream != null)
                    {
                        sftpclient.UploadFile(fileStream, "/home/ander699/" + f.Name, null);
                    }
                    sftpclient.Disconnect();
                    sftpclient.Dispose();
                }
                else
                {
                    Console.WriteLine("OH NO");
                }
            } */

            /*int keyBits = 2048;
            string keyComment = "mykey";

            var keygen = new SshKeyGenerator.SshKeyGenerator(keyBits);

            Console.WriteLine(keygen.ToPrivateKey());
            Console.WriteLine(keygen.ToRfcPublicKey(keyComment)); */

            FileInfo f = new FileInfo("C:/Users/Ferri/source/repos/TextFile.txt");
            ConnectionInfo conn;
            Console.WriteLine("Attempting to establish connection . . . ");
            using (var stream = new FileStream("C:/Users/Ferri/.ssh/id_rsa", FileMode.Open, FileAccess.Read))
            {
                var file = new PrivateKeyFile(stream);
                var authMethod = new PrivateKeyAuthenticationMethod("ander699", file);

                conn = new ConnectionInfo("linux-02.cs.wwu.edu", 922, "ander699", authMethod);
            }
            Console.WriteLine("Connection established");
            var client = new SftpClient(conn);
            client.Connect();
            if (client.IsConnected)
            {
                var fileStream = new FileStream("C:/Users/Ferri/source/repos/TextFile.txt", FileMode.Open);
                if (fileStream != null)
                {
                    client.UploadFile(fileStream, "/home/ander699/" + f.Name, null);
                }
                client.Disconnect();
                client.Dispose();
            }
        }
    }
}

