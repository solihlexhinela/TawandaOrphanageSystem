namespace TawandaSystem
{
    partial class DonationTypes
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
            this.tcDonationsT = new System.Windows.Forms.TabControl();
            this.tpgDonationsTAdd = new System.Windows.Forms.TabPage();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.gbInsertRecords = new System.Windows.Forms.GroupBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.lblDonationType = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblHeading = new System.Windows.Forms.Label();
            this.tpgDonationTUpdate = new System.Windows.Forms.TabPage();
            this.btnClearUp = new System.Windows.Forms.Button();
            this.btnBackUp = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxDonationT = new System.Windows.Forms.ComboBox();
            this.lblUpdated = new System.Windows.Forms.Label();
            this.lstUpdatedRecord = new System.Windows.Forms.ListBox();
            this.txtDonationTUp = new System.Windows.Forms.TextBox();
            this.lblDonationTUp = new System.Windows.Forms.Label();
            this.lblNameUp = new System.Windows.Forms.Label();
            this.tpgDonationTDelete = new System.Windows.Forms.TabPage();
            this.btnClearDel = new System.Windows.Forms.Button();
            this.btnBackDel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.gbSearchToDel = new System.Windows.Forms.GroupBox();
            this.lblResults = new System.Windows.Forms.Label();
            this.dgvDeleteRecord = new System.Windows.Forms.DataGridView();
            this.txtDonationTDel = new System.Windows.Forms.TextBox();
            this.lblDonationTDel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tpgDonationTDisplay = new System.Windows.Forms.TabPage();
            this.btnFood = new System.Windows.Forms.Button();
            this.btnMonetary = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnOtherTypes = new System.Windows.Forms.Button();
            this.tcDonationsT.SuspendLayout();
            this.tpgDonationsTAdd.SuspendLayout();
            this.gbInsertRecords.SuspendLayout();
            this.tpgDonationTUpdate.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tpgDonationTDelete.SuspendLayout();
            this.gbSearchToDel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeleteRecord)).BeginInit();
            this.tpgDonationTDisplay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcDonationsT
            // 
            this.tcDonationsT.Controls.Add(this.tpgDonationsTAdd);
            this.tcDonationsT.Controls.Add(this.tpgDonationTUpdate);
            this.tcDonationsT.Controls.Add(this.tpgDonationTDelete);
            this.tcDonationsT.Controls.Add(this.tpgDonationTDisplay);
            this.tcDonationsT.Location = new System.Drawing.Point(4, 31);
            this.tcDonationsT.Margin = new System.Windows.Forms.Padding(4);
            this.tcDonationsT.Name = "tcDonationsT";
            this.tcDonationsT.SelectedIndex = 0;
            this.tcDonationsT.Size = new System.Drawing.Size(832, 491);
            this.tcDonationsT.TabIndex = 0;
            // 
            // tpgDonationsTAdd
            // 
            this.tpgDonationsTAdd.Controls.Add(this.btnClear);
            this.tpgDonationsTAdd.Controls.Add(this.btnBack);
            this.tpgDonationsTAdd.Controls.Add(this.btnAdd);
            this.tpgDonationsTAdd.Controls.Add(this.gbInsertRecords);
            this.tpgDonationsTAdd.Controls.Add(this.lblHeading);
            this.tpgDonationsTAdd.Location = new System.Drawing.Point(4, 25);
            this.tpgDonationsTAdd.Margin = new System.Windows.Forms.Padding(4);
            this.tpgDonationsTAdd.Name = "tpgDonationsTAdd";
            this.tpgDonationsTAdd.Padding = new System.Windows.Forms.Padding(4);
            this.tpgDonationsTAdd.Size = new System.Drawing.Size(824, 462);
            this.tpgDonationsTAdd.TabIndex = 0;
            this.tpgDonationsTAdd.Text = "Add Records";
            this.tpgDonationsTAdd.UseVisualStyleBackColor = true;
            this.tpgDonationsTAdd.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.SkyBlue;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnClear.Location = new System.Drawing.Point(461, 410);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(155, 44);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.SkyBlue;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBack.Location = new System.Drawing.Point(624, 410);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(155, 44);
            this.btnBack.TabIndex = 14;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.SkyBlue;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAdd.Location = new System.Drawing.Point(299, 410);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(155, 44);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // gbInsertRecords
            // 
            this.gbInsertRecords.Controls.Add(this.txtName);
            this.gbInsertRecords.Controls.Add(this.txtLName);
            this.gbInsertRecords.Controls.Add(this.lblDonationType);
            this.gbInsertRecords.Controls.Add(this.lblDescription);
            this.gbInsertRecords.Location = new System.Drawing.Point(43, 63);
            this.gbInsertRecords.Margin = new System.Windows.Forms.Padding(4);
            this.gbInsertRecords.Name = "gbInsertRecords";
            this.gbInsertRecords.Padding = new System.Windows.Forms.Padding(4);
            this.gbInsertRecords.Size = new System.Drawing.Size(736, 161);
            this.gbInsertRecords.TabIndex = 6;
            this.gbInsertRecords.TabStop = false;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(201, 66);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(132, 22);
            this.txtName.TabIndex = 8;
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(201, 38);
            this.txtLName.Margin = new System.Windows.Forms.Padding(4);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(132, 22);
            this.txtLName.TabIndex = 7;
            // 
            // lblDonationType
            // 
            this.lblDonationType.AutoSize = true;
            this.lblDonationType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDonationType.Location = new System.Drawing.Point(21, 44);
            this.lblDonationType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDonationType.Name = "lblDonationType";
            this.lblDonationType.Size = new System.Drawing.Size(108, 18);
            this.lblDonationType.TabIndex = 1;
            this.lblDonationType.Text = "Donation Type:";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(21, 73);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(151, 18);
            this.lblDescription.TabIndex = 0;
            this.lblDescription.Text = "Donation Description:";
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(117, 18);
            this.lblHeading.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(419, 25);
            this.lblHeading.TabIndex = 5;
            this.lblHeading.Text = "DONATION TYPES MANAGEMENT";
            // 
            // tpgDonationTUpdate
            // 
            this.tpgDonationTUpdate.Controls.Add(this.btnClearUp);
            this.tpgDonationTUpdate.Controls.Add(this.btnBackUp);
            this.tpgDonationTUpdate.Controls.Add(this.btnUpdate);
            this.tpgDonationTUpdate.Controls.Add(this.label1);
            this.tpgDonationTUpdate.Controls.Add(this.groupBox1);
            this.tpgDonationTUpdate.Location = new System.Drawing.Point(4, 25);
            this.tpgDonationTUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.tpgDonationTUpdate.Name = "tpgDonationTUpdate";
            this.tpgDonationTUpdate.Padding = new System.Windows.Forms.Padding(4);
            this.tpgDonationTUpdate.Size = new System.Drawing.Size(824, 462);
            this.tpgDonationTUpdate.TabIndex = 1;
            this.tpgDonationTUpdate.Text = "Update Records";
            this.tpgDonationTUpdate.UseVisualStyleBackColor = true;
            // 
            // btnClearUp
            // 
            this.btnClearUp.BackColor = System.Drawing.Color.SkyBlue;
            this.btnClearUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearUp.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnClearUp.Location = new System.Drawing.Point(459, 410);
            this.btnClearUp.Margin = new System.Windows.Forms.Padding(4);
            this.btnClearUp.Name = "btnClearUp";
            this.btnClearUp.Size = new System.Drawing.Size(155, 44);
            this.btnClearUp.TabIndex = 16;
            this.btnClearUp.Text = "Clear";
            this.btnClearUp.UseVisualStyleBackColor = false;
            // 
            // btnBackUp
            // 
            this.btnBackUp.BackColor = System.Drawing.Color.SkyBlue;
            this.btnBackUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackUp.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBackUp.Location = new System.Drawing.Point(621, 410);
            this.btnBackUp.Margin = new System.Windows.Forms.Padding(4);
            this.btnBackUp.Name = "btnBackUp";
            this.btnBackUp.Size = new System.Drawing.Size(155, 44);
            this.btnBackUp.TabIndex = 15;
            this.btnBackUp.Text = "Back";
            this.btnBackUp.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.SkyBlue;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUpdate.Location = new System.Drawing.Point(296, 410);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(155, 44);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(116, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(419, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "DONATION TYPES MANAGEMENT";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxDonationT);
            this.groupBox1.Controls.Add(this.lblUpdated);
            this.groupBox1.Controls.Add(this.lstUpdatedRecord);
            this.groupBox1.Controls.Add(this.txtDonationTUp);
            this.groupBox1.Controls.Add(this.lblDonationTUp);
            this.groupBox1.Controls.Add(this.lblNameUp);
            this.groupBox1.Location = new System.Drawing.Point(43, 58);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(733, 331);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // cbxDonationT
            // 
            this.cbxDonationT.FormattingEnabled = true;
            this.cbxDonationT.Location = new System.Drawing.Point(196, 37);
            this.cbxDonationT.Margin = new System.Windows.Forms.Padding(4);
            this.cbxDonationT.Name = "cbxDonationT";
            this.cbxDonationT.Size = new System.Drawing.Size(151, 24);
            this.cbxDonationT.TabIndex = 16;
            // 
            // lblUpdated
            // 
            this.lblUpdated.AutoSize = true;
            this.lblUpdated.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdated.Location = new System.Drawing.Point(361, 37);
            this.lblUpdated.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUpdated.Name = "lblUpdated";
            this.lblUpdated.Size = new System.Drawing.Size(120, 18);
            this.lblUpdated.TabIndex = 15;
            this.lblUpdated.Text = "Updated Record:";
            // 
            // lstUpdatedRecord
            // 
            this.lstUpdatedRecord.FormattingEnabled = true;
            this.lstUpdatedRecord.ItemHeight = 16;
            this.lstUpdatedRecord.Location = new System.Drawing.Point(365, 59);
            this.lstUpdatedRecord.Margin = new System.Windows.Forms.Padding(4);
            this.lstUpdatedRecord.Name = "lstUpdatedRecord";
            this.lstUpdatedRecord.Size = new System.Drawing.Size(343, 260);
            this.lstUpdatedRecord.TabIndex = 14;
            // 
            // txtDonationTUp
            // 
            this.txtDonationTUp.Location = new System.Drawing.Point(196, 70);
            this.txtDonationTUp.Margin = new System.Windows.Forms.Padding(4);
            this.txtDonationTUp.Name = "txtDonationTUp";
            this.txtDonationTUp.Size = new System.Drawing.Size(151, 22);
            this.txtDonationTUp.TabIndex = 8;
            // 
            // lblDonationTUp
            // 
            this.lblDonationTUp.AutoSize = true;
            this.lblDonationTUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDonationTUp.Location = new System.Drawing.Point(21, 44);
            this.lblDonationTUp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDonationTUp.Name = "lblDonationTUp";
            this.lblDonationTUp.Size = new System.Drawing.Size(108, 18);
            this.lblDonationTUp.TabIndex = 1;
            this.lblDonationTUp.Text = "Donation Type:";
            // 
            // lblNameUp
            // 
            this.lblNameUp.AutoSize = true;
            this.lblNameUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameUp.Location = new System.Drawing.Point(21, 73);
            this.lblNameUp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNameUp.Name = "lblNameUp";
            this.lblNameUp.Size = new System.Drawing.Size(151, 18);
            this.lblNameUp.TabIndex = 0;
            this.lblNameUp.Text = "Donation Description:";
            // 
            // tpgDonationTDelete
            // 
            this.tpgDonationTDelete.Controls.Add(this.btnClearDel);
            this.tpgDonationTDelete.Controls.Add(this.btnBackDel);
            this.tpgDonationTDelete.Controls.Add(this.btnDelete);
            this.tpgDonationTDelete.Controls.Add(this.btnSearch);
            this.tpgDonationTDelete.Controls.Add(this.gbSearchToDel);
            this.tpgDonationTDelete.Controls.Add(this.label2);
            this.tpgDonationTDelete.Location = new System.Drawing.Point(4, 25);
            this.tpgDonationTDelete.Margin = new System.Windows.Forms.Padding(4);
            this.tpgDonationTDelete.Name = "tpgDonationTDelete";
            this.tpgDonationTDelete.Size = new System.Drawing.Size(824, 462);
            this.tpgDonationTDelete.TabIndex = 2;
            this.tpgDonationTDelete.Text = "Delete Records";
            this.tpgDonationTDelete.UseVisualStyleBackColor = true;
            this.tpgDonationTDelete.Click += new System.EventHandler(this.tpgDonationTDelete_Click);
            // 
            // btnClearDel
            // 
            this.btnClearDel.BackColor = System.Drawing.Color.SkyBlue;
            this.btnClearDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearDel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnClearDel.Location = new System.Drawing.Point(476, 410);
            this.btnClearDel.Margin = new System.Windows.Forms.Padding(4);
            this.btnClearDel.Name = "btnClearDel";
            this.btnClearDel.Size = new System.Drawing.Size(155, 44);
            this.btnClearDel.TabIndex = 20;
            this.btnClearDel.Text = "Clear";
            this.btnClearDel.UseVisualStyleBackColor = false;
            // 
            // btnBackDel
            // 
            this.btnBackDel.BackColor = System.Drawing.Color.SkyBlue;
            this.btnBackDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackDel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBackDel.Location = new System.Drawing.Point(639, 410);
            this.btnBackDel.Margin = new System.Windows.Forms.Padding(4);
            this.btnBackDel.Name = "btnBackDel";
            this.btnBackDel.Size = new System.Drawing.Size(155, 44);
            this.btnBackDel.TabIndex = 19;
            this.btnBackDel.Text = "Back";
            this.btnBackDel.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.SkyBlue;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDelete.Location = new System.Drawing.Point(313, 410);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(155, 44);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.SkyBlue;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSearch.Location = new System.Drawing.Point(151, 410);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(155, 44);
            this.btnSearch.TabIndex = 17;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // gbSearchToDel
            // 
            this.gbSearchToDel.Controls.Add(this.lblResults);
            this.gbSearchToDel.Controls.Add(this.dgvDeleteRecord);
            this.gbSearchToDel.Controls.Add(this.txtDonationTDel);
            this.gbSearchToDel.Controls.Add(this.lblDonationTDel);
            this.gbSearchToDel.Location = new System.Drawing.Point(44, 48);
            this.gbSearchToDel.Margin = new System.Windows.Forms.Padding(4);
            this.gbSearchToDel.Name = "gbSearchToDel";
            this.gbSearchToDel.Padding = new System.Windows.Forms.Padding(4);
            this.gbSearchToDel.Size = new System.Drawing.Size(749, 345);
            this.gbSearchToDel.TabIndex = 9;
            this.gbSearchToDel.TabStop = false;
            this.gbSearchToDel.Text = "Search for Record:";
            // 
            // lblResults
            // 
            this.lblResults.AutoSize = true;
            this.lblResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResults.Location = new System.Drawing.Point(21, 101);
            this.lblResults.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(113, 18);
            this.lblResults.TabIndex = 10;
            this.lblResults.Text = "Search Results:";
            // 
            // dgvDeleteRecord
            // 
            this.dgvDeleteRecord.AllowUserToOrderColumns = true;
            this.dgvDeleteRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeleteRecord.Location = new System.Drawing.Point(25, 123);
            this.dgvDeleteRecord.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDeleteRecord.Name = "dgvDeleteRecord";
            this.dgvDeleteRecord.RowHeadersWidth = 51;
            this.dgvDeleteRecord.Size = new System.Drawing.Size(701, 199);
            this.dgvDeleteRecord.TabIndex = 9;
            // 
            // txtDonationTDel
            // 
            this.txtDonationTDel.Location = new System.Drawing.Point(147, 32);
            this.txtDonationTDel.Margin = new System.Windows.Forms.Padding(4);
            this.txtDonationTDel.Name = "txtDonationTDel";
            this.txtDonationTDel.Size = new System.Drawing.Size(132, 22);
            this.txtDonationTDel.TabIndex = 7;
            // 
            // lblDonationTDel
            // 
            this.lblDonationTDel.AutoSize = true;
            this.lblDonationTDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDonationTDel.Location = new System.Drawing.Point(21, 38);
            this.lblDonationTDel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDonationTDel.Name = "lblDonationTDel";
            this.lblDonationTDel.Size = new System.Drawing.Size(108, 18);
            this.lblDonationTDel.TabIndex = 1;
            this.lblDonationTDel.Text = "Donation Type:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(116, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(419, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "DONATION TYPES MANAGEMENT";
            // 
            // tpgDonationTDisplay
            // 
            this.tpgDonationTDisplay.Controls.Add(this.btnOtherTypes);
            this.tpgDonationTDisplay.Controls.Add(this.btnFood);
            this.tpgDonationTDisplay.Controls.Add(this.btnMonetary);
            this.tpgDonationTDisplay.Controls.Add(this.dataGridView1);
            this.tpgDonationTDisplay.Controls.Add(this.label3);
            this.tpgDonationTDisplay.Location = new System.Drawing.Point(4, 25);
            this.tpgDonationTDisplay.Name = "tpgDonationTDisplay";
            this.tpgDonationTDisplay.Size = new System.Drawing.Size(824, 462);
            this.tpgDonationTDisplay.TabIndex = 3;
            this.tpgDonationTDisplay.Text = "Display Records";
            this.tpgDonationTDisplay.UseVisualStyleBackColor = true;
            // 
            // btnFood
            // 
            this.btnFood.BackColor = System.Drawing.Color.SkyBlue;
            this.btnFood.Location = new System.Drawing.Point(695, 206);
            this.btnFood.Name = "btnFood";
            this.btnFood.Size = new System.Drawing.Size(121, 46);
            this.btnFood.TabIndex = 9;
            this.btnFood.Text = "Food Donations";
            this.btnFood.UseVisualStyleBackColor = false;
            // 
            // btnMonetary
            // 
            this.btnMonetary.BackColor = System.Drawing.Color.SkyBlue;
            this.btnMonetary.Location = new System.Drawing.Point(695, 114);
            this.btnMonetary.Name = "btnMonetary";
            this.btnMonetary.Size = new System.Drawing.Size(121, 46);
            this.btnMonetary.TabIndex = 8;
            this.btnMonetary.Text = "Monetary Donations";
            this.btnMonetary.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(4, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(673, 411);
            this.dataGridView1.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(167, 20);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(419, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "DONATION TYPES MANAGEMENT";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Right;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(781, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(55, 522);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(38, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // btnOtherTypes
            // 
            this.btnOtherTypes.BackColor = System.Drawing.Color.SkyBlue;
            this.btnOtherTypes.Location = new System.Drawing.Point(695, 292);
            this.btnOtherTypes.Name = "btnOtherTypes";
            this.btnOtherTypes.Size = new System.Drawing.Size(121, 46);
            this.btnOtherTypes.TabIndex = 10;
            this.btnOtherTypes.Text = "Other Donation Types";
            this.btnOtherTypes.UseVisualStyleBackColor = false;
            // 
            // DonationTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(836, 522);
            this.Controls.Add(this.tcDonationsT);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DonationTypes";
            this.Text = "DONATION TYPES";
            this.tcDonationsT.ResumeLayout(false);
            this.tpgDonationsTAdd.ResumeLayout(false);
            this.tpgDonationsTAdd.PerformLayout();
            this.gbInsertRecords.ResumeLayout(false);
            this.gbInsertRecords.PerformLayout();
            this.tpgDonationTUpdate.ResumeLayout(false);
            this.tpgDonationTUpdate.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tpgDonationTDelete.ResumeLayout(false);
            this.tpgDonationTDelete.PerformLayout();
            this.gbSearchToDel.ResumeLayout(false);
            this.gbSearchToDel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeleteRecord)).EndInit();
            this.tpgDonationTDisplay.ResumeLayout(false);
            this.tpgDonationTDisplay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tcDonationsT;
        private System.Windows.Forms.TabPage tpgDonationsTAdd;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.TabPage tpgDonationTUpdate;
        private System.Windows.Forms.GroupBox gbInsertRecords;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.Label lblDonationType;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TabPage tpgDonationTDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbxDonationT;
        private System.Windows.Forms.Label lblUpdated;
        private System.Windows.Forms.ListBox lstUpdatedRecord;
        private System.Windows.Forms.TextBox txtDonationTUp;
        private System.Windows.Forms.Label lblDonationTUp;
        private System.Windows.Forms.Label lblNameUp;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnBackUp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbSearchToDel;
        private System.Windows.Forms.Label lblResults;
        private System.Windows.Forms.DataGridView dgvDeleteRecord;
        private System.Windows.Forms.TextBox txtDonationTDel;
        private System.Windows.Forms.Label lblDonationTDel;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnBackDel;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClearUp;
        private System.Windows.Forms.Button btnClearDel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TabPage tpgDonationTDisplay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnFood;
        private System.Windows.Forms.Button btnMonetary;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnOtherTypes;
    }
}