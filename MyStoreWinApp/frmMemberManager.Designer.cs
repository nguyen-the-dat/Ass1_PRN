namespace MyStoreWinApp
{
    partial class frmMemberManager
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
            lbID = new Label();
            tbId = new TextBox();
            lbName = new Label();
            tbName = new TextBox();
            lbCity = new Label();
            label4 = new Label();
            tbMail = new TextBox();
            label5 = new Label();
            tbPass = new TextBox();
            lbCountry = new Label();
            btnNew = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            lbSearch = new Label();
            tbSearch = new TextBox();
            cbOrder = new ComboBox();
            dgvList = new DataGridView();
            label1 = new Label();
            btnClear = new Button();
            cbTitle = new ComboBox();
            cbFilter = new ComboBox();
            label2 = new Label();
            btnSearch = new Button();
            cbFilOr = new ComboBox();
            cbCountry = new ComboBox();
            cbCity = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvList).BeginInit();
            SuspendLayout();
            // 
            // lbID
            // 
            lbID.AutoSize = true;
            lbID.Location = new Point(11, 193);
            lbID.Name = "lbID";
            lbID.Size = new Size(24, 20);
            lbID.TabIndex = 0;
            lbID.Text = "ID";
            // 
            // tbId
            // 
            tbId.Location = new Point(115, 186);
            tbId.Name = "tbId";
            tbId.ReadOnly = true;
            tbId.Size = new Size(201, 27);
            tbId.TabIndex = 1;
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Location = new Point(11, 553);
            lbName.Name = "lbName";
            lbName.Size = new Size(49, 20);
            lbName.TabIndex = 0;
            lbName.Text = "Name";
            // 
            // tbName
            // 
            tbName.Location = new Point(115, 546);
            tbName.Name = "tbName";
            tbName.Size = new Size(201, 27);
            tbName.TabIndex = 1;
            // 
            // lbCity
            // 
            lbCity.AutoSize = true;
            lbCity.Location = new Point(11, 317);
            lbCity.Name = "lbCity";
            lbCity.Size = new Size(34, 20);
            lbCity.TabIndex = 0;
            lbCity.Text = "City";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 429);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 0;
            label4.Text = "Email";
            // 
            // tbMail
            // 
            tbMail.Location = new Point(115, 422);
            tbMail.Name = "tbMail";
            tbMail.Size = new Size(201, 27);
            tbMail.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(11, 490);
            label5.Name = "label5";
            label5.Size = new Size(70, 20);
            label5.TabIndex = 0;
            label5.Text = "Password";
            // 
            // tbPass
            // 
            tbPass.Location = new Point(115, 483);
            tbPass.Name = "tbPass";
            tbPass.Size = new Size(201, 27);
            tbPass.TabIndex = 1;
            // 
            // lbCountry
            // 
            lbCountry.AutoSize = true;
            lbCountry.Location = new Point(11, 247);
            lbCountry.Name = "lbCountry";
            lbCountry.Size = new Size(60, 20);
            lbCountry.TabIndex = 0;
            lbCountry.Text = "Country";
            // 
            // btnNew
            // 
            btnNew.Location = new Point(746, 280);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(115, 35);
            btnNew.TabIndex = 2;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(557, 280);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(115, 35);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(366, 280);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(115, 35);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // lbSearch
            // 
            lbSearch.AutoSize = true;
            lbSearch.Location = new Point(524, 4);
            lbSearch.Name = "lbSearch";
            lbSearch.Size = new Size(53, 20);
            lbSearch.TabIndex = 3;
            lbSearch.Text = "Search";
            // 
            // tbSearch
            // 
            tbSearch.Location = new Point(524, 27);
            tbSearch.Name = "tbSearch";
            tbSearch.Size = new Size(305, 27);
            tbSearch.TabIndex = 4;
            // 
            // cbOrder
            // 
            cbOrder.FormattingEnabled = true;
            cbOrder.Items.AddRange(new object[] { "ASC", "DESC" });
            cbOrder.Location = new Point(756, 151);
            cbOrder.Name = "cbOrder";
            cbOrder.Size = new Size(115, 28);
            cbOrder.TabIndex = 6;
            // 
            // dgvList
            // 
            dgvList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvList.Location = new Point(342, 344);
            dgvList.Name = "dgvList";
            dgvList.RowHeadersWidth = 51;
            dgvList.RowTemplate.Height = 29;
            dgvList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvList.Size = new Size(786, 375);
            dgvList.TabIndex = 7;
            dgvList.CellClick += dgvList_CellClick;
            dgvList.CellContentClick += dgvList_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(524, 78);
            label1.Name = "label1";
            label1.Size = new Size(56, 28);
            label1.TabIndex = 8;
            label1.Text = "Filter";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(941, 280);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(115, 35);
            btnClear.TabIndex = 2;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // cbTitle
            // 
            cbTitle.FormattingEnabled = true;
            cbTitle.Location = new Point(756, 82);
            cbTitle.Name = "cbTitle";
            cbTitle.Size = new Size(115, 28);
            cbTitle.TabIndex = 5;
            // 
            // cbFilter
            // 
            cbFilter.FormattingEnabled = true;
            cbFilter.Items.AddRange(new object[] { "Country", "City" });
            cbFilter.Location = new Point(593, 82);
            cbFilter.Name = "cbFilter";
            cbFilter.Size = new Size(115, 28);
            cbFilter.TabIndex = 5;
            cbFilter.SelectedIndexChanged += cbFilter_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Highlight;
            label2.Location = new Point(524, 151);
            label2.Name = "label2";
            label2.Size = new Size(63, 28);
            label2.TabIndex = 8;
            label2.Text = "Order";
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(645, 208);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(115, 30);
            btnSearch.TabIndex = 9;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // cbFilOr
            // 
            cbFilOr.FormattingEnabled = true;
            cbFilOr.Items.AddRange(new object[] { "ID", "Name" });
            cbFilOr.Location = new Point(593, 151);
            cbFilOr.Name = "cbFilOr";
            cbFilOr.Size = new Size(115, 28);
            cbFilOr.TabIndex = 6;
            // 
            // cbCountry
            // 
            cbCountry.FormattingEnabled = true;
            cbCountry.Location = new Point(115, 244);
            cbCountry.Name = "cbCountry";
            cbCountry.Size = new Size(201, 28);
            cbCountry.TabIndex = 10;
            cbCountry.SelectedIndexChanged += cbCountry_SelectedIndexChanged;
            // 
            // cbCity
            // 
            cbCity.FormattingEnabled = true;
            cbCity.Location = new Point(115, 309);
            cbCity.Name = "cbCity";
            cbCity.Size = new Size(201, 28);
            cbCity.TabIndex = 10;
            // 
            // frmMemberManager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1172, 796);
            Controls.Add(cbCity);
            Controls.Add(cbCountry);
            Controls.Add(btnSearch);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvList);
            Controls.Add(cbFilOr);
            Controls.Add(cbOrder);
            Controls.Add(cbTitle);
            Controls.Add(cbFilter);
            Controls.Add(tbSearch);
            Controls.Add(lbSearch);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnClear);
            Controls.Add(btnNew);
            Controls.Add(lbCity);
            Controls.Add(tbName);
            Controls.Add(lbName);
            Controls.Add(lbCountry);
            Controls.Add(tbPass);
            Controls.Add(label5);
            Controls.Add(tbMail);
            Controls.Add(label4);
            Controls.Add(tbId);
            Controls.Add(lbID);
            Name = "frmMemberManager";
            Text = "frmMemberManager";
            Load += frmMemberManager_Load;
            ((System.ComponentModel.ISupportInitialize)dgvList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbID;
        private TextBox tbId;
        private Label lbName;
        private TextBox tbName;
        private Label lbCity;
        private Label label4;
        private TextBox tbMail;
        private Label label5;
        private TextBox tbPass;
        private Label lbCountry;
        private Button btnNew;
        private Button btnUpdate;
        private Button btnDelete;
        private Label lbSearch;
        private TextBox tbSearch;
        private ComboBox cbOrder;
        private DataGridView dgvList;
        private Label label1;
        private Button btnClear;
        private ComboBox cbTitle;
        private ComboBox cbFilter;
        private Label label2;
        private Button btnSearch;
        private ComboBox cbFilOr;
        private ComboBox cbCountry;
        private ComboBox cbCity;
    }
}