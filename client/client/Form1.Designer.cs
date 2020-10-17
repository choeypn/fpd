namespace @finally
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DateTimePicker dateTimePicker1;
            System.Windows.Forms.DateTimePicker dateTimePicker2;
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.genderButtonMale = new System.Windows.Forms.Button();
            this.genderButtonFemale = new System.Windows.Forms.Button();
            this.genderButtonUnidentified = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.hispanicButtonYes = new System.Windows.Forms.Button();
            this.hispanicButtonNo = new System.Windows.Forms.Button();
            this.hispanicButtonUnidentified = new System.Windows.Forms.Button();
            this.reasonButtonSocial = new System.Windows.Forms.Button();
            this.reasonButtonTerry = new System.Windows.Forms.Button();
            this.reasonButtonVehicleEquipment = new System.Windows.Forms.Button();
            this.reasonButtonSpeed = new System.Windows.Forms.Button();
            this.reasonButtonDUI = new System.Windows.Forms.Button();
            this.reasonButtonOther = new System.Windows.Forms.Button();
            this.dispositionButtonNoAction = new System.Windows.Forms.Button();
            this.dispositionButtonVerbalWarning = new System.Windows.Forms.Button();
            this.dispositionButtonInfraction = new System.Windows.Forms.Button();
            this.dispositionButtonCitation = new System.Windows.Forms.Button();
            this.dispositionButtonArrest = new System.Windows.Forms.Button();
            this.raceButtonAsian = new System.Windows.Forms.Button();
            this.raceButtonBlack = new System.Windows.Forms.Button();
            this.raceButtonNativeAmerican = new System.Windows.Forms.Button();
            this.raceButtonOther = new System.Windows.Forms.Button();
            this.raceButtonWhite = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dateTimePicker1.Location = new System.Drawing.Point(126, 41);
            dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            dateTimePicker1.Size = new System.Drawing.Size(212, 20);
            dateTimePicker1.TabIndex = 3;
            dateTimePicker1.UseWaitCursor = true;
            dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            dateTimePicker2.Location = new System.Drawing.Point(461, 41);
            dateTimePicker2.Margin = new System.Windows.Forms.Padding(2);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            dateTimePicker2.ShowUpDown = true;
            dateTimePicker2.Size = new System.Drawing.Size(106, 20);
            dateTimePicker2.TabIndex = 3;
            dateTimePicker2.UseWaitCursor = true;
            dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(70, 124);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(95, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "Race";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.buttonSubmit.Location = new System.Drawing.Point(625, 249);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(102, 45);
            this.buttonSubmit.TabIndex = 6;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonClear
            // 
<<<<<<< HEAD
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.button1.Location = new System.Drawing.Point(625, 341);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 45);
            this.button1.TabIndex = 14;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
=======
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.buttonClear.Location = new System.Drawing.Point(625, 341);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(102, 45);
            this.buttonClear.TabIndex = 14;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
>>>>>>> 9fb971686ae1d2d77bbd271a575da65c2b3d8110
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(203, 124);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(96, 20);
            this.textBox2.TabIndex = 5;
            this.textBox2.Text = "Gender";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(338, 124);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(94, 20);
            this.textBox3.TabIndex = 5;
            this.textBox3.Text = "Reason";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(472, 124);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(130, 20);
            this.textBox4.TabIndex = 5;
            this.textBox4.Text = "Disposition";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
<<<<<<< HEAD
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button8.Location = new System.Drawing.Point(212, 159);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(73, 34);
            this.button8.TabIndex = 18;
            this.button8.Text = "M";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button9.Location = new System.Drawing.Point(212, 210);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(73, 34);
            this.button9.TabIndex = 18;
            this.button9.Text = "F";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button10.Location = new System.Drawing.Point(212, 260);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(73, 34);
            this.button10.TabIndex = 18;
            this.button10.Text = "U";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
