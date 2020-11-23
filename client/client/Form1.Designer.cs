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
            this.textBoxRace = new System.Windows.Forms.TextBox();
            this.textBoxGender = new System.Windows.Forms.TextBox();
            this.textBoxHispanic = new System.Windows.Forms.TextBox();
            this.textBoxReason = new System.Windows.Forms.TextBox();
            this.textBoxDisposition = new System.Windows.Forms.TextBox();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.genderButtonMale = new System.Windows.Forms.Button();
            this.genderButtonFemale = new System.Windows.Forms.Button();
            this.genderButtonUnidentified = new System.Windows.Forms.Button();
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
            this.outputText = new System.Windows.Forms.TextBox();
            this.uploadButton = new System.Windows.Forms.Button();
            this.uploadText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxRace
            // 
            this.textBoxRace.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRace.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.textBoxRace.Location = new System.Drawing.Point(75, 66);
            this.textBoxRace.Name = "textBoxRace";
            this.textBoxRace.ReadOnly = true;
            this.textBoxRace.Size = new System.Drawing.Size(95, 20);
            this.textBoxRace.TabIndex = 5;
            this.textBoxRace.Text = "Race";
            this.textBoxRace.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxGender
            // 
            this.textBoxGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxGender.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.textBoxGender.Location = new System.Drawing.Point(208, 66);
            this.textBoxGender.Name = "textBoxGender";
            this.textBoxGender.ReadOnly = true;
            this.textBoxGender.Size = new System.Drawing.Size(96, 20);
            this.textBoxGender.TabIndex = 5;
            this.textBoxGender.Text = "Gender";
            this.textBoxGender.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxHispanic
            // 
            this.textBoxHispanic.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxHispanic.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.textBoxHispanic.Location = new System.Drawing.Point(208, 268);
            this.textBoxHispanic.Name = "textBoxHispanic";
            this.textBoxHispanic.ReadOnly = true;
            this.textBoxHispanic.Size = new System.Drawing.Size(96, 20);
            this.textBoxHispanic.TabIndex = 5;
            this.textBoxHispanic.Text = "Hispanic";
            this.textBoxHispanic.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxReason
            // 
            this.textBoxReason.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxReason.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.textBoxReason.Location = new System.Drawing.Point(343, 66);
            this.textBoxReason.Name = "textBoxReason";
            this.textBoxReason.ReadOnly = true;
            this.textBoxReason.Size = new System.Drawing.Size(94, 20);
            this.textBoxReason.TabIndex = 5;
            this.textBoxReason.Text = "Reason";
            this.textBoxReason.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxDisposition
            // 
            this.textBoxDisposition.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDisposition.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.textBoxDisposition.Location = new System.Drawing.Point(477, 66);
            this.textBoxDisposition.Name = "textBoxDisposition";
            this.textBoxDisposition.ReadOnly = true;
            this.textBoxDisposition.Size = new System.Drawing.Size(130, 20);
            this.textBoxDisposition.TabIndex = 5;
            this.textBoxDisposition.Text = "Disposition";
            this.textBoxDisposition.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // outputText
            // 
            this.outputText.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.outputText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.outputText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputText.Location = new System.Drawing.Point(88, 12);
            this.outputText.Name = "outputText";
            this.outputText.ReadOnly = true;
            this.outputText.Size = new System.Drawing.Size(644, 24);
            this.outputText.TabIndex = 20;
            this.outputText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.outputText.Visible = false;
            // 
            // uploadButton
            // 
            this.uploadButton.BackColor = System.Drawing.Color.LightGray;
            this.uploadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uploadButton.Location = new System.Drawing.Point(696, 454);
            this.uploadButton.Name = "uploadButton";
            this.uploadButton.Size = new System.Drawing.Size(113, 75);
            this.uploadButton.TabIndex = 21;
            this.uploadButton.Text = "Upload form(s)";
            this.uploadButton.UseVisualStyleBackColor = false;
            this.uploadButton.Click += new System.EventHandler(this.buttonUpload_Click);
            // 
            // uploadText
            // 
            this.uploadText.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.uploadText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.uploadText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uploadText.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.uploadText.Location = new System.Drawing.Point(658, 426);
            this.uploadText.Name = "uploadText";
            this.uploadText.ReadOnly = true;
            this.uploadText.Size = new System.Drawing.Size(161, 22);
            this.uploadText.TabIndex = 22;
            this.uploadText.Text = "File(s) uploaded";
            this.uploadText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.uploadText.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 587);
            this.Controls.Add(this.uploadText);
            this.Controls.Add(this.uploadButton);
            this.Controls.Add(this.outputText);
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
            this.Controls.Add(this.textBoxRace);
            this.Controls.Add(this.textBoxGender);
            this.Controls.Add(this.textBoxHispanic);
            this.Controls.Add(this.textBoxReason);
            this.Controls.Add(this.textBoxDisposition);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxRace;
        private System.Windows.Forms.TextBox textBoxGender;
        private System.Windows.Forms.TextBox textBoxReason;
        private System.Windows.Forms.TextBox textBoxDisposition;
        private System.Windows.Forms.TextBox textBoxHispanic;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button genderButtonMale;
        private System.Windows.Forms.Button genderButtonFemale;
        private System.Windows.Forms.Button genderButtonUnidentified;
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

        private System.Windows.Forms.TextBox outputText;
        private System.Windows.Forms.Button uploadButton;
        private System.Windows.Forms.TextBox uploadText;
    }
}

