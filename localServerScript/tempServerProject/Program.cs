using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

using System.Net;
using System.Net.Sockets;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
namespace tempServerProject
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Directory.CreateDirectory(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "received_report"));
            String usedReportPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "received_report", "recorded_reports");
            Directory.CreateDirectory(usedReportPath);
            
                string masterCSV = "Date" + "," + "Time" + "," + "Race" + "," + "Gender" + ","
                             + "Hispanic" + "," + "Reason" + "," + "Disposition" + "\n";
                string senderpath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "received_report");
                DirectoryInfo d = new DirectoryInfo(senderpath);//Assuming Test is your Folder
                FileInfo[] files = d.GetFiles("*.csv"); //Getting Text files


                foreach (FileInfo file in files)
                {
                    string fileNamePath = senderpath + "\\" + file.Name;
                    string[] lines = System.IO.File.ReadAllLines(@fileNamePath);
                    for(int i = 1; i < lines.Length; i++)
                    {
                        masterCSV = masterCSV + lines[i] + "\n";
                    }
       
                }

                Console.WriteLine("Saving Master CSV");
                moveRecordedReports(usedReportPath);
                saveToCSV(masterCSV);
            return;
        }
        public static void saveToCSV(string masterCSV)
        {
            int num = 1;
            string filename = "!MASTER_CSV" + "_" + DateTime.Now.ToString("ddMMyyy_HHmm_") + num + "!" + ".csv";
            Directory.CreateDirectory(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "received_report"));
            string fullpath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "received_report", filename);
            
            if (File.Exists(fullpath))
            {
                while (File.Exists(fullpath))
                {
                    num++;
                    filename = "!MASTER_CSV" + "_" + DateTime.Now.ToString("ddMMyyy_HHmm_") + num + "!" + ".csv";
                    fullpath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "received_report", filename);
                }
                using (StreamWriter sw = File.CreateText(fullpath))
                {

                    sw.Write(masterCSV);
                }
            }
            else
            {
                using (StreamWriter sw = File.CreateText(fullpath))
                {
                    sw.Write(masterCSV);
                }
            }
        }

        public static void moveRecordedReports(string destinationPath)
        {
            string senderpath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "received_report");
            DirectoryInfo d = new DirectoryInfo(senderpath);//Assuming Test is your Folder
            FileInfo[] files = d.GetFiles("*.csv"); //Getting Text files


            foreach (FileInfo file in files)
            {
                if(!File.Exists(destinationPath + "\\" + file.Name))
                {
                    file.MoveTo(destinationPath + "\\" + file.Name);
                }
                else
                {
                    file.Delete();
                }
            }
        }
    }
}