=======
            // genderButtonMale
            // 
            this.genderButtonMale.BackColor = System.Drawing.SystemColors.Highlight;
            this.genderButtonMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.genderButtonMale.Location = new System.Drawing.Point(212, 159);
            this.genderButtonMale.Name = "genderButtonMale";
            this.genderButtonMale.Size = new System.Drawing.Size(73, 34);
            this.genderButtonMale.TabIndex = 18;
            this.genderButtonMale.Text = "M";
            this.genderButtonMale.UseVisualStyleBackColor = false;
            // 
            // genderButtonFemale
            // 
            this.genderButtonFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.genderButtonFemale.Location = new System.Drawing.Point(212, 210);
            this.genderButtonFemale.Name = "genderButtonFemale";
            this.genderButtonFemale.Size = new System.Drawing.Size(73, 34);
            this.genderButtonFemale.TabIndex = 18;
            this.genderButtonFemale.Text = "F";
            this.genderButtonFemale.UseVisualStyleBackColor = true;
            this.genderButtonFemale.Click += new System.EventHandler(this.button9_Click);
            // 
            // genderButtonUnidentified
            // 
            this.genderButtonUnidentified.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.genderButtonUnidentified.Location = new System.Drawing.Point(212, 260);
            this.genderButtonUnidentified.Name = "genderButtonUnidentified";
            this.genderButtonUnidentified.Size = new System.Drawing.Size(73, 34);
            this.genderButtonUnidentified.TabIndex = 18;
            this.genderButtonUnidentified.Text = "U";
            this.genderButtonUnidentified.UseVisualStyleBackColor = true;
            this.genderButtonUnidentified.Click += new System.EventHandler(this.button10_Click);
>>>>>>> 9fb971686ae1d2d77bbd271a575da65c2b3d8110
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(203, 326);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(96, 20);
            this.textBox5.TabIndex = 5;
            this.textBox5.Text = "Hispanic";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
<<<<<<< HEAD
            // button11
            // 
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button11.Location = new System.Drawing.Point(212, 352);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(73, 34);
            this.button11.TabIndex = 18;
            this.button11.Text = "Y";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button12.Location = new System.Drawing.Point(212, 403);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(73, 34);
            this.button12.TabIndex = 18;
            this.button12.Text = "N";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button13
            // 
            this.button13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button13.Location = new System.Drawing.Point(212, 453);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(73, 34);
            this.button13.TabIndex = 18;
            this.button13.Text = "U";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button10_Click);
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button14.Location = new System.Drawing.Point(348, 159);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(73, 34);
            this.button14.TabIndex = 18;
            this.button14.Text = "SO";
            this.button14.UseVisualStyleBackColor = false;
            // 
            // button15
            // 
            this.button15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button15.Location = new System.Drawing.Point(348, 210);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(73, 34);
            this.button15.TabIndex = 18;
            this.button15.Text = "TE";
            this.button15.UseVisualStyleBackColor = true;
            // 
            // button16
            // 
            this.button16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button16.Location = new System.Drawing.Point(348, 260);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(73, 34);
            this.button16.TabIndex = 18;
            this.button16.Text = "EQ";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button10_Click);
            // 
            // button17
            // 
            this.button17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button17.Location = new System.Drawing.Point(348, 312);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(73, 34);
            this.button17.TabIndex = 18;
            this.button17.Text = "SP";
            this.button17.UseVisualStyleBackColor = true;
            // 
            // button18
            // 
            this.button18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button18.Location = new System.Drawing.Point(348, 363);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(73, 34);
            this.button18.TabIndex = 18;
            this.button18.Text = "CR";
            this.button18.UseVisualStyleBackColor = true;
            // 
            // button19
            // 
            this.button19.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button19.Location = new System.Drawing.Point(348, 413);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(73, 34);
            this.button19.TabIndex = 18;
            this.button19.Text = "OT";
            this.button19.UseVisualStyleBackColor = false;
            this.button19.Click += new System.EventHandler(this.button10_Click);
            // 
            // button20
            // 
            this.button20.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.button20.Location = new System.Drawing.Point(499, 150);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(71, 64);
            this.button20.TabIndex = 18;
            this.button20.Text = "NA";
            this.button20.UseVisualStyleBackColor = true;
            // 
            // button21
            // 
            this.button21.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.button21.Location = new System.Drawing.Point(499, 230);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(71, 64);
            this.button21.TabIndex = 18;
            this.button21.Text = "VW";
            this.button21.UseVisualStyleBackColor = true;
            this.button21.Click += new System.EventHandler(this.button4_Click);
            // 
            // button22
            // 
            this.button22.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.button22.Location = new System.Drawing.Point(499, 312);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(71, 64);
            this.button22.TabIndex = 18;
            this.button22.Text = "IN";
            this.button22.UseVisualStyleBackColor = true;
            // 
            // button23
            // 
            this.button23.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.button23.Location = new System.Drawing.Point(499, 392);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(71, 64);
            this.button23.TabIndex = 18;
            this.button23.Text = "CI";
            this.button23.UseVisualStyleBackColor = true;
            // 
            // button24
            // 
            this.button24.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button24.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.button24.Location = new System.Drawing.Point(499, 471);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(71, 64);
            this.button24.TabIndex = 18;
            this.button24.Text = "AR";
            this.button24.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Gainsboro;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.button3.Location = new System.Drawing.Point(83, 150);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(71, 64);
            this.button3.TabIndex = 18;
            this.button3.Text = "A/PI";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.button4.Location = new System.Drawing.Point(83, 230);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(71, 64);
            this.button4.TabIndex = 18;
            this.button4.Text = "B";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.button5.Location = new System.Drawing.Point(83, 312);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(71, 64);
            this.button5.TabIndex = 18;
            this.button5.Text = "NA";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.button6.Location = new System.Drawing.Point(83, 392);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(71, 64);
            this.button6.TabIndex = 18;
            this.button6.Text = "O/U";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.button7.Location = new System.Drawing.Point(83, 471);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(71, 64);
            this.button7.TabIndex = 18;
            this.button7.Text = "W";
            this.button7.UseVisualStyleBackColor = true;
