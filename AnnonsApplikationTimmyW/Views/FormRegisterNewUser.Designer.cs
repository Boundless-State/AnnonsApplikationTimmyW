namespace AnnonsApplikationTimmyW.Views
{
    partial class FormRegisterNewUser
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
            buttonSaveNewUser = new Button();
            buttonCancel = new Button();
            textBoxNewUsername = new TextBox();
            labelNewUsername = new Label();
            labelNewPassword = new Label();
            textBoxNewPassword = new TextBox();
            labelStreetAddress = new Label();
            textBoxMobilePhone = new TextBox();
            labelFullName = new Label();
            textBoxFullName = new TextBox();
            labelCountry = new Label();
            textBoxCity = new TextBox();
            labelCity = new Label();
            textBoxRegion = new TextBox();
            labelPostalArea = new Label();
            textBoxPostalCode = new TextBox();
            labelPostalCode = new Label();
            textBoxStreetAdress = new TextBox();
            labelPhoneNumber = new Label();
            textBoxCountry = new TextBox();
            labelStatus = new Label();
            SuspendLayout();
            // 
            // buttonSaveNewUser
            // 
            buttonSaveNewUser.Location = new Point(265, 413);
            buttonSaveNewUser.Margin = new Padding(3, 4, 3, 4);
            buttonSaveNewUser.Name = "buttonSaveNewUser";
            buttonSaveNewUser.Size = new Size(141, 31);
            buttonSaveNewUser.TabIndex = 0;
            buttonSaveNewUser.Text = "Skapa ny användare";
            buttonSaveNewUser.UseVisualStyleBackColor = true;
            buttonSaveNewUser.Click += buttonSaveNewUser_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(413, 413);
            buttonCancel.Margin = new Padding(3, 4, 3, 4);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(96, 31);
            buttonCancel.TabIndex = 1;
            buttonCancel.Text = "Stäng";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // textBoxNewUsername
            // 
            textBoxNewUsername.Location = new Point(14, 36);
            textBoxNewUsername.Margin = new Padding(3, 4, 3, 4);
            textBoxNewUsername.Name = "textBoxNewUsername";
            textBoxNewUsername.Size = new Size(243, 27);
            textBoxNewUsername.TabIndex = 2;
            // 
            // labelNewUsername
            // 
            labelNewUsername.AutoSize = true;
            labelNewUsername.Location = new Point(14, 12);
            labelNewUsername.Name = "labelNewUsername";
            labelNewUsername.Size = new Size(144, 20);
            labelNewUsername.TabIndex = 3;
            labelNewUsername.Text = "Nytt Användarnamn:";
            // 
            // labelNewPassword
            // 
            labelNewPassword.AutoSize = true;
            labelNewPassword.Location = new Point(14, 71);
            labelNewPassword.Name = "labelNewPassword";
            labelNewPassword.Size = new Size(105, 20);
            labelNewPassword.TabIndex = 5;
            labelNewPassword.Text = "Nytt Lösenord:";
            // 
            // textBoxNewPassword
            // 
            textBoxNewPassword.Location = new Point(14, 95);
            textBoxNewPassword.Margin = new Padding(3, 4, 3, 4);
            textBoxNewPassword.Name = "textBoxNewPassword";
            textBoxNewPassword.PasswordChar = '*';
            textBoxNewPassword.Size = new Size(243, 27);
            textBoxNewPassword.TabIndex = 4;
            // 
            // labelStreetAddress
            // 
            labelStreetAddress.AutoSize = true;
            labelStreetAddress.Location = new Point(265, 129);
            labelStreetAddress.Name = "labelStreetAddress";
            labelStreetAddress.Size = new Size(85, 20);
            labelStreetAddress.TabIndex = 9;
            labelStreetAddress.Text = "Gatuadress:";
            // 
            // textBoxMobilePhone
            // 
            textBoxMobilePhone.Location = new Point(265, 95);
            textBoxMobilePhone.Margin = new Padding(3, 4, 3, 4);
            textBoxMobilePhone.Name = "textBoxMobilePhone";
            textBoxMobilePhone.Size = new Size(243, 27);
            textBoxMobilePhone.TabIndex = 8;
            // 
            // labelFullName
            // 
            labelFullName.AutoSize = true;
            labelFullName.Location = new Point(265, 12);
            labelFullName.Name = "labelFullName";
            labelFullName.Size = new Size(133, 20);
            labelFullName.TabIndex = 7;
            labelFullName.Text = "För och Efternamn:";
            // 
            // textBoxFullName
            // 
            textBoxFullName.Location = new Point(265, 36);
            textBoxFullName.Margin = new Padding(3, 4, 3, 4);
            textBoxFullName.Name = "textBoxFullName";
            textBoxFullName.Size = new Size(243, 27);
            textBoxFullName.TabIndex = 6;
            // 
            // labelCountry
            // 
            labelCountry.AutoSize = true;
            labelCountry.Location = new Point(265, 305);
            labelCountry.Name = "labelCountry";
            labelCountry.Size = new Size(44, 20);
            labelCountry.TabIndex = 17;
            labelCountry.Text = "Land:";
            // 
            // textBoxCity
            // 
            textBoxCity.Location = new Point(265, 271);
            textBoxCity.Margin = new Padding(3, 4, 3, 4);
            textBoxCity.Name = "textBoxCity";
            textBoxCity.Size = new Size(243, 27);
            textBoxCity.TabIndex = 16;
            // 
            // labelCity
            // 
            labelCity.AutoSize = true;
            labelCity.Location = new Point(265, 247);
            labelCity.Name = "labelCity";
            labelCity.Size = new Size(42, 20);
            labelCity.TabIndex = 15;
            labelCity.Text = "Stad:";
            // 
            // textBoxRegion
            // 
            textBoxRegion.Location = new Point(365, 212);
            textBoxRegion.Margin = new Padding(3, 4, 3, 4);
            textBoxRegion.Name = "textBoxRegion";
            textBoxRegion.Size = new Size(143, 27);
            textBoxRegion.TabIndex = 14;
            // 
            // labelPostalArea
            // 
            labelPostalArea.AutoSize = true;
            labelPostalArea.Location = new Point(365, 188);
            labelPostalArea.Name = "labelPostalArea";
            labelPostalArea.Size = new Size(58, 20);
            labelPostalArea.TabIndex = 13;
            labelPostalArea.Text = "Postort:";
            // 
            // textBoxPostalCode
            // 
            textBoxPostalCode.Location = new Point(265, 212);
            textBoxPostalCode.Margin = new Padding(3, 4, 3, 4);
            textBoxPostalCode.Name = "textBoxPostalCode";
            textBoxPostalCode.Size = new Size(92, 27);
            textBoxPostalCode.TabIndex = 12;
            // 
            // labelPostalCode
            // 
            labelPostalCode.AutoSize = true;
            labelPostalCode.Location = new Point(265, 188);
            labelPostalCode.Name = "labelPostalCode";
            labelPostalCode.Size = new Size(64, 20);
            labelPostalCode.TabIndex = 11;
            labelPostalCode.Text = "Postkod:";
            // 
            // textBoxStreetAdress
            // 
            textBoxStreetAdress.Location = new Point(265, 153);
            textBoxStreetAdress.Margin = new Padding(3, 4, 3, 4);
            textBoxStreetAdress.Name = "textBoxStreetAdress";
            textBoxStreetAdress.Size = new Size(238, 27);
            textBoxStreetAdress.TabIndex = 10;
            // 
            // labelPhoneNumber
            // 
            labelPhoneNumber.AutoSize = true;
            labelPhoneNumber.Location = new Point(265, 71);
            labelPhoneNumber.Name = "labelPhoneNumber";
            labelPhoneNumber.Size = new Size(106, 20);
            labelPhoneNumber.TabIndex = 19;
            labelPhoneNumber.Text = "Mobilnummer:";
            // 
            // textBoxCountry
            // 
            textBoxCountry.Location = new Point(265, 329);
            textBoxCountry.Margin = new Padding(3, 4, 3, 4);
            textBoxCountry.Name = "textBoxCountry";
            textBoxCountry.Size = new Size(243, 27);
            textBoxCountry.TabIndex = 18;
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.Location = new Point(265, 377);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(0, 20);
            labelStatus.TabIndex = 20;
            // 
            // FormRegisterNewUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(518, 457);
            Controls.Add(labelStatus);
            Controls.Add(labelPhoneNumber);
            Controls.Add(textBoxCountry);
            Controls.Add(labelCountry);
            Controls.Add(textBoxCity);
            Controls.Add(labelCity);
            Controls.Add(textBoxRegion);
            Controls.Add(labelPostalArea);
            Controls.Add(textBoxPostalCode);
            Controls.Add(labelPostalCode);
            Controls.Add(textBoxStreetAdress);
            Controls.Add(labelStreetAddress);
            Controls.Add(textBoxMobilePhone);
            Controls.Add(labelFullName);
            Controls.Add(textBoxFullName);
            Controls.Add(labelNewPassword);
            Controls.Add(textBoxNewPassword);
            Controls.Add(labelNewUsername);
            Controls.Add(textBoxNewUsername);
            Controls.Add(buttonCancel);
            Controls.Add(buttonSaveNewUser);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormRegisterNewUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Skapa Konto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonSaveNewUser;
        private Button buttonCancel;
        private TextBox textBoxNewUsername;
        private Label labelNewUsername;
        private Label labelNewPassword;
        private TextBox textBoxNewPassword;
        private Label labelStreetAddress;
        private TextBox textBoxMobilePhone;
        private Label labelFullName;
        private TextBox textBoxFullName;
        private Label labelCountry;
        private TextBox textBoxCity;
        private Label labelCity;
        private TextBox textBoxRegion;
        private Label labelPostalArea;
        private TextBox textBoxPostalCode;
        private Label labelPostalCode;
        private TextBox textBoxStreetAdress;
        private Label labelPhoneNumber;
        private TextBox textBoxCountry;
        private Label labelStatus;
    }
}