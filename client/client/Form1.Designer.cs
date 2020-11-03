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
            this.errorButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.textBox1.Location = new System.Drawing.Point(75, 66);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(95, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "Race";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.BackColor = System.Drawing.Color.LightGray;
            this.buttonSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.buttonSubmit.Location = new System.Drawing.Point(630, 191);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(102, 45);
            this.buttonSubmit.TabIndex = 6;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = false;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.LightGray;
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.buttonClear.Location = new System.Drawing.Point(630, 283);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(102, 45);
            this.buttonClear.TabIndex = 14;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.textBox2.Location = new System.Drawing.Point(208, 66);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(96, 20);
            this.textBox2.TabIndex = 5;
            this.textBox2.Text = "Gender";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.textBox3.Location = new System.Drawing.Point(343, 66);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(94, 20);
            this.textBox3.TabIndex = 5;
            this.textBox3.Text = "Reason";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.textBox4.Location = new System.Drawing.Point(477, 66);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(130, 20);
            this.textBox4.TabIndex = 5;
            this.textBox4.Text = "Disposition";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // genderButtonMale
            // 
            this.genderButtonMale.BackColor = System.Drawing.Color.LightGray;
            this.genderButtonMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.genderButtonMale.Location = new System.Drawing.Point(217, 101);
            this.genderButtonMale.Name = "genderButtonMale";
            this.genderButtonMale.Size = new System.Drawing.Size(73, 34);
            this.genderButtonMale.TabIndex = 18;
            this.genderButtonMale.Text = "M";
            this.genderButtonMale.UseVisualStyleBackColor = false;
            this.genderButtonMale.Click += new System.EventHandler(this.buttonMale_Click);
            // 
            // genderButtonFemale
            // 
            this.genderButtonFemale.BackColor = System.Drawing.Color.LightGray;
            this.genderButtonFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.genderButtonFemale.Location = new System.Drawing.Point(217, 152);
            this.genderButtonFemale.Name = "genderButtonFemale";
            this.genderButtonFemale.Size = new System.Drawing.Size(73, 34);
            this.genderButtonFemale.TabIndex = 18;
            this.genderButtonFemale.Text = "F";
            this.genderButtonFemale.UseVisualStyleBackColor = false;
            this.genderButtonFemale.Click += new System.EventHandler(this.buttonFemale_Click);
            // 
            // genderButtonUnidentified
            // 
            this.genderButtonUnidentified.BackColor = System.Drawing.Color.LightGray;
            this.genderButtonUnidentified.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.genderButtonUnidentified.Location = new System.Drawing.Point(217, 202);
            this.genderButtonUnidentified.Name = "genderButtonUnidentified";
            this.genderButtonUnidentified.Size = new System.Drawing.Size(73, 34);
            this.genderButtonUnidentified.TabIndex = 18;
            this.genderButtonUnidentified.Text = "U";
            this.genderButtonUnidentified.UseVisualStyleBackColor = false;
            this.genderButtonUnidentified.Click += new System.EventHandler(this.buttonUnid_Click);
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.textBox5.Location = new System.Drawing.Point(208, 268);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(96, 20);
            this.textBox5.TabIndex = 5;
            this.textBox5.Text = "Hispanic";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // hispanicButtonYes
            // 
            this.hispanicButtonYes.BackColor = System.Drawing.Color.LightGray;
            this.hispanicButtonYes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.hispanicButtonYes.Location = new System.Drawing.Point(217, 294);
            this.hispanicButtonYes.Name = "hispanicButtonYes";
            this.hispanicButtonYes.Size = new System.Drawing.Size(73, 34);
            this.hispanicButtonYes.TabIndex = 18;
            this.hispanicButtonYes.Text = "Y";
            this.hispanicButtonYes.UseVisualStyleBackColor = false;
            this.hispanicButtonYes.Click += new System.EventHandler(this.buttonHispYes_Click);
            // 
            // hispanicButtonNo
            // 
            this.hispanicButtonNo.BackColor = System.Drawing.Color.LightGray;
            this.hispanicButtonNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.hispanicButtonNo.Location = new System.Drawing.Point(217, 345);
            this.hispanicButtonNo.Name = "hispanicButtonNo";
            this.hispanicButtonNo.Size = new System.Drawing.Size(73, 34);
            this.hispanicButtonNo.TabIndex = 18;
            this.hispanicButtonNo.Text = "N";
            this.hispanicButtonNo.UseVisualStyleBackColor = false;
            this.hispanicButtonNo.Click += new System.EventHandler(this.buttonHispNo_Click);
            // 
            // hispanicButtonUnidentified
            // 
            this.hispanicButtonUnidentified.BackColor = System.Drawing.Color.LightGray;
            this.hispanicButtonUnidentified.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.hispanicButtonUnidentified.Location = new System.Drawing.Point(217, 395);
            this.hispanicButtonUnidentified.Name = "hispanicButtonUnidentified";
            this.hispanicButtonUnidentified.Size = new System.Drawing.Size(73, 34);
            this.hispanicButtonUnidentified.TabIndex = 18;
            this.hispanicButtonUnidentified.Text = "U";
            this.hispanicButtonUnidentified.UseVisualStyleBackColor = false;
            this.hispanicButtonUnidentified.Click += new System.EventHandler(this.buttonHispUnid_Click);
            // 
            // reasonButtonSocial
            // 
            this.reasonButtonSocial.BackColor = System.Drawing.Color.LightGray;
            this.reasonButtonSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.reasonButtonSocial.Location = new System.Drawing.Point(353, 101);
            this.reasonButtonSocial.Name = "reasonButtonSocial";
            this.reasonButtonSocial.Size = new System.Drawing.Size(73, 34);
            this.reasonButtonSocial.TabIndex = 18;
            this.reasonButtonSocial.Text = "SO";
            this.reasonButtonSocial.UseVisualStyleBackColor = false;
            this.reasonButtonSocial.Click += new System.EventHandler(this.buttonReasonSocial_Click);
            // 
            // reasonButtonTerry
            // 
            this.reasonButtonTerry.BackColor = System.Drawing.Color.LightGray;
            this.reasonButtonTerry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.reasonButtonTerry.Location = new System.Drawing.Point(353, 152);
            this.reasonButtonTerry.Name = "reasonButtonTerry";
            this.reasonButtonTerry.Size = new System.Drawing.Size(73, 34);
            this.reasonButtonTerry.TabIndex = 18;
            this.reasonButtonTerry.Text = "TE";
            this.reasonButtonTerry.UseVisualStyleBackColor = false;
            this.reasonButtonTerry.Click += new System.EventHandler(this.buttonReasonTerry_Click);
            // 
            // reasonButtonVehicleEquipment
            // 
            this.reasonButtonVehicleEquipment.BackColor = System.Drawing.Color.LightGray;
            this.reasonButtonVehicleEquipment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.reasonButtonVehicleEquipment.Location = new System.Drawing.Point(353, 202);
            this.reasonButtonVehicleEquipment.Name = "reasonButtonVehicleEquipment";
            this.reasonButtonVehicleEquipment.Size = new System.Drawing.Size(73, 34);
            this.reasonButtonVehicleEquipment.TabIndex = 18;
            this.reasonButtonVehicleEquipment.Text = "EQ";
            this.reasonButtonVehicleEquipment.UseVisualStyleBackColor = false;
            this.reasonButtonVehicleEquipment.Click += new System.EventHandler(this.buttonReasonVehicle_Click);
            // 
            // reasonButtonSpeed
            // 
            this.reasonButtonSpeed.BackColor = System.Drawing.Color.LightGray;
            this.reasonButtonSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.reasonButtonSpeed.Location = new System.Drawing.Point(353, 254);
            this.reasonButtonSpeed.Name = "reasonButtonSpeed";
            this.reasonButtonSpeed.Size = new System.Drawing.Size(73, 34);
            this.reasonButtonSpeed.TabIndex = 18;
            this.reasonButtonSpeed.Text = "SP";
            this.reasonButtonSpeed.UseVisualStyleBackColor = false;
            this.reasonButtonSpeed.Click += new System.EventHandler(this.buttonReasonSpeed_Click);
            // 
            // reasonButtonDUI
            // 
            this.reasonButtonDUI.BackColor = System.Drawing.Color.LightGray;
            this.reasonButtonDUI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.reasonButtonDUI.Location = new System.Drawing.Point(353, 305);
            this.reasonButtonDUI.Name = "reasonButtonDUI";
            this.reasonButtonDUI.Size = new System.Drawing.Size(73, 34);
            this.reasonButtonDUI.TabIndex = 18;
            this.reasonButtonDUI.Text = "CR";
            this.reasonButtonDUI.UseVisualStyleBackColor = false;
            this.reasonButtonDUI.Click += new System.EventHandler(this.buttonReasonDUI_Click);
            // 
            // reasonButtonOther
            // 
            this.reasonButtonOther.BackColor = System.Drawing.Color.LightGray;
            this.reasonButtonOther.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.reasonButtonOther.Location = new System.Drawing.Point(353, 355);
            this.reasonButtonOther.Name = "reasonButtonOther";
            this.reasonButtonOther.Size = new System.Drawing.Size(73, 34);
            this.reasonButtonOther.TabIndex = 18;
            this.reasonButtonOther.Text = "OT";
            this.reasonButtonOther.UseVisualStyleBackColor = false;
            this.reasonButtonOther.Click += new System.EventHandler(this.buttonReasonOther_Click);
            // 
            // dispositionButtonNoAction
            // 
            this.dispositionButtonNoAction.BackColor = System.Drawing.Color.LightGray;
            this.dispositionButtonNoAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.dispositionButtonNoAction.Location = new System.Drawing.Point(504, 92);
            this.dispositionButtonNoAction.Name = "dispositionButtonNoAction";
            this.dispositionButtonNoAction.Size = new System.Drawing.Size(71, 64);
            this.dispositionButtonNoAction.TabIndex = 18;
            this.dispositionButtonNoAction.Text = "NA";
            this.dispositionButtonNoAction.UseVisualStyleBackColor = false;
            this.dispositionButtonNoAction.Click += new System.EventHandler(this.buttonDispNA_Click);
            // 
            // dispositionButtonVerbalWarning
            // 
            this.dispositionButtonVerbalWarning.BackColor = System.Drawing.Color.LightGray;
            this.dispositionButtonVerbalWarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.dispositionButtonVerbalWarning.Location = new System.Drawing.Point(504, 172);
            this.dispositionButtonVerbalWarning.Name = "dispositionButtonVerbalWarning";
            this.dispositionButtonVerbalWarning.Size = new System.Drawing.Size(71, 64);
            this.dispositionButtonVerbalWarning.TabIndex = 18;
            this.dispositionButtonVerbalWarning.Text = "VW";
            this.dispositionButtonVerbalWarning.UseVisualStyleBackColor = false;
            this.dispositionButtonVerbalWarning.Click += new System.EventHandler(this.buttonDispVerbal_Click);
            // 
            // dispositionButtonInfraction
            // 
            this.dispositionButtonInfraction.BackColor = System.Drawing.Color.LightGray;
            this.dispositionButtonInfraction.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.dispositionButtonInfraction.Location = new System.Drawing.Point(504, 254);
            this.dispositionButtonInfraction.Name = "dispositionButtonInfraction";
            this.dispositionButtonInfraction.Size = new System.Drawing.Size(71, 64);
            this.dispositionButtonInfraction.TabIndex = 18;
            this.dispositionButtonInfraction.Text = "IN";
            this.dispositionButtonInfraction.UseVisualStyleBackColor = false;
            this.dispositionButtonInfraction.Click += new System.EventHandler(this.buttonDispInfraction_Click);
            // 
            // dispositionButtonCitation
            // 
            this.dispositionButtonCitation.BackColor = System.Drawing.Color.LightGray;
            this.dispositionButtonCitation.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.dispositionButtonCitation.Location = new System.Drawing.Point(504, 334);
            this.dispositionButtonCitation.Name = "dispositionButtonCitation";
            this.dispositionButtonCitation.Size = new System.Drawing.Size(71, 64);
            this.dispositionButtonCitation.TabIndex = 18;
            this.dispositionButtonCitation.Text = "CI";
            this.dispositionButtonCitation.UseVisualStyleBackColor = false;
            this.dispositionButtonCitation.Click += new System.EventHandler(this.buttonDispCitation_Click);
            // 
            // dispositionButtonArrest
            // 
            this.dispositionButtonArrest.BackColor = System.Drawing.Color.LightGray;
            this.dispositionButtonArrest.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.dispositionButtonArrest.Location = new System.Drawing.Point(504, 413);
            this.dispositionButtonArrest.Name = "dispositionButtonArrest";
            this.dispositionButtonArrest.Size = new System.Drawing.Size(71, 64);
            this.dispositionButtonArrest.TabIndex = 18;
            this.dispositionButtonArrest.Text = "AR";
            this.dispositionButtonArrest.UseVisualStyleBackColor = false;
            this.dispositionButtonArrest.Click += new System.EventHandler(this.buttonDispArrest_Click);
            // 
            // raceButtonAsian
            // 
            this.raceButtonAsian.BackColor = System.Drawing.Color.LightGray;
            this.raceButtonAsian.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.raceButtonAsian.Location = new System.Drawing.Point(88, 92);
            this.raceButtonAsian.Name = "raceButtonAsian";
            this.raceButtonAsian.Size = new System.Drawing.Size(71, 64);
            this.raceButtonAsian.TabIndex = 18;
            this.raceButtonAsian.Text = "A/PI";
            this.raceButtonAsian.UseVisualStyleBackColor = false;
            this.raceButtonAsian.Click += new System.EventHandler(this.buttonRaceAsian_Click);
            // 
            // raceButtonBlack
            // 
            this.raceButtonBlack.BackColor = System.Drawing.Color.LightGray;
            this.raceButtonBlack.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.raceButtonBlack.Location = new System.Drawing.Point(88, 172);
            this.raceButtonBlack.Name = "raceButtonBlack";
            this.raceButtonBlack.Size = new System.Drawing.Size(71, 64);
            this.raceButtonBlack.TabIndex = 18;
            this.raceButtonBlack.Text = "B";
            this.raceButtonBlack.UseVisualStyleBackColor = false;
            this.raceButtonBlack.Click += new System.EventHandler(this.buttonRaceBlack_Click);
            // 
            // raceButtonNativeAmerican
            // 
            this.raceButtonNativeAmerican.BackColor = System.Drawing.Color.LightGray;
            this.raceButtonNativeAmerican.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.raceButtonNativeAmerican.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.raceButtonNativeAmerican.Location = new System.Drawing.Point(88, 254);
            this.raceButtonNativeAmerican.Name = "raceButtonNativeAmerican";
            this.raceButtonNativeAmerican.Size = new System.Drawing.Size(71, 64);
            this.raceButtonNativeAmerican.TabIndex = 18;
            this.raceButtonNativeAmerican.Text = "NA";
            this.raceButtonNativeAmerican.UseVisualStyleBackColor = false;
            this.raceButtonNativeAmerican.Click += new System.EventHandler(this.buttonRaceNativeAmerican_Click);
            // 
            // raceButtonOther
            // 
            this.raceButtonOther.BackColor = System.Drawing.Color.LightGray;
            this.raceButtonOther.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.raceButtonOther.Location = new System.Drawing.Point(88, 334);
            this.raceButtonOther.Name = "raceButtonOther";
            this.raceButtonOther.Size = new System.Drawing.Size(71, 64);
            this.raceButtonOther.TabIndex = 18;
            this.raceButtonOther.Text = "O/U";
            this.raceButtonOther.UseVisualStyleBackColor = false;
            this.raceButtonOther.Click += new System.EventHandler(this.buttonRaceOther_Click);
            // 
            // raceButtonWhite
            // 
            this.raceButtonWhite.BackColor = System.Drawing.Color.LightGray;
            this.raceButtonWhite.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.raceButtonWhite.Location = new System.Drawing.Point(88, 413);
            this.raceButtonWhite.Name = "raceButtonWhite";
            this.raceButtonWhite.Size = new System.Drawing.Size(71, 64);
            this.raceButtonWhite.TabIndex = 18;
            this.raceButtonWhite.Text = "W";
            this.raceButtonWhite.UseVisualStyleBackColor = false;
            this.raceButtonWhite.Click += new System.EventHandler(this.buttonRaceWhite_Click);
            // 
            // errorButton
            // 
            this.errorButton.BackColor = System.Drawing.Color.Red;
            this.errorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorButton.Location = new System.Drawing.Point(630, 100);
            this.errorButton.Name = "errorButton";
            this.errorButton.Size = new System.Drawing.Size(102, 56);
            this.errorButton.TabIndex = 19;
            this.errorButton.Text = "MISSING FIELD(S)";
            this.errorButton.UseVisualStyleBackColor = false;
            this.errorButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 587);
            this.Controls.Add(this.errorButton);
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
            this.Controls.Add(this.textBox1);
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
        private System.Windows.Forms.Button errorButton;
    }
}

