using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace @finally
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Report report = new Report();
            for(int i = 0; i < 5; i++)
            {
                Report.setReportVal(i,-1);
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTimePicker timePicker = new DateTimePicker();
            timePicker.Format = DateTimePickerFormat.Time;
            timePicker.ShowUpDown = true;
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            Button click = (Button)sender;
            click.Text = "Submitted";
            click.Enabled = false;
            Console.WriteLine(click.Text);
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
        }


        private void buttonMale_Click(object sender, EventArgs e)
        {

            genderButtonFemale.BackColor = Color.LightGray;
            genderButtonUnidentified.BackColor = Color.LightGray;
            genderButtonMale.BackColor = Color.LightBlue;
            
        }
        private void buttonFemale_Click(object sender, EventArgs e)
        {

            genderButtonMale.BackColor = Color.LightGray;
            genderButtonUnidentified.BackColor = Color.LightGray;
            genderButtonFemale.BackColor = Color.LightBlue;
        }


        private void buttonUnid_Click(object sender, EventArgs e)
        {
            genderButtonMale.BackColor = Color.LightGray;
            genderButtonFemale.BackColor = Color.LightGray;
            genderButtonUnidentified.BackColor = Color.LightBlue;
        }

        private void buttonHispYes_Click(object sender, EventArgs e)
        {
            hispanicButtonUnidentified.BackColor = Color.LightGray;
            hispanicButtonNo.BackColor = Color.LightGray;
            hispanicButtonYes.BackColor = Color.LightBlue;
        }

        private void buttonHispNo_Click(object sender, EventArgs e)
        {
            hispanicButtonUnidentified.BackColor = Color.LightGray;
            hispanicButtonYes.BackColor = Color.LightGray;
            hispanicButtonNo.BackColor = Color.LightBlue;
        }

        private void buttonHispUnid_Click(object sender, EventArgs e)
        {
            hispanicButtonYes.BackColor = Color.LightGray;
            hispanicButtonNo.BackColor = Color.LightGray;
            hispanicButtonUnidentified.BackColor = Color.LightBlue;
        }

        private void buttonReasonSocial_Click(object sender, EventArgs e)
        {
            reasonButtonSocial.BackColor = Color.LightBlue;
            reasonButtonTerry.BackColor = Color.LightGray;
            reasonButtonVehicleEquipment.BackColor = Color.LightGray;
            reasonButtonSpeed.BackColor = Color.LightGray;
            reasonButtonDUI.BackColor = Color.LightGray;
            reasonButtonOther.BackColor = Color.LightGray;
        }

        private void buttonReasonTerry_Click(object sender, EventArgs e)
        {
            reasonButtonSocial.BackColor = Color.LightGray;
            reasonButtonTerry.BackColor = Color.LightBlue;
            reasonButtonVehicleEquipment.BackColor = Color.LightGray;
            reasonButtonSpeed.BackColor = Color.LightGray;
            reasonButtonDUI.BackColor = Color.LightGray;
            reasonButtonOther.BackColor = Color.LightGray;
        }

        private void buttonReasonVehicle_Click(object sender, EventArgs e)
        {
            reasonButtonSocial.BackColor = Color.LightGray;
            reasonButtonTerry.BackColor = Color.LightGray;
            reasonButtonVehicleEquipment.BackColor = Color.LightBlue;
            reasonButtonSpeed.BackColor = Color.LightGray;
            reasonButtonDUI.BackColor = Color.LightGray;
            reasonButtonOther.BackColor = Color.LightGray;
        }

        private void buttonReasonSpeed_Click(object sender, EventArgs e)
        {
            reasonButtonSocial.BackColor = Color.LightGray;
            reasonButtonTerry.BackColor = Color.LightGray;
            reasonButtonVehicleEquipment.BackColor = Color.LightGray;
            reasonButtonSpeed.BackColor = Color.LightBlue;
            reasonButtonDUI.BackColor = Color.LightGray;
            reasonButtonOther.BackColor = Color.LightGray;
        }

        private void buttonReasonDUI_Click(object sender, EventArgs e)
        {
            reasonButtonSocial.BackColor = Color.LightGray;
            reasonButtonTerry.BackColor = Color.LightGray;
            reasonButtonVehicleEquipment.BackColor = Color.LightGray;
            reasonButtonSpeed.BackColor = Color.LightGray;
            reasonButtonDUI.BackColor = Color.LightBlue;
            reasonButtonOther.BackColor = Color.LightGray;
        }

        private void buttonReasonOther_Click(object sender, EventArgs e)
        {
            reasonButtonSocial.BackColor = Color.LightGray;
            reasonButtonTerry.BackColor = Color.LightGray;
            reasonButtonVehicleEquipment.BackColor = Color.LightGray;
            reasonButtonSpeed.BackColor = Color.LightGray;
            reasonButtonDUI.BackColor = Color.LightGray;
            reasonButtonOther.BackColor = Color.LightBlue;
        }

        private void buttonDispNA_Click(object sender, EventArgs e)
        {
            dispositionButtonNoAction.BackColor = Color.LightBlue;
            dispositionButtonVerbalWarning.BackColor = Color.LightGray;
            dispositionButtonInfraction.BackColor = Color.LightGray;
            dispositionButtonCitation.BackColor = Color.LightGray;
            dispositionButtonArrest.BackColor = Color.LightGray;
        }

        private void buttonDispVerbal_Click(object sender, EventArgs e)
        {
            dispositionButtonNoAction.BackColor = Color.LightGray;
            dispositionButtonVerbalWarning.BackColor = Color.LightBlue;
            dispositionButtonInfraction.BackColor = Color.LightGray;
            dispositionButtonCitation.BackColor = Color.LightGray;
            dispositionButtonArrest.BackColor = Color.LightGray;
        }

        private void buttonDispInfraction_Click(object sender, EventArgs e)
        {
            dispositionButtonNoAction.BackColor = Color.LightGray;
            dispositionButtonVerbalWarning.BackColor = Color.LightGray;
            dispositionButtonInfraction.BackColor = Color.LightBlue;
            dispositionButtonCitation.BackColor = Color.LightGray;
            dispositionButtonArrest.BackColor = Color.LightGray;
        }

        private void buttonDispCitation_Click(object sender, EventArgs e)
        {
            dispositionButtonNoAction.BackColor = Color.LightGray;
            dispositionButtonVerbalWarning.BackColor = Color.LightGray;
            dispositionButtonInfraction.BackColor = Color.LightGray;
            dispositionButtonCitation.BackColor = Color.LightBlue;
            dispositionButtonArrest.BackColor = Color.LightGray;
        }

        private void buttonDispArrest_Click(object sender, EventArgs e)
        {
            dispositionButtonNoAction.BackColor = Color.LightGray;
            dispositionButtonVerbalWarning.BackColor = Color.LightGray;
            dispositionButtonInfraction.BackColor = Color.LightGray;
            dispositionButtonCitation.BackColor = Color.LightGray;
            dispositionButtonArrest.BackColor = Color.LightBlue;
        }

        private void buttonRaceAsian_Click(object sender, EventArgs e)
        {
            raceButtonAsian.BackColor = Color.LightBlue;
            raceButtonBlack.BackColor = Color.LightGray;
            raceButtonNativeAmerican.BackColor = Color.LightGray;
            raceButtonOther.BackColor = Color.LightGray;
            raceButtonWhite.BackColor = Color.LightGray;

        }

        private void buttonRaceBlack_Click(object sender, EventArgs e)
        {
            raceButtonAsian.BackColor = Color.LightGray;
            raceButtonBlack.BackColor = Color.LightBlue;
            raceButtonNativeAmerican.BackColor = Color.LightGray;
            raceButtonOther.BackColor = Color.LightGray;
            raceButtonWhite.BackColor = Color.LightGray;

        }

        private void buttonRaceNativeAmerican_Click(object sender, EventArgs e)
        {
            raceButtonAsian.BackColor = Color.LightGray;
            raceButtonBlack.BackColor = Color.LightGray;
            raceButtonNativeAmerican.BackColor = Color.LightBlue;
            raceButtonOther.BackColor = Color.LightGray;
            raceButtonWhite.BackColor = Color.LightGray;
        }

        private void buttonRaceOther_Click(object sender, EventArgs e)
        {
            raceButtonAsian.BackColor = Color.LightGray;
            raceButtonBlack.BackColor = Color.LightGray;
            raceButtonNativeAmerican.BackColor = Color.LightGray;
            raceButtonOther.BackColor = Color.LightBlue;
            raceButtonWhite.BackColor = Color.LightGray;
        }

        private void buttonRaceWhite_Click(object sender, EventArgs e)
        {
            raceButtonAsian.BackColor = Color.LightGray;
            raceButtonBlack.BackColor = Color.LightGray;
            raceButtonNativeAmerican.BackColor = Color.LightGray;
            raceButtonOther.BackColor = Color.LightGray;
            raceButtonWhite.BackColor = Color.LightBlue;
        }

    }
}
