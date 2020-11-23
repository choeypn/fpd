using System;
using Renci.SshNet;
using Renci.SshNet.Sftp;
using System.IO;

namespace MakeKeysTest
{
    class Program
    {
        static void Main(string[] args)
        {

            var systemPath = System.Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
            var path = Path.Combine(systemPath, "traffic_report", ".ssh");
            int keyBits = 2048;
            var keygen = new SshKeyGenerator.SshKeyGenerator(keyBits);

            if (File.Exists(Path.Combine(path, "id_rsa")))
            {
                Console.WriteLine("id_rsa already exists in the following directory:");
                Console.WriteLine(path);
            }
            else
            {
                Directory.CreateDirectory(path);
                Console.WriteLine("Creating Keys...");
                using (StreamWriter sw = File.CreateText(Path.Combine(path, "id_rsa")))
                {
                    sw.WriteLine(keygen.ToPrivateKey());
                }
                using (StreamWriter sw = File.CreateText(Path.Combine(path, "id_rsa.pub")))
                {
                    sw.WriteLine(keygen.ToRfcPublicKey());
                }
                Console.WriteLine("Key files have been created. id_rsa is a private key, and should not be moved or distributed. id_rsa.pub is a public key, and should be added to the server's list of autorized keys.");
                Console.WriteLine("The key files can be found in the following directory:");
                Console.WriteLine(path);
            }

            /*int keyBits = 2048;
            string keyComment = "mykey";

            var keygen = new SshKeyGenerator.SshKeyGenerator(keyBits);

            Console.WriteLine(keygen.ToPrivateKey());
            Console.WriteLine(keygen.ToRfcPublicKey(keyComment));*/
            Console.WriteLine("Press enter to close this window");
            Console.ReadLine();
        }
    }
}
