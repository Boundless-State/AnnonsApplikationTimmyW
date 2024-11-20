namespace AnnonsApplikationTimmyW.Views
{
    partial class FormUserPages
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
            comboBoxCategory = new ComboBox();
            buttonCancel = new Button();
            buttonSaveAdvert = new Button();
            textBoxNewTitle = new TextBox();
            labelCategory = new Label();
            labelNewTitle = new Label();
            labelAdvertDescription = new Label();
            textBoxNewCategory = new TextBox();
            labelNewCategory = new Label();
            textBoxPrice = new TextBox();
            labelPrice = new Label();
            labelUserAdverts = new Label();
            listBoxUserAdverts = new ListBox();
            buttonDeleteAdvert = new Button();
            labelStatus = new Label();
            buttonAddCategory = new Button();
            labelNewCategory3 = new Label();
            richTextBoxAdvertDescription = new RichTextBox();
            buttonEditAdvert = new Button();
            buttonSaveEditAdvert = new Button();
            SuspendLayout();
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCategory.FormattingEnabled = true;
            comboBoxCategory.Location = new Point(273, 112);
            comboBoxCategory.Margin = new Padding(3, 4, 3, 4);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(165, 28);
            comboBoxCategory.TabIndex = 24;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(682, 531);
            buttonCancel.Margin = new Padding(3, 4, 3, 4);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(99, 31);
            buttonCancel.TabIndex = 21;
            buttonCancel.Text = "Logga ut";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonSaveAdvert
            // 
            buttonSaveAdvert.Location = new Point(536, 531);
            buttonSaveAdvert.Margin = new Padding(3, 4, 3, 4);
            buttonSaveAdvert.Name = "buttonSaveAdvert";
            buttonSaveAdvert.Size = new Size(139, 31);
            buttonSaveAdvert.TabIndex = 20;
            buttonSaveAdvert.Text = "Spara Ny Annons";
            buttonSaveAdvert.UseVisualStyleBackColor = true;
            buttonSaveAdvert.Click += buttonSaveAdvert_Click;
            // 
            // textBoxNewTitle
            // 
            textBoxNewTitle.Location = new Point(273, 45);
            textBoxNewTitle.Margin = new Padding(3, 4, 3, 4);
            textBoxNewTitle.Name = "textBoxNewTitle";
            textBoxNewTitle.Size = new Size(377, 27);
            textBoxNewTitle.TabIndex = 25;
            // 
            // labelCategory
            // 
            labelCategory.AutoSize = true;
            labelCategory.Location = new Point(273, 88);
            labelCategory.Name = "labelCategory";
            labelCategory.Size = new Size(97, 20);
            labelCategory.TabIndex = 26;
            labelCategory.Text = "Välj Kategori:";
            // 
            // labelNewTitle
            // 
            labelNewTitle.AutoSize = true;
            labelNewTitle.Location = new Point(273, 21);
            labelNewTitle.Name = "labelNewTitle";
            labelNewTitle.Size = new Size(117, 20);
            labelNewTitle.TabIndex = 27;
            labelNewTitle.Text = "Skriv in din Titel:";
            // 
            // labelAdvertDescription
            // 
            labelAdvertDescription.AutoSize = true;
            labelAdvertDescription.Location = new Point(446, 88);
            labelAdvertDescription.Name = "labelAdvertDescription";
            labelAdvertDescription.Size = new Size(87, 20);
            labelAdvertDescription.TabIndex = 28;
            labelAdvertDescription.Text = "Beskrivning:";
            // 
            // textBoxNewCategory
            // 
            textBoxNewCategory.Location = new Point(273, 211);
            textBoxNewCategory.Margin = new Padding(3, 4, 3, 4);
            textBoxNewCategory.Name = "textBoxNewCategory";
            textBoxNewCategory.Size = new Size(165, 27);
            textBoxNewCategory.TabIndex = 29;
            // 
            // labelNewCategory
            // 
            labelNewCategory.AutoSize = true;
            labelNewCategory.Location = new Point(273, 167);
            labelNewCategory.Name = "labelNewCategory";
            labelNewCategory.Size = new Size(176, 20);
            labelNewCategory.TabIndex = 30;
            labelNewCategory.Text = "Eller spara en ny kategori";
            // 
            // textBoxPrice
            // 
            textBoxPrice.Location = new Point(657, 45);
            textBoxPrice.Margin = new Padding(3, 4, 3, 4);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new Size(124, 27);
            textBoxPrice.TabIndex = 1;
            // 
            // labelPrice
            // 
            labelPrice.Location = new Point(657, 21);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(45, 20);
            labelPrice.TabIndex = 0;
            labelPrice.Text = "Pris:";
            // 
            // labelUserAdverts
            // 
            labelUserAdverts.AutoSize = true;
            labelUserAdverts.Location = new Point(21, 21);
            labelUserAdverts.Name = "labelUserAdverts";
            labelUserAdverts.Size = new Size(109, 20);
            labelUserAdverts.TabIndex = 35;
            labelUserAdverts.Text = "Dina Annonser:";
            // 
            // listBoxUserAdverts
            // 
            listBoxUserAdverts.FormattingEnabled = true;
            listBoxUserAdverts.Location = new Point(21, 45);
            listBoxUserAdverts.Margin = new Padding(3, 4, 3, 4);
            listBoxUserAdverts.Name = "listBoxUserAdverts";
            listBoxUserAdverts.Size = new Size(245, 464);
            listBoxUserAdverts.TabIndex = 34;
            listBoxUserAdverts.SelectedIndexChanged += listBoxUserAdverts_SelectedIndexChanged;
            // 
            // buttonDeleteAdvert
            // 
            buttonDeleteAdvert.Location = new Point(193, 531);
            buttonDeleteAdvert.Margin = new Padding(3, 4, 3, 4);
            buttonDeleteAdvert.Name = "buttonDeleteAdvert";
            buttonDeleteAdvert.Size = new Size(166, 31);
            buttonDeleteAdvert.TabIndex = 32;
            buttonDeleteAdvert.Text = "Ta Bort Vald Annons";
            buttonDeleteAdvert.UseVisualStyleBackColor = true;
            buttonDeleteAdvert.Click += buttonDeleteAdvert_Click;
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.Location = new Point(446, 508);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(0, 20);
            labelStatus.TabIndex = 36;
            // 
            // buttonAddCategory
            // 
            buttonAddCategory.Location = new Point(273, 249);
            buttonAddCategory.Margin = new Padding(3, 4, 3, 4);
            buttonAddCategory.Name = "buttonAddCategory";
            buttonAddCategory.Size = new Size(161, 31);
            buttonAddCategory.TabIndex = 37;
            buttonAddCategory.Text = "Spara Ny Kategori";
            buttonAddCategory.UseVisualStyleBackColor = true;
            buttonAddCategory.Click += buttonAddCategory_Click;
            // 
            // labelNewCategory3
            // 
            labelNewCategory3.AutoSize = true;
            labelNewCategory3.Location = new Point(273, 187);
            labelNewCategory3.Name = "labelNewCategory3";
            labelNewCategory3.Size = new Size(162, 20);
            labelNewCategory3.TabIndex = 39;
            labelNewCategory3.Text = "som passar din annons:";
            // 
            // richTextBoxAdvertDescription
            // 
            richTextBoxAdvertDescription.Location = new Point(446, 112);
            richTextBoxAdvertDescription.Margin = new Padding(3, 4, 3, 4);
            richTextBoxAdvertDescription.Name = "richTextBoxAdvertDescription";
            richTextBoxAdvertDescription.Size = new Size(335, 397);
            richTextBoxAdvertDescription.TabIndex = 41;
            richTextBoxAdvertDescription.Text = "";
            // 
            // buttonEditAdvert
            // 
            buttonEditAdvert.Location = new Point(21, 531);
            buttonEditAdvert.Margin = new Padding(3, 4, 3, 4);
            buttonEditAdvert.Name = "buttonEditAdvert";
            buttonEditAdvert.Size = new Size(166, 31);
            buttonEditAdvert.TabIndex = 42;
            buttonEditAdvert.Text = "Redigera Vald Annons";
            buttonEditAdvert.UseVisualStyleBackColor = true;
            buttonEditAdvert.Click += buttonEditAdvert_Click;
            // 
            // buttonSaveEditAdvert
            // 
            buttonSaveEditAdvert.Enabled = false;
            buttonSaveEditAdvert.Location = new Point(363, 531);
            buttonSaveEditAdvert.Margin = new Padding(3, 4, 3, 4);
            buttonSaveEditAdvert.Name = "buttonSaveEditAdvert";
            buttonSaveEditAdvert.Size = new Size(166, 31);
            buttonSaveEditAdvert.TabIndex = 43;
            buttonSaveEditAdvert.Text = "Spara Redigerad Annons";
            buttonSaveEditAdvert.UseVisualStyleBackColor = true;
            buttonSaveEditAdvert.Click += buttonSaveEditAdvert_Click;
            // 
            // FormUserPages
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(810, 577);
            Controls.Add(buttonSaveEditAdvert);
            Controls.Add(buttonEditAdvert);
            Controls.Add(richTextBoxAdvertDescription);
            Controls.Add(labelNewCategory3);
            Controls.Add(buttonAddCategory);
            Controls.Add(labelStatus);
            Controls.Add(labelUserAdverts);
            Controls.Add(listBoxUserAdverts);
            Controls.Add(buttonDeleteAdvert);
            Controls.Add(labelPrice);
            Controls.Add(textBoxPrice);
            Controls.Add(labelNewCategory);
            Controls.Add(textBoxNewCategory);
            Controls.Add(labelAdvertDescription);
            Controls.Add(labelNewTitle);
            Controls.Add(labelCategory);
            Controls.Add(textBoxNewTitle);
            Controls.Add(comboBoxCategory);
            Controls.Add(buttonCancel);
            Controls.Add(buttonSaveAdvert);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormUserPages";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Skapa/Redigera Annons";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxCategory;
        private Button buttonCancel;
        private Button buttonSaveAdvert;
        private TextBox textBoxNewTitle;
        private Label labelCategory;
        private Label labelNewTitle;
        private Label labelAdvertDescription;
        private TextBox textBoxNewCategory;
        private Label labelNewCategory;
        private TextBox textBoxPrice;
        private Label labelPrice;
        private Label labelUserAdverts;
        private ListBox listBoxUserAdverts;
        private Button buttonDeleteAdvert;
        private Label labelStatus;
        private Button buttonAddCategory;
        private Label labelNewCategory3;
        private RichTextBox richTextBoxAdvertDescription;
        private Button buttonEditAdvert;
        private Button buttonSaveEditAdvert;
    }
}