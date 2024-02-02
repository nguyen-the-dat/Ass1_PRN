namespace MyStoreWinApp
{
    partial class frmLogin
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
            lbEmail = new Label();
            tbMail = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            lbRes = new Label();
            lbPass = new Label();
            tbPass = new TextBox();
            btnLogin = new Button();
            lbCLear = new Label();
            SuspendLayout();
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new Point(71, 40);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(53, 20);
            lbEmail.TabIndex = 0;
            lbEmail.Text = "Email: ";
            // 
            // tbMail
            // 
            tbMail.Location = new Point(169, 33);
            tbMail.Name = "tbMail";
            tbMail.PlaceholderText = "admin";
            tbMail.Size = new Size(200, 27);
            tbMail.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(71, 97);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 0;
            label2.Text = "label1";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(169, 90);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(200, 27);
            textBox2.TabIndex = 1;
            // 
            // lbRes
            // 
            lbRes.AutoSize = true;
            lbRes.Location = new Point(59, 154);
            lbRes.Name = "lbRes";
            lbRes.Size = new Size(0, 20);
            lbRes.TabIndex = 4;
            // 
            // lbPass
            // 
            lbPass.AutoSize = true;
            lbPass.Location = new Point(71, 97);
            lbPass.Name = "lbPass";
            lbPass.Size = new Size(77, 20);
            lbPass.TabIndex = 2;
            lbPass.Text = "Password: ";
            // 
            // tbPass
            // 
            tbPass.Location = new Point(169, 90);
            tbPass.Name = "tbPass";
            tbPass.Size = new Size(200, 27);
            tbPass.TabIndex = 3;
            tbPass.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(102, 205);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(230, 59);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // lbCLear
            // 
            lbCLear.AutoSize = true;
            lbCLear.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            lbCLear.ForeColor = SystemColors.HotTrack;
            lbCLear.Location = new Point(309, 154);
            lbCLear.Name = "lbCLear";
            lbCLear.Size = new Size(60, 28);
            lbCLear.TabIndex = 5;
            lbCLear.Text = "Clear";
            lbCLear.Click += lbCLear_Click;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(440, 283);
            Controls.Add(lbCLear);
            Controls.Add(btnLogin);
            Controls.Add(lbRes);
            Controls.Add(tbPass);
            Controls.Add(lbPass);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(tbMail);
            Controls.Add(lbEmail);
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += frmLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbEmail;
        private TextBox tbMail;
        private Label label2;
        private TextBox textBox2;
        private Label lbRes;
        private Label lbPass;
        private TextBox tbPass;
        private Button btnLogin;
        private Label lbCLear;
    }
}