=======
            // hispanicButtonYes
            // 
            this.hispanicButtonYes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.hispanicButtonYes.Location = new System.Drawing.Point(212, 352);
            this.hispanicButtonYes.Name = "hispanicButtonYes";
            this.hispanicButtonYes.Size = new System.Drawing.Size(73, 34);
            this.hispanicButtonYes.TabIndex = 18;
            this.hispanicButtonYes.Text = "Y";
            this.hispanicButtonYes.UseVisualStyleBackColor = true;
            this.hispanicButtonYes.Click += new System.EventHandler(this.button11_Click);
            // 
            // hispanicButtonNo
            // 
            this.hispanicButtonNo.BackColor = System.Drawing.SystemColors.Highlight;
            this.hispanicButtonNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.hispanicButtonNo.Location = new System.Drawing.Point(212, 403);
            this.hispanicButtonNo.Name = "hispanicButtonNo";
            this.hispanicButtonNo.Size = new System.Drawing.Size(73, 34);
            this.hispanicButtonNo.TabIndex = 18;
            this.hispanicButtonNo.Text = "N";
            this.hispanicButtonNo.UseVisualStyleBackColor = false;
            this.hispanicButtonNo.Click += new System.EventHandler(this.button12_Click);
            // 
            // hispanicButtonUnidentified
            // 
            this.hispanicButtonUnidentified.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.hispanicButtonUnidentified.Location = new System.Drawing.Point(212, 453);
            this.hispanicButtonUnidentified.Name = "hispanicButtonUnidentified";
            this.hispanicButtonUnidentified.Size = new System.Drawing.Size(73, 34);
            this.hispanicButtonUnidentified.TabIndex = 18;
            this.hispanicButtonUnidentified.Text = "U";
            this.hispanicButtonUnidentified.UseVisualStyleBackColor = true;
            this.hispanicButtonUnidentified.Click += new System.EventHandler(this.button10_Click);
            // 
            // reasonButtonSocial
            // 
            this.reasonButtonSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.reasonButtonSocial.Location = new System.Drawing.Point(348, 159);
            this.reasonButtonSocial.Name = "reasonButtonSocial";
            this.reasonButtonSocial.Size = new System.Drawing.Size(73, 34);
            this.reasonButtonSocial.TabIndex = 18;
            this.reasonButtonSocial.Text = "SO";
            this.reasonButtonSocial.UseVisualStyleBackColor = true;
            // 
            // reasonButtonTerry
            // 
            this.reasonButtonTerry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.reasonButtonTerry.Location = new System.Drawing.Point(348, 210);
            this.reasonButtonTerry.Name = "reasonButtonTerry";
            this.reasonButtonTerry.Size = new System.Drawing.Size(73, 34);
            this.reasonButtonTerry.TabIndex = 18;
            this.reasonButtonTerry.Text = "TE";
            this.reasonButtonTerry.UseVisualStyleBackColor = true;
            // 
            // reasonButtonVehicleEquipment
            // 
            this.reasonButtonVehicleEquipment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.reasonButtonVehicleEquipment.Location = new System.Drawing.Point(348, 260);
            this.reasonButtonVehicleEquipment.Name = "reasonButtonVehicleEquipment";
            this.reasonButtonVehicleEquipment.Size = new System.Drawing.Size(73, 34);
            this.reasonButtonVehicleEquipment.TabIndex = 18;
            this.reasonButtonVehicleEquipment.Text = "EQ";
            this.reasonButtonVehicleEquipment.UseVisualStyleBackColor = true;
            this.reasonButtonVehicleEquipment.Click += new System.EventHandler(this.button10_Click);
            // 
            // reasonButtonSpeed
            // 
            this.reasonButtonSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.reasonButtonSpeed.Location = new System.Drawing.Point(348, 312);
            this.reasonButtonSpeed.Name = "reasonButtonSpeed";
            this.reasonButtonSpeed.Size = new System.Drawing.Size(73, 34);
            this.reasonButtonSpeed.TabIndex = 18;
            this.reasonButtonSpeed.Text = "SP";
            this.reasonButtonSpeed.UseVisualStyleBackColor = true;
            // 
            // reasonButtonDUI
            // 
            this.reasonButtonDUI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.reasonButtonDUI.Location = new System.Drawing.Point(348, 363);
            this.reasonButtonDUI.Name = "reasonButtonDUI";
            this.reasonButtonDUI.Size = new System.Drawing.Size(73, 34);
            this.reasonButtonDUI.TabIndex = 18;
            this.reasonButtonDUI.Text = "CR";
            this.reasonButtonDUI.UseVisualStyleBackColor = true;
            // 
            // reasonButtonOther
            // 
            this.reasonButtonOther.BackColor = System.Drawing.SystemColors.Highlight;
            this.reasonButtonOther.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.reasonButtonOther.Location = new System.Drawing.Point(348, 413);
            this.reasonButtonOther.Name = "reasonButtonOther";
            this.reasonButtonOther.Size = new System.Drawing.Size(73, 34);
            this.reasonButtonOther.TabIndex = 18;
            this.reasonButtonOther.Text = "OT";
            this.reasonButtonOther.UseVisualStyleBackColor = false;
            this.reasonButtonOther.Click += new System.EventHandler(this.button10_Click);
            // 
            // dispositionButtonNoAction
            // 
            this.dispositionButtonNoAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.dispositionButtonNoAction.Location = new System.Drawing.Point(499, 150);
            this.dispositionButtonNoAction.Name = "dispositionButtonNoAction";
            this.dispositionButtonNoAction.Size = new System.Drawing.Size(71, 64);
            this.dispositionButtonNoAction.TabIndex = 18;
            this.dispositionButtonNoAction.Text = "NA";
            this.dispositionButtonNoAction.UseVisualStyleBackColor = true;
            // 
            // dispositionButtonVerbalWarning
            // 
            this.dispositionButtonVerbalWarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.dispositionButtonVerbalWarning.Location = new System.Drawing.Point(499, 230);
            this.dispositionButtonVerbalWarning.Name = "dispositionButtonVerbalWarning";
            this.dispositionButtonVerbalWarning.Size = new System.Drawing.Size(71, 64);
            this.dispositionButtonVerbalWarning.TabIndex = 18;
            this.dispositionButtonVerbalWarning.Text = "VW";
            this.dispositionButtonVerbalWarning.UseVisualStyleBackColor = true;
            this.dispositionButtonVerbalWarning.Click += new System.EventHandler(this.button4_Click);
            // 
            // dispositionButtonInfraction
            // 
            this.dispositionButtonInfraction.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.dispositionButtonInfraction.Location = new System.Drawing.Point(499, 312);
            this.dispositionButtonInfraction.Name = "dispositionButtonInfraction";
            this.dispositionButtonInfraction.Size = new System.Drawing.Size(71, 64);
            this.dispositionButtonInfraction.TabIndex = 18;
            this.dispositionButtonInfraction.Text = "IN";
            this.dispositionButtonInfraction.UseVisualStyleBackColor = true;
            // 
            // dispositionButtonCitation
            // 
            this.dispositionButtonCitation.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.dispositionButtonCitation.Location = new System.Drawing.Point(499, 392);
            this.dispositionButtonCitation.Name = "dispositionButtonCitation";
            this.dispositionButtonCitation.Size = new System.Drawing.Size(71, 64);
            this.dispositionButtonCitation.TabIndex = 18;
            this.dispositionButtonCitation.Text = "CI";
            this.dispositionButtonCitation.UseVisualStyleBackColor = true;
            // 
            // dispositionButtonArrest
            // 
            this.dispositionButtonArrest.BackColor = System.Drawing.SystemColors.Highlight;
            this.dispositionButtonArrest.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.dispositionButtonArrest.Location = new System.Drawing.Point(499, 471);
            this.dispositionButtonArrest.Name = "dispositionButtonArrest";
            this.dispositionButtonArrest.Size = new System.Drawing.Size(71, 64);
            this.dispositionButtonArrest.TabIndex = 18;
            this.dispositionButtonArrest.Text = "AR";
            this.dispositionButtonArrest.UseVisualStyleBackColor = false;
            // 
            // raceButtonAsian
            // 
            this.raceButtonAsian.BackColor = System.Drawing.SystemColors.Highlight;
            this.raceButtonAsian.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.raceButtonAsian.Location = new System.Drawing.Point(83, 150);
            this.raceButtonAsian.Name = "raceButtonAsian";
            this.raceButtonAsian.Size = new System.Drawing.Size(71, 64);
            this.raceButtonAsian.TabIndex = 18;
            this.raceButtonAsian.Text = "A/PI";
            this.raceButtonAsian.UseVisualStyleBackColor = false;
            this.raceButtonAsian.Click += new System.EventHandler(this.button3_Click);
            // 
            // raceButtonBlack
            // 
            this.raceButtonBlack.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.raceButtonBlack.Location = new System.Drawing.Point(83, 230);
            this.raceButtonBlack.Name = "raceButtonBlack";
            this.raceButtonBlack.Size = new System.Drawing.Size(71, 64);
            this.raceButtonBlack.TabIndex = 18;
            this.raceButtonBlack.Text = "B";
            this.raceButtonBlack.UseVisualStyleBackColor = true;
            this.raceButtonBlack.Click += new System.EventHandler(this.button4_Click);
            // 
            // raceButtonNativeAmerican
            // 
            this.raceButtonNativeAmerican.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.raceButtonNativeAmerican.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.raceButtonNativeAmerican.Location = new System.Drawing.Point(83, 312);
            this.raceButtonNativeAmerican.Name = "raceButtonNativeAmerican";
            this.raceButtonNativeAmerican.Size = new System.Drawing.Size(71, 64);
            this.raceButtonNativeAmerican.TabIndex = 18;
            this.raceButtonNativeAmerican.Text = "NA";
            this.raceButtonNativeAmerican.UseVisualStyleBackColor = true;
            // 
            // raceButtonOther
            // 
            this.raceButtonOther.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.raceButtonOther.Location = new System.Drawing.Point(83, 392);
            this.raceButtonOther.Name = "raceButtonOther";
            this.raceButtonOther.Size = new System.Drawing.Size(71, 64);
            this.raceButtonOther.TabIndex = 18;
            this.raceButtonOther.Text = "O/U";
            this.raceButtonOther.UseVisualStyleBackColor = true;
            // 
            // raceButtonWhite
            // 
            this.raceButtonWhite.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.raceButtonWhite.Location = new System.Drawing.Point(83, 471);
            this.raceButtonWhite.Name = "raceButtonWhite";
            this.raceButtonWhite.Size = new System.Drawing.Size(71, 64);
            this.raceButtonWhite.TabIndex = 18;
            this.raceButtonWhite.Text = "W";
            this.raceButtonWhite.UseVisualStyleBackColor = true;
