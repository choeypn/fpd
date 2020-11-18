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

            }catch(Exception e)
            {
                Console.WriteLine(e);
            }
                
        }
    }

    class adminInfo
    {
        static string receiverUsername;
        static string server;
        static int port;
        static string receiverpath;
        public adminInfo(string[] input)
        {
            receiverUsername = input[0];
            server = input[1];
            port = Int32.Parse(input[2]);
            receiverpath = input[3];
        }
        public string getReceiverUsername()
        {
            return receiverUsername;
        }
        public string getServer()
        {
            return server;
        }
        public int getPort()
        {
            return port;
        }
        public string getReceiverPath()
        {
            return receiverpath;
        }
    }

    class Report
    {
        static String date;
        static String time;
        static int[] reportVal = new int[5];

        public static String getDateString()
        {
            return date;
        }

        public static void setDateString(String val)
        {
            date = val;
        }

        public static String getTimeString()
        {
            return time;
        }

        public static void setTimeString(String val)
        {
            time = val;
        }

        public static int getReportVal(int idx)
        {
            return reportVal[idx];
        }

        public static void setReportVal(int idx, int val)
        {
            reportVal[idx] = val;
        }

        public static String getRaceString(int val)
        {
            String ret = "";
            switch (val)
            {
                case 0:
                    ret = "Asian/Pacific Islander";
                    break;
                case 1:
                    ret = "Black";
                    break;
                case 2:
                    ret = "Native American";
                    break;
                case 3:
                    ret = "Other/Unknown";
                    break;
                case 4:
                    ret = "White";
                    break;

            }
            return ret;
        }


        public static String getGenderString(int val)
        {
            String ret = "";
            switch (val)
            {
                case 0:
                    ret = "Male";
                    break;
                case 1:
                    ret = "Female";
                    break;
                case 2:
                    ret = "Unidentified";
                    break;
            }
            return ret;
        }

        public static String getHispanicString(int val)
        {
            String ret = "";
            switch (val)
            {
                case 0:
                    ret = "Yes";
                    break;
                case 1:
                    ret = "No";
                    break;
                case 2:
                    ret = "Unidentified";
                    break;
            }
            return ret;
        }

        public static String getReasonString(int val)
        {
            String ret = "";
            switch (val)
            {
                case 0:
                    ret = "Social";
                    break;
                case 1:
                    ret = "Terry";
                    break;
                case 2:
                    ret = "Vehicle";
                    break;
                case 3:
                    ret = "Speed";
                    break;
                case 4:
                    ret = "DUI";
                    break;
                case 5:
                    ret = "Other";
                    break;

            }
            return ret;
        }

        public static String getDispString(int val)
        {
            String ret = "";
            switch (val)
            {
                case 0:
                    ret = "NO Action";
                    break;
                case 1:
                    ret = "Verbal Warning";
                    break;
                case 2:
                    ret = "Infraction";
                    break;
                case 3:
                    ret = "Citation";
                    break;
                case 4:
                    ret = "Arrest";
                    break;

            }
            return ret;
        }

        public static void reportClear()
        {
            for(int i = 0; i < reportVal.Length; i++)
            {
                reportVal[i] = -1;
            }
        }

    }
}