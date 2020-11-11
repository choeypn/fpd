using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Renci.SshNet;
using Renci.SshNet.Sftp;

namespace @finally
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Report report = new Report();
            Report.reportClear();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //scp files in traffic_report folder to destination
        //TODO : I don't know
        private void buttonUpload_Click(object sender, EventArgs e)
        {

            DirectoryInfo d = new DirectoryInfo(@"C:/Users/natth/Documents/traffic_report/");//Assuming Test is your Folder
            FileInfo[] Files = d.GetFiles("*.csv"); //Getting Text files
            try
            {
                Renci.SshNet.ConnectionInfo conn;
                Console.WriteLine("Attempting to establish connection . . . ");
                using (var stream = new FileStream("C:/Users/natth/.ssh/id_rsa", FileMode.Open, FileAccess.Read))
                {
                    var file = new PrivateKeyFile(stream);
                    var authMethod = new PrivateKeyAuthenticationMethod("choeypn", file);

                    conn = new Renci.SshNet.ConnectionInfo("linux-02.cs.wwu.edu", 922, "choeypn", authMethod);
                }
                Console.WriteLine("Connection established");
                var client = new SftpClient(conn);
                client.Connect();
                foreach (FileInfo file in Files)
                {
                    if (client.IsConnected)
                    {

                        var fileStream = new FileStream("C:/Users/natth/Documents/traffic_report/"+file.Name, FileMode.Open);
                        if (fileStream != null)
                        {
                            client.UploadFile(fileStream, "/home/choeypn/traffic_report/" + file.Name, null);
                        }
                    }
                }
                client.Disconnect();
                client.Dispose();
                Console.WriteLine("File(s) uploaded");

            } catch (Exception ex)
            {
                Console.WriteLine("Transaction error :" + ex.ToString());
            }
            showUploadText();
        }

        private void showUploadText()
        {
            this.uploadText.Visible = true;
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            Button click = (Button)sender;
            //click.Text = "Submitted";
            int errorChecker = 0;
            clearTextBox(sender, e); //clears all textbox backcolor to revisualize the missing data
            for (int i = 0; i < 5; i++)
            {
                if (Report.getReportVal(i) == -1)
                {

                    if (i == 0)
                    {
                        textBoxRace.BackColor = Color.Red;
                    }

                    else if (i == 1)
                    {
                        textBoxGender.BackColor = Color.Red;
                    }

                    else if (i == 2)
                    {
                        textBoxHispanic.BackColor = Color.Red;
                    }

                    else if (i == 3)
                    {
                        textBoxReason.BackColor = Color.Red;
                    }

                    else
                    {
                        textBoxDisposition.BackColor = Color.Red;
                    }
                    errorChecker = -1;
                }
            }

            if(errorChecker == -1)
            {
                return;
            }
            
            click.Enabled = false;

            Report.setDateString(DateTime.Now.ToShortDateString());
            Report.setTimeString(DateTime.Now.ToShortTimeString());

            Console.WriteLine(Report.getRaceString(Report.getReportVal(0)));
            Console.WriteLine(Report.getGenderString(Report.getReportVal(1)));
            Console.WriteLine(Report.getHispanicString(Report.getReportVal(2)));
            Console.WriteLine(Report.getReasonString(Report.getReportVal(3)));
            Console.WriteLine(Report.getDispString(Report.getReportVal(4)));
            Console.WriteLine(Report.getTimeString());
            Console.WriteLine(Report.getDateString());
            Console.WriteLine("Submitted");
            saveToText();

            buttonClear_Click(sender, e);
            showOutputText();
        }

        //shows output text box
        //displays submission date and time in 5 seconds
        private void showOutputText()
        {
            //string[] output = { "FORM SUBMITTED AT ", Report.getTimeString(),Report.getDateString()};
            this.outputText.Text = "FORM LAST SUBMITTED AT " + Report.getTimeString() + " " + Report.getDateString();
            this.outputText.Visible = true;
        }

        /* Sending to server format
    sw.Write(Report.getDateString() + "&"
    + Report.getTimeString() + "&"
    + Report.getRaceString(Report.getReportVal(0)) + "&"
    + Report.getGenderString(Report.getReportVal(1)) + "&"
    + Report.getHispanicString(Report.getReportVal(2)) + "&"
    + Report.getReasonString(Report.getReportVal(3)) + "&"
    + Report.getDispString(Report.getReportVal(4)));
        */
        public static void saveToText()
        {
            int num = 1;
            string filename = Environment.UserName + "_form" + num + ".csv";

            Directory.CreateDirectory(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "traffic_report"));

            string fullpath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),"traffic_report",filename);
            if (File.Exists(fullpath))
            {
                while (File.Exists(fullpath)) 
                {
                    num++;
                    filename = Environment.UserName + "_form" + num + ".csv";
                    fullpath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "traffic_report", filename);
                }
                using (StreamWriter sw = File.CreateText(fullpath))
                {
                    
                    sw.Write(getReportString());
                }
            }
            else
            {
                using (StreamWriter sw = File.CreateText(fullpath))
                {
                    sw.Write(getReportString());
                }
            }
            

        }

        public static string getReportString()
        {
            return ("Date" + "," + "Time" + "," + "Race" + "," + "Gender" + "," 
                            + "Hispanic" + "," + "Reason" + "," + "Disposition" + "\n"
                            + "\"" + Report.getDateString() + "\"," 
                            + "\"" + Report.getTimeString() + "\","
                            + "\"" + Report.getRaceString(Report.getReportVal(0)) + "\","
                            + "\"" + Report.getGenderString(Report.getReportVal(1)) + "\","
                            + "\"" + Report.getHispanicString(Report.getReportVal(2)) + "\","
                            + "\"" + Report.getReasonString(Report.getReportVal(3)) + "\","
                            + "\"" + Report.getDispString(Report.getReportVal(4)) + "\"");
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            genderButtonFemale.BackColor = Color.LightGray;
            genderButtonUnidentified.BackColor = Color.LightGray;
            genderButtonMale.BackColor = Color.LightGray;

            hispanicButtonUnidentified.BackColor = Color.LightGray;
            hispanicButtonYes.BackColor = Color.LightGray;
            hispanicButtonNo.BackColor = Color.LightGray;

            reasonButtonSocial.BackColor = Color.LightGray;
            reasonButtonTerry.BackColor = Color.LightGray;
            reasonButtonVehicleEquipment.BackColor = Color.LightGray;
            reasonButtonSpeed.BackColor = Color.LightGray;
            reasonButtonDUI.BackColor = Color.LightGray;
            reasonButtonOther.BackColor = Color.LightGray;

            dispositionButtonNoAction.BackColor = Color.LightGray;
            dispositionButtonVerbalWarning.BackColor = Color.LightGray;
            dispositionButtonInfraction.BackColor = Color.LightGray;
            dispositionButtonCitation.BackColor = Color.LightGray;
            dispositionButtonArrest.BackColor = Color.LightGray;

            raceButtonAsian.BackColor = Color.LightGray;
            raceButtonBlack.BackColor = Color.LightGray;
            raceButtonNativeAmerican.BackColor = Color.LightGray;
            raceButtonOther.BackColor = Color.LightGray;
            raceButtonWhite.BackColor = Color.LightGray;
            clearTextBox(sender, e);
            buttonSubmit.Enabled = true;
            this.outputText.Visible = false;
            this.uploadText.Visible = false;
            Report.reportClear();
        }

        private void clearTextBox(int idx)
        {
            switch (idx)
            {
                case 0:
                    textBoxRace.BackColor = Color.White;
                    break;
                case 1:
                    textBoxGender.BackColor = Color.White;
                    break;
                case 2:
                    textBoxHispanic.BackColor = Color.White;
                    break;
                case 3:
                    textBoxReason.BackColor = Color.White;
                    break;
                case 4:
                    textBoxDisposition.BackColor = Color.White;
                    break;

            }
        }

        private void clearTextBox(Object sender, EventArgs e)
        {
            textBoxRace.BackColor = Color.White;
            textBoxGender.BackColor = Color.White;
            textBoxHispanic.BackColor = Color.White;
            textBoxReason.BackColor = Color.White;
            textBoxDisposition.BackColor = Color.White;
        }

        private void buttonMale_Click(object sender, EventArgs e)
        {

            genderButtonFemale.BackColor = Color.LightGray;
            genderButtonUnidentified.BackColor = Color.LightGray;
            genderButtonMale.BackColor = Color.LightBlue;
            Report.setReportVal(1, 0);
            clearTextBox(1);
        }

        private void buttonFemale_Click(object sender, EventArgs e)
        {

            genderButtonMale.BackColor = Color.LightGray;
            genderButtonUnidentified.BackColor = Color.LightGray;
            genderButtonFemale.BackColor = Color.LightBlue;
            Report.setReportVal(1, 1);
            clearTextBox(1);
        }


        private void buttonUnid_Click(object sender, EventArgs e)
        {
            genderButtonMale.BackColor = Color.LightGray;
            genderButtonFemale.BackColor = Color.LightGray;
            genderButtonUnidentified.BackColor = Color.LightBlue;
            Report.setReportVal(1, 2);
            clearTextBox(1);
        }

        private void buttonHispYes_Click(object sender, EventArgs e)
        {
            hispanicButtonUnidentified.BackColor = Color.LightGray;
            hispanicButtonNo.BackColor = Color.LightGray;
            hispanicButtonYes.BackColor = Color.LightBlue;
            Report.setReportVal(2, 0);
            clearTextBox(2);
        }

        private void buttonHispNo_Click(object sender, EventArgs e)
        {
            hispanicButtonUnidentified.BackColor = Color.LightGray;
            hispanicButtonYes.BackColor = Color.LightGray;
            hispanicButtonNo.BackColor = Color.LightBlue;
            Report.setReportVal(2, 1);
            clearTextBox(2);
        }

        private void buttonHispUnid_Click(object sender, EventArgs e)
        {
            hispanicButtonYes.BackColor = Color.LightGray;
            hispanicButtonNo.BackColor = Color.LightGray;
            hispanicButtonUnidentified.BackColor = Color.LightBlue;
            Report.setReportVal(2, 2);
            clearTextBox(2);
        }

        private void buttonReasonSocial_Click(object sender, EventArgs e)
        {
            reasonButtonSocial.BackColor = Color.LightBlue;
            reasonButtonTerry.BackColor = Color.LightGray;
            reasonButtonVehicleEquipment.BackColor = Color.LightGray;
            reasonButtonSpeed.BackColor = Color.LightGray;
            reasonButtonDUI.BackColor = Color.LightGray;
            reasonButtonOther.BackColor = Color.LightGray;
            Report.setReportVal(3, 0);
            clearTextBox(3);
        }

        private void buttonReasonTerry_Click(object sender, EventArgs e)
        {
            reasonButtonSocial.BackColor = Color.LightGray;
            reasonButtonTerry.BackColor = Color.LightBlue;
            reasonButtonVehicleEquipment.BackColor = Color.LightGray;
            reasonButtonSpeed.BackColor = Color.LightGray;
            reasonButtonDUI.BackColor = Color.LightGray;
            reasonButtonOther.BackColor = Color.LightGray;
            Report.setReportVal(3, 1);
            clearTextBox(3);
        }

        private void buttonReasonVehicle_Click(object sender, EventArgs e)
        {
            reasonButtonSocial.BackColor = Color.LightGray;
            reasonButtonTerry.BackColor = Color.LightGray;
            reasonButtonVehicleEquipment.BackColor = Color.LightBlue;
            reasonButtonSpeed.BackColor = Color.LightGray;
            reasonButtonDUI.BackColor = Color.LightGray;
            reasonButtonOther.BackColor = Color.LightGray;
            Report.setReportVal(3, 2);
            clearTextBox(3);
        }

        private void buttonReasonSpeed_Click(object sender, EventArgs e)
        {
            reasonButtonSocial.BackColor = Color.LightGray;
            reasonButtonTerry.BackColor = Color.LightGray;
            reasonButtonVehicleEquipment.BackColor = Color.LightGray;
            reasonButtonSpeed.BackColor = Color.LightBlue;
            reasonButtonDUI.BackColor = Color.LightGray;
            reasonButtonOther.BackColor = Color.LightGray;
            Report.setReportVal(3, 3);
            clearTextBox(3);
        }

        private void buttonReasonDUI_Click(object sender, EventArgs e)
        {
            reasonButtonSocial.BackColor = Color.LightGray;
            reasonButtonTerry.BackColor = Color.LightGray;
            reasonButtonVehicleEquipment.BackColor = Color.LightGray;
            reasonButtonSpeed.BackColor = Color.LightGray;
            reasonButtonDUI.BackColor = Color.LightBlue;
            reasonButtonOther.BackColor = Color.LightGray;
            Report.setReportVal(3, 4);
            clearTextBox(3);
        }

        private void buttonReasonOther_Click(object sender, EventArgs e)
        {
            reasonButtonSocial.BackColor = Color.LightGray;
            reasonButtonTerry.BackColor = Color.LightGray;
            reasonButtonVehicleEquipment.BackColor = Color.LightGray;
            reasonButtonSpeed.BackColor = Color.LightGray;
            reasonButtonDUI.BackColor = Color.LightGray;
            reasonButtonOther.BackColor = Color.LightBlue;
            Report.setReportVal(3, 5);
            clearTextBox(3);
        }

        private void buttonDispNA_Click(object sender, EventArgs e)
        {
            dispositionButtonNoAction.BackColor = Color.LightBlue;
            dispositionButtonVerbalWarning.BackColor = Color.LightGray;
            dispositionButtonInfraction.BackColor = Color.LightGray;
            dispositionButtonCitation.BackColor = Color.LightGray;
            dispositionButtonArrest.BackColor = Color.LightGray;
            Report.setReportVal(4, 0);
            clearTextBox(4);
        }

        private void buttonDispVerbal_Click(object sender, EventArgs e)
        {
            dispositionButtonNoAction.BackColor = Color.LightGray;
            dispositionButtonVerbalWarning.BackColor = Color.LightBlue;
            dispositionButtonInfraction.BackColor = Color.LightGray;
            dispositionButtonCitation.BackColor = Color.LightGray;
            dispositionButtonArrest.BackColor = Color.LightGray;
            Report.setReportVal(4, 1);
            clearTextBox(4);
        }

        private void buttonDispInfraction_Click(object sender, EventArgs e)
        {
            dispositionButtonNoAction.BackColor = Color.LightGray;
            dispositionButtonVerbalWarning.BackColor = Color.LightGray;
            dispositionButtonInfraction.BackColor = Color.LightBlue;
            dispositionButtonCitation.BackColor = Color.LightGray;
            dispositionButtonArrest.BackColor = Color.LightGray;
            Report.setReportVal(4, 2);
            clearTextBox(4);
        }

        private void buttonDispCitation_Click(object sender, EventArgs e)
        {
            dispositionButtonNoAction.BackColor = Color.LightGray;
            dispositionButtonVerbalWarning.BackColor = Color.LightGray;
            dispositionButtonInfraction.BackColor = Color.LightGray;
            dispositionButtonCitation.BackColor = Color.LightBlue;
            dispositionButtonArrest.BackColor = Color.LightGray;
            Report.setReportVal(4, 3);
            clearTextBox(4);
        }

        private void buttonDispArrest_Click(object sender, EventArgs e)
        {
            dispositionButtonNoAction.BackColor = Color.LightGray;
            dispositionButtonVerbalWarning.BackColor = Color.LightGray;
            dispositionButtonInfraction.BackColor = Color.LightGray;
            dispositionButtonCitation.BackColor = Color.LightGray;
            dispositionButtonArrest.BackColor = Color.LightBlue;
            Report.setReportVal(4, 4);
            clearTextBox(4);
        }

        private void buttonRaceAsian_Click(object sender, EventArgs e)
        {
            raceButtonAsian.BackColor = Color.LightBlue;
            raceButtonBlack.BackColor = Color.LightGray;
            raceButtonNativeAmerican.BackColor = Color.LightGray;
            raceButtonOther.BackColor = Color.LightGray;
            raceButtonWhite.BackColor = Color.LightGray;
            Report.setReportVal(0, 0);
            clearTextBox(0);
        }

        private void buttonRaceBlack_Click(object sender, EventArgs e)
        {
            raceButtonAsian.BackColor = Color.LightGray;
            raceButtonBlack.BackColor = Color.LightBlue;
            raceButtonNativeAmerican.BackColor = Color.LightGray;
            raceButtonOther.BackColor = Color.LightGray;
            raceButtonWhite.BackColor = Color.LightGray;
            Report.setReportVal(0, 1);
            clearTextBox(0);
        }

        private void buttonRaceNativeAmerican_Click(object sender, EventArgs e)
        {
            raceButtonAsian.BackColor = Color.LightGray;
            raceButtonBlack.BackColor = Color.LightGray;
            raceButtonNativeAmerican.BackColor = Color.LightBlue;
            raceButtonOther.BackColor = Color.LightGray;
            raceButtonWhite.BackColor = Color.LightGray;
            Report.setReportVal(0, 2);
            clearTextBox(0);
        }

        private void buttonRaceOther_Click(object sender, EventArgs e)
        {
            raceButtonAsian.BackColor = Color.LightGray;
            raceButtonBlack.BackColor = Color.LightGray;
            raceButtonNativeAmerican.BackColor = Color.LightGray;
            raceButtonOther.BackColor = Color.LightBlue;
            raceButtonWhite.BackColor = Color.LightGray;
            Report.setReportVal(0, 3);
            clearTextBox(0);
        }

        private void buttonRaceWhite_Click(object sender, EventArgs e)
        {
            raceButtonAsian.BackColor = Color.LightGray;
            raceButtonBlack.BackColor = Color.LightGray;
            raceButtonNativeAmerican.BackColor = Color.LightGray;
            raceButtonOther.BackColor = Color.LightGray;
            raceButtonWhite.BackColor = Color.LightBlue;
            Report.setReportVal(0, 4);
            clearTextBox(0);
        }
    }
}
