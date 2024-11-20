namespace AnnonsApplikationTimmyW
{
    partial class FormUI
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonSearch = new Button();
            textBoxSearch = new TextBox();
            listBoxResult = new ListBox();
            buttonLogin = new Button();
            textBoxUsername = new TextBox();
            textBoxPassword = new TextBox();
            label1 = new Label();
            label2 = new Label();
            labelLoginStatus = new Label();
            comboBoxCategory = new ComboBox();
            linkLabelCreateNewUser = new LinkLabel();
            buttonCancel = new Button();
            labelAdvertsResult = new Label();
            labelDescription = new Label();
            labelStatusSearch = new Label();
            comboBoxSort = new ComboBox();
            labelSort = new Label();
            labelCategory = new Label();
            textBoxPrice = new TextBox();
            labelPrice = new Label();
            richTextBoxAdvertDescription = new RichTextBox();
            textBoxAdvertDateAdded = new TextBox();
            labelDateAdded = new Label();
            textBoxSeller = new TextBox();
            labelUserAdvert = new Label();
            SuspendLayout();
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(603, 452);
            buttonSearch.Margin = new Padding(3, 4, 3, 4);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(97, 31);
            buttonSearch.TabIndex = 0;
            buttonSearch.Text = "Sök";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(145, 451);
            textBoxSearch.Margin = new Padding(3, 4, 3, 4);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(453, 27);
            textBoxSearch.TabIndex = 1;
            // 
            // listBoxResult
            // 
            listBoxResult.FormattingEnabled = true;
            listBoxResult.Location = new Point(145, 35);
            listBoxResult.Margin = new Padding(3, 4, 3, 4);
            listBoxResult.Name = "listBoxResult";
            listBoxResult.Size = new Size(254, 404);
            listBoxResult.TabIndex = 2;
            listBoxResult.SelectedIndexChanged += listBoxResult_SelectedIndexChanged;
            // 
            // buttonLogin
            // 
            buttonLogin.Location = new Point(777, 135);
            buttonLogin.Margin = new Padding(3, 4, 3, 4);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(86, 31);
            buttonLogin.TabIndex = 3;
            buttonLogin.Text = "Logga in...";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // textBoxUsername
            // 
            textBoxUsername.Location = new Point(707, 35);
            textBoxUsername.Margin = new Padding(3, 4, 3, 4);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(155, 27);
            textBoxUsername.TabIndex = 4;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(707, 96);
            textBoxPassword.Margin = new Padding(3, 4, 3, 4);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.Size = new Size(155, 27);
            textBoxPassword.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(705, 11);
            label1.Name = "label1";
            label1.Size = new Size(112, 20);
            label1.TabIndex = 6;
            label1.Text = "Användarnamn:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(705, 72);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 7;
            label2.Text = "Lösenord:";
            // 
            // labelLoginStatus
            // 
            labelLoginStatus.AutoSize = true;
            labelLoginStatus.Location = new Point(707, 204);
            labelLoginStatus.Name = "labelLoginStatus";
            labelLoginStatus.Size = new Size(0, 20);
            labelLoginStatus.TabIndex = 8;
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCategory.FormattingEnabled = true;
            comboBoxCategory.Location = new Point(14, 451);
            comboBoxCategory.Margin = new Padding(3, 4, 3, 4);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(122, 28);
            comboBoxCategory.TabIndex = 15;
            comboBoxCategory.SelectedIndexChanged += comboBoxCategory_SelectedIndexChanged;
            // 
            // linkLabelCreateNewUser
            // 
            linkLabelCreateNewUser.AutoSize = true;
            linkLabelCreateNewUser.Location = new Point(719, 170);
            linkLabelCreateNewUser.Name = "linkLabelCreateNewUser";
            linkLabelCreateNewUser.Size = new Size(146, 20);
            linkLabelCreateNewUser.TabIndex = 17;
            linkLabelCreateNewUser.TabStop = true;
            linkLabelCreateNewUser.Text = "Skapa Ny Användare";
            linkLabelCreateNewUser.LinkClicked += linkLabelCreateNewUser_LinkClicked;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(703, 452);
            buttonCancel.Margin = new Padding(3, 4, 3, 4);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(160, 31);
            buttonCancel.TabIndex = 18;
            buttonCancel.Text = "Stäng";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // labelAdvertsResult
            // 
            labelAdvertsResult.AutoSize = true;
            labelAdvertsResult.Location = new Point(145, 11);
            labelAdvertsResult.Name = "labelAdvertsResult";
            labelAdvertsResult.Size = new Size(151, 20);
            labelAdvertsResult.TabIndex = 20;
            labelAdvertsResult.Text = "Sökresultat Annonser:";
            // 
            // labelDescription
            // 
            labelDescription.AutoSize = true;
            labelDescription.Location = new Point(407, 11);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new Size(183, 20);
            labelDescription.TabIndex = 21;
            labelDescription.Text = "Information om annonsen:";
            // 
            // labelStatusSearch
            // 
            labelStatusSearch.AutoSize = true;
            labelStatusSearch.Location = new Point(146, 427);
            labelStatusSearch.Name = "labelStatusSearch";
            labelStatusSearch.Size = new Size(0, 20);
            labelStatusSearch.TabIndex = 23;
            // 
            // comboBoxSort
            // 
            comboBoxSort.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSort.FormattingEnabled = true;
            comboBoxSort.Location = new Point(16, 35);
            comboBoxSort.Margin = new Padding(3, 4, 3, 4);
            comboBoxSort.Name = "comboBoxSort";
            comboBoxSort.Size = new Size(122, 28);
            comboBoxSort.TabIndex = 24;
            comboBoxSort.SelectedIndexChanged += comboBoxSort_SelectedIndexChanged;
            comboBoxSort.BindingContextChanged += comboBoxSort_SelectedIndexChanged;
            // 
            // labelSort
            // 
            labelSort.AutoSize = true;
            labelSort.Location = new Point(16, 11);
            labelSort.Name = "labelSort";
            labelSort.Size = new Size(135, 20);
            labelSort.TabIndex = 25;
            labelSort.Text = "Sortera sökresultat:";
            // 
            // labelCategory
            // 
            labelCategory.AutoSize = true;
            labelCategory.Location = new Point(14, 427);
            labelCategory.Name = "labelCategory";
            labelCategory.Size = new Size(116, 20);
            labelCategory.TabIndex = 26;
            labelCategory.Text = "Sök På Kategori:";
            // 
            // textBoxPrice
            // 
            textBoxPrice.BackColor = SystemColors.ButtonHighlight;
            textBoxPrice.Location = new Point(506, 409);
            textBoxPrice.Margin = new Padding(3, 4, 3, 4);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.ReadOnly = true;
            textBoxPrice.Size = new Size(92, 27);
            textBoxPrice.TabIndex = 27;
            // 
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.Location = new Point(506, 388);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(35, 20);
            labelPrice.TabIndex = 28;
            labelPrice.Text = "Pris:";
            // 
            // richTextBoxAdvertDescription
            // 
            richTextBoxAdvertDescription.BackColor = SystemColors.ControlLightLight;
            richTextBoxAdvertDescription.Location = new Point(407, 35);
            richTextBoxAdvertDescription.Margin = new Padding(3, 4, 3, 4);
            richTextBoxAdvertDescription.Name = "richTextBoxAdvertDescription";
            richTextBoxAdvertDescription.ReadOnly = true;
            richTextBoxAdvertDescription.Size = new Size(293, 345);
            richTextBoxAdvertDescription.TabIndex = 30;
            richTextBoxAdvertDescription.Text = "";
            // 
            // textBoxAdvertDateAdded
            // 
            textBoxAdvertDateAdded.BackColor = SystemColors.ButtonHighlight;
            textBoxAdvertDateAdded.Location = new Point(407, 409);
            textBoxAdvertDateAdded.Margin = new Padding(3, 4, 3, 4);
            textBoxAdvertDateAdded.Name = "textBoxAdvertDateAdded";
            textBoxAdvertDateAdded.ReadOnly = true;
            textBoxAdvertDateAdded.Size = new Size(92, 27);
            textBoxAdvertDateAdded.TabIndex = 31;
            // 
            // labelDateAdded
            // 
            labelDateAdded.AutoSize = true;
            labelDateAdded.Location = new Point(407, 388);
            labelDateAdded.Name = "labelDateAdded";
            labelDateAdded.Size = new Size(80, 20);
            labelDateAdded.TabIndex = 32;
            labelDateAdded.Text = "Lades upp:";
            // 
            // textBoxSeller
            // 
            textBoxSeller.BackColor = SystemColors.ButtonHighlight;
            textBoxSeller.Location = new Point(606, 409);
            textBoxSeller.Margin = new Padding(3, 4, 3, 4);
            textBoxSeller.Name = "textBoxSeller";
            textBoxSeller.ReadOnly = true;
            textBoxSeller.Size = new Size(92, 27);
            textBoxSeller.TabIndex = 33;
            // 
            // labelUserAdvert
            // 
            labelUserAdvert.AutoSize = true;
            labelUserAdvert.Location = new Point(606, 388);
            labelUserAdvert.Name = "labelUserAdvert";
            labelUserAdvert.Size = new Size(61, 20);
            labelUserAdvert.TabIndex = 34;
            labelUserAdvert.Text = "Säljs av:";
            // 
            // FormUI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(877, 493);
            Controls.Add(labelUserAdvert);
            Controls.Add(textBoxSeller);
            Controls.Add(labelDateAdded);
            Controls.Add(textBoxAdvertDateAdded);
            Controls.Add(richTextBoxAdvertDescription);
            Controls.Add(labelPrice);
            Controls.Add(textBoxPrice);
            Controls.Add(labelCategory);
            Controls.Add(labelSort);
            Controls.Add(comboBoxSort);
            Controls.Add(labelStatusSearch);
            Controls.Add(labelDescription);
            Controls.Add(labelAdvertsResult);
            Controls.Add(buttonCancel);
            Controls.Add(linkLabelCreateNewUser);
            Controls.Add(comboBoxCategory);
            Controls.Add(labelLoginStatus);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxUsername);
            Controls.Add(buttonLogin);
            Controls.Add(listBoxResult);
            Controls.Add(textBoxSearch);
            Controls.Add(buttonSearch);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormUI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "www.kopochsalj.se";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button buttonSearch;
        private TextBox textBoxSearch;
        private ListBox listBoxResult;
        private Button buttonLogin;
        private TextBox textBoxUsername;
        private TextBox textBoxPassword;
        private Label label1;
        private Label label2;
        private Label labelLoginStatus;
        private ComboBox comboBoxCategory;
        private LinkLabel linkLabelCreateNewUser;
        private Button buttonCancel;
        private Label labelAdvertsResult;
        private Label labelDescription;
        private Label labelStatusSearch;
        private ComboBox comboBoxSort;
        private Label labelSort;
        private Label labelCategory;
        private TextBox textBoxPrice;
        private Label labelPrice;
        private RichTextBox richTextBoxAdvertDescription;
        private TextBox textBoxAdvertDateAdded;
        private Label labelDateAdded;
        private TextBox textBoxSeller;
        private Label labelUserAdvert;
    }
}
