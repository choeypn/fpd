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

	private string reportsPath; // made global variable for the path

	private static string[] getAdminInfo() // copied from client code
	{
		string[] lines = System.IO.File.ReadAllLines(
			 Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData), "traffic_report", "admin_info.txt"));
		return lines;
	}

        static void Main(string[] args)
        {

		Console.WriteLine("Compiling Reports...");

		reportsPath = getAdminInfo()[3]; // initialize the global
            

            Directory.CreateDirectory(Path.Combine(reportsPath, "received_reports")); // changed path
            String usedReportPath = Path.Combine(reportsPath, "recorded_reports"); // changed path
            Directory.CreateDirectory(usedReportPath);
            
                string masterCSV = "Date" + "," + "Time" + "," + "Race" + "," + "Gender" + ","
                             + "Hispanic" + "," + "Reason" + "," + "Disposition" + "\n";
                string senderpath = Path.Combine(reportsPath, "received_report");
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

                Console.WriteLine("Saving Master CSV...");
                moveRecordedReports(usedReportPath);
                saveToCSV(masterCSV);
		Console.WriteLine(Master CSV saved);
		Console.WriteLine("Press enter to exit");
		Console.ReadLine();
            return;
        }
        public static void saveToCSV(string masterCSV)
        {
            int num = 1;
            string filename = "!MASTER_CSV" + "_" + DateTime.Now.ToString("ddMMyyy_HHmm_") + num + "!" + ".csv";
            Directory.CreateDirectory(Path.Combine(reportsPath, "received_report")); // changed path
            string fullpath = Path.Combine(reportsPath, "received_report", filename); // changed path
            
            if (File.Exists(fullpath))
            {
                while (File.Exists(fullpath))
                {
                    num++;
                    filename = "!MASTER_CSV" + "_" + DateTime.Now.ToString("ddMMyyy_HHmm_") + num + "!" + ".csv";
                    fullpath = Path.Combine(reportsPath, "received_report", filename); // changed path
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
            string senderpath = Path.Combine(reportsPath, "received_report"); // changed path
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