>>>>>>> 9fb971686ae1d2d77bbd271a575da65c2b3d8110
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(65, 41);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(65, 20);
            this.textBox6.TabIndex = 5;
            this.textBox6.Text = "Date";
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox6.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox7
            // 
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.Location = new System.Drawing.Point(397, 41);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(65, 20);
            this.textBox7.TabIndex = 5;
            this.textBox7.Text = "Time";
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox7.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 587);
            this.Controls.Add(this.raceButtonWhite);
            this.Controls.Add(this.dispositionButtonArrest);
            this.Controls.Add(this.raceButtonOther);
            this.Controls.Add(this.dispositionButtonCitation);
            this.Controls.Add(this.raceButtonNativeAmerican);
            this.Controls.Add(this.dispositionButtonInfraction);
            this.Controls.Add(this.raceButtonBlack);
            this.Controls.Add(this.dispositionButtonVerbalWarning);
            this.Controls.Add(this.hispanicButtonUnidentified);
            this.Controls.Add(this.reasonButtonOther);
            this.Controls.Add(this.reasonButtonVehicleEquipment);
            this.Controls.Add(this.genderButtonUnidentified);
            this.Controls.Add(this.hispanicButtonNo);
            this.Controls.Add(this.reasonButtonDUI);
            this.Controls.Add(this.reasonButtonTerry);
            this.Controls.Add(this.genderButtonFemale);
            this.Controls.Add(this.hispanicButtonYes);
            this.Controls.Add(this.reasonButtonSpeed);
            this.Controls.Add(this.reasonButtonSocial);
            this.Controls.Add(this.genderButtonMale);
            this.Controls.Add(this.raceButtonAsian);
            this.Controls.Add(this.dispositionButtonNoAction);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(dateTimePicker2);
            this.Controls.Add(dateTimePicker1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button genderButtonMale;
        private System.Windows.Forms.Button genderButtonFemale;
        private System.Windows.Forms.Button genderButtonUnidentified;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button hispanicButtonYes;
        private System.Windows.Forms.Button hispanicButtonNo;
        private System.Windows.Forms.Button hispanicButtonUnidentified;
        private System.Windows.Forms.Button reasonButtonSocial;
        private System.Windows.Forms.Button reasonButtonTerry;
        private System.Windows.Forms.Button reasonButtonVehicleEquipment;
        private System.Windows.Forms.Button reasonButtonSpeed;
        private System.Windows.Forms.Button reasonButtonDUI;
        private System.Windows.Forms.Button reasonButtonOther;
        private System.Windows.Forms.Button dispositionButtonNoAction;
        private System.Windows.Forms.Button dispositionButtonVerbalWarning;
        private System.Windows.Forms.Button dispositionButtonInfraction;
        private System.Windows.Forms.Button dispositionButtonCitation;
        private System.Windows.Forms.Button dispositionButtonArrest;
        private System.Windows.Forms.Button raceButtonAsian;
        private System.Windows.Forms.Button raceButtonBlack;
        private System.Windows.Forms.Button raceButtonNativeAmerican;
        private System.Windows.Forms.Button raceButtonOther;
        private System.Windows.Forms.Button raceButtonWhite;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
    }
}

