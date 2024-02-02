namespace MyStoreWinApp
{
    partial class frmUpdate
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
            tbName = new TextBox();
            lbName = new Label();
            tbPass = new TextBox();
            label5 = new Label();
            tbMail = new TextBox();
            label4 = new Label();
            tbId = new TextBox();
            lbID = new Label();
            btnSave = new Button();
            btnReturn = new Button();
            cbCity = new ComboBox();
            cbCountry = new ComboBox();
            lbCity = new Label();
            lbCountry = new Label();
            SuspendLayout();
            // 
            // tbName
            // 
            tbName.Location = new Point(187, 153);
            tbName.Name = "tbName";
            tbName.Size = new Size(201, 27);
            tbName.TabIndex = 9;
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Location = new Point(83, 160);
            lbName.Name = "lbName";
            lbName.Size = new Size(49, 20);
            lbName.TabIndex = 3;
            lbName.Text = "Name";
            // 
            // tbPass
            // 
            tbPass.Location = new Point(534, 153);
            tbPass.Name = "tbPass";
            tbPass.Size = new Size(201, 27);
            tbPass.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(430, 160);
            label5.Name = "label5";
            label5.Size = new Size(70, 20);
            label5.TabIndex = 5;
            label5.Text = "Password";
            // 
            // tbMail
            // 
            tbMail.Location = new Point(534, 92);
            tbMail.Name = "tbMail";
            tbMail.Size = new Size(201, 27);
            tbMail.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(430, 99);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 6;
            label4.Text = "Email";
            // 
            // tbId
            // 
            tbId.Location = new Point(187, 92);
            tbId.Name = "tbId";
            tbId.ReadOnly = true;
            tbId.Size = new Size(201, 27);
            tbId.TabIndex = 13;
            // 
            // lbID
            // 
            lbID.AutoSize = true;
            lbID.Location = new Point(83, 99);
            lbID.Name = "lbID";
            lbID.Size = new Size(24, 20);
            lbID.TabIndex = 7;
            lbID.Text = "ID";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(187, 306);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(115, 81);
            btnSave.TabIndex = 14;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnReturn
            // 
            btnReturn.Location = new Point(477, 306);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(115, 81);
            btnReturn.TabIndex = 14;
            btnReturn.Text = "Return Login";
            btnReturn.UseVisualStyleBackColor = true;
            btnReturn.Click += btnReturn_Click;
            // 
            // cbCity
            // 
            cbCity.FormattingEnabled = true;
            cbCity.Location = new Point(534, 245);
            cbCity.Name = "cbCity";
            cbCity.Size = new Size(201, 28);
            cbCity.TabIndex = 17;
            // 
            // cbCountry
            // 
            cbCountry.FormattingEnabled = true;
            cbCountry.Location = new Point(187, 245);
            cbCountry.Name = "cbCountry";
            cbCountry.Size = new Size(201, 28);
            cbCountry.TabIndex = 18;
            cbCountry.SelectedIndexChanged += cbCountry_SelectedIndexChanged;
            // 
            // lbCity
            // 
            lbCity.AutoSize = true;
            lbCity.Location = new Point(430, 248);
            lbCity.Name = "lbCity";
            lbCity.Size = new Size(34, 20);
            lbCity.TabIndex = 15;
            lbCity.Text = "City";
            // 
            // lbCountry
            // 
            lbCountry.AutoSize = true;
            lbCountry.Location = new Point(83, 248);
            lbCountry.Name = "lbCountry";
            lbCountry.Size = new Size(60, 20);
            lbCountry.TabIndex = 16;
            lbCountry.Text = "Country";
            // 
            // frmUpdate
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(818, 450);
            Controls.Add(cbCity);
            Controls.Add(cbCountry);
            Controls.Add(lbCity);
            Controls.Add(lbCountry);
            Controls.Add(btnReturn);
            Controls.Add(btnSave);
            Controls.Add(tbName);
            Controls.Add(lbName);
            Controls.Add(tbPass);
            Controls.Add(label5);
            Controls.Add(tbMail);
            Controls.Add(label4);
            Controls.Add(tbId);
            Controls.Add(lbID);
            Name = "frmUpdate";
            Text = "frmUpdate";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox tbName;
        private Label lbName;
        private TextBox tbPass;
        private Label label5;
        private TextBox tbMail;
        private Label label4;
        private TextBox tbId;
        private Label lbID;
        private Button btnSave;
        private Button btnReturn;
        private ComboBox cbCity;
        private ComboBox cbCountry;
        private Label lbCity;
        private Label lbCountry;
    }
}