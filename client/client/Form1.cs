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

        }


        private void buttonMale_Click(object sender, EventArgs e)
        {

        }
        private void buttonFemale_Click(object sender, EventArgs e)
        {

        }


        private void buttonUnid_Click(object sender, EventArgs e)
        {

        }

        private void buttonHispYes_Click(object sender, EventArgs e)
        {

        }

        private void buttonHispNo_Click(object sender, EventArgs e)
        {

        }

        private void buttonHispUnid_Click(object sender, EventArgs e)
        {

        }

        private void buttonReasonSocial_Click(object sender, EventArgs e)
        {

        }

        private void buttonReasonTerry_Click(object sender, EventArgs e)
        {

        }

        private void buttonReasonVehicle_Click(object sender, EventArgs e)
        {

        }

        private void buttonReasonSpeed_Click(object sender, EventArgs e)
        {

        }

        private void buttonReasonDUI_Click(object sender, EventArgs e)
        {

        }

        private void buttonReasonOther_Click(object sender, EventArgs e)
        {

        }

        private void buttonDispNA_Click(object sender, EventArgs e)
        {

        }

        private void buttonDispVerbal_Click(object sender, EventArgs e)
        {

        }

        private void buttonDispInfraction_Click(object sender, EventArgs e)
        {

        }

        private void buttonDispCitation_Click(object sender, EventArgs e)
        {

        }

        private void buttonDispArrest_Click(object sender, EventArgs e)
        {

        }

        private void buttonRaceAsian_Click(object sender, EventArgs e)
        {

        }

        private void buttonRaceBlack_Click(object sender, EventArgs e)
        {

        }

        private void buttonRaceNA_Click(object sender, EventArgs e)
        {

        }

        private void buttonRaceOther_Click(object sender, EventArgs e)
        {

        }

        private void buttonRaceWhite_Click(object sender, EventArgs e)
        {

        }

    }
}
