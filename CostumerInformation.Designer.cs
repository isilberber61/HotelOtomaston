namespace PansiyonOtomasyonu
{
    partial class CostumerInformation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CostumerInformation));
            this.listViewInfo = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BtnList = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.ComboBoxGender = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtCost = new System.Windows.Forms.TextBox();
            this.DtpExit = new System.Windows.Forms.DateTimePicker();
            this.DtpEntry = new System.Windows.Forms.DateTimePicker();
            this.MskTxtPhoneNo = new System.Windows.Forms.MaskedTextBox();
            this.TxtRoomNo = new System.Windows.Forms.TextBox();
            this.TxtSurname = new System.Windows.Forms.TextBox();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.TxtTc = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.BtnClear = new System.Windows.Forms.Button();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listViewInfo
            // 
            this.listViewInfo.BackColor = System.Drawing.Color.LightCyan;
            this.listViewInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10});
            this.listViewInfo.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listViewInfo.HideSelection = false;
            this.listViewInfo.Location = new System.Drawing.Point(12, 475);
            this.listViewInfo.Name = "listViewInfo";
            this.listViewInfo.Size = new System.Drawing.Size(1489, 201);
            this.listViewInfo.TabIndex = 0;
            this.listViewInfo.UseCompatibleStateImageBehavior = false;
            this.listViewInfo.View = System.Windows.Forms.View.Details;
            this.listViewInfo.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.listViewInfo.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Costumer ID";
            this.columnHeader1.Width = 158;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "TC";
            this.columnHeader2.Width = 124;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Name";
            this.columnHeader3.Width = 115;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Surname";
            this.columnHeader4.Width = 126;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Phone Number";
            this.columnHeader5.Width = 194;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Room Number";
            this.columnHeader6.Width = 175;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Cost";
            this.columnHeader7.Width = 77;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Entry Date";
            this.columnHeader8.Width = 168;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Exit Date";
            this.columnHeader9.Width = 160;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Gender";
            this.columnHeader10.Width = 463;
            // 
            // BtnList
            // 
            this.BtnList.BackColor = System.Drawing.Color.SkyBlue;
            this.BtnList.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnList.Location = new System.Drawing.Point(1196, 38);
            this.BtnList.Name = "BtnList";
            this.BtnList.Size = new System.Drawing.Size(259, 49);
            this.BtnList.TabIndex = 1;
            this.BtnList.Text = "Show List";
            this.BtnList.UseVisualStyleBackColor = false;
            this.BtnList.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.BackColor = System.Drawing.Color.SkyBlue;
            this.BtnUpdate.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnUpdate.Location = new System.Drawing.Point(1194, 257);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(259, 47);
            this.BtnUpdate.TabIndex = 2;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.UseVisualStyleBackColor = false;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.BackColor = System.Drawing.Color.SkyBlue;
            this.BtnDelete.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnDelete.Location = new System.Drawing.Point(1194, 184);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(259, 47);
            this.BtnDelete.TabIndex = 3;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = false;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnSearch
            // 
            this.BtnSearch.BackColor = System.Drawing.Color.SkyBlue;
            this.BtnSearch.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSearch.Location = new System.Drawing.Point(1194, 350);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(259, 44);
            this.BtnSearch.TabIndex = 4;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.UseVisualStyleBackColor = false;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // ComboBoxGender
            // 
            this.ComboBoxGender.BackColor = System.Drawing.Color.PapayaWhip;
            this.ComboBoxGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxGender.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ComboBoxGender.FormattingEnabled = true;
            this.ComboBoxGender.Items.AddRange(new object[] {
            "Female",
            "Male"});
            this.ComboBoxGender.Location = new System.Drawing.Point(253, 413);
            this.ComboBoxGender.Name = "ComboBoxGender";
            this.ComboBoxGender.Size = new System.Drawing.Size(121, 34);
            this.ComboBoxGender.TabIndex = 53;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(48, 413);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 26);
            this.label9.TabIndex = 52;
            this.label9.Text = "Gender:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(47, 278);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 26);
            this.label8.TabIndex = 51;
            this.label8.Text = "Cost:";
            // 
            // TxtCost
            // 
            this.TxtCost.BackColor = System.Drawing.Color.White;
            this.TxtCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtCost.Location = new System.Drawing.Point(253, 278);
            this.TxtCost.Name = "TxtCost";
            this.TxtCost.Size = new System.Drawing.Size(184, 30);
            this.TxtCost.TabIndex = 50;
            // 
            // DtpExit
            // 
            this.DtpExit.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DtpExit.Location = new System.Drawing.Point(253, 368);
            this.DtpExit.Name = "DtpExit";
            this.DtpExit.Size = new System.Drawing.Size(379, 29);
            this.DtpExit.TabIndex = 49;
            // 
            // DtpEntry
            // 
            this.DtpEntry.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DtpEntry.Location = new System.Drawing.Point(253, 328);
            this.DtpEntry.Name = "DtpEntry";
            this.DtpEntry.Size = new System.Drawing.Size(379, 29);
            this.DtpEntry.TabIndex = 48;
            // 
            // MskTxtPhoneNo
            // 
            this.MskTxtPhoneNo.BackColor = System.Drawing.Color.White;
            this.MskTxtPhoneNo.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MskTxtPhoneNo.Location = new System.Drawing.Point(253, 181);
            this.MskTxtPhoneNo.Mask = "(999) 000-0000";
            this.MskTxtPhoneNo.Name = "MskTxtPhoneNo";
            this.MskTxtPhoneNo.Size = new System.Drawing.Size(192, 32);
            this.MskTxtPhoneNo.TabIndex = 47;
            // 
            // TxtRoomNo
            // 
            this.TxtRoomNo.BackColor = System.Drawing.Color.White;
            this.TxtRoomNo.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtRoomNo.Location = new System.Drawing.Point(253, 231);
            this.TxtRoomNo.Name = "TxtRoomNo";
            this.TxtRoomNo.Size = new System.Drawing.Size(379, 32);
            this.TxtRoomNo.TabIndex = 46;
            // 
            // TxtSurname
            // 
            this.TxtSurname.BackColor = System.Drawing.Color.White;
            this.TxtSurname.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtSurname.Location = new System.Drawing.Point(253, 136);
            this.TxtSurname.Name = "TxtSurname";
            this.TxtSurname.Size = new System.Drawing.Size(379, 32);
            this.TxtSurname.TabIndex = 45;
            // 
            // TxtName
            // 
            this.TxtName.BackColor = System.Drawing.Color.White;
            this.TxtName.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtName.Location = new System.Drawing.Point(253, 88);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(379, 32);
            this.TxtName.TabIndex = 44;
            // 
            // TxtTc
            // 
            this.TxtTc.BackColor = System.Drawing.Color.White;
            this.TxtTc.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtTc.Location = new System.Drawing.Point(253, 38);
            this.TxtTc.MaxLength = 11;
            this.TxtTc.Name = "TxtTc";
            this.TxtTc.Size = new System.Drawing.Size(379, 32);
            this.TxtTc.TabIndex = 43;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(47, 368);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 26);
            this.label7.TabIndex = 42;
            this.label7.Text = "Exit Date:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(47, 324);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 26);
            this.label6.TabIndex = 41;
            this.label6.Text = "Entry Date:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(47, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 26);
            this.label5.TabIndex = 40;
            this.label5.Text = "Room Number:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(47, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 26);
            this.label4.TabIndex = 39;
            this.label4.Text = "T.C. Number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(47, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 26);
            this.label3.TabIndex = 38;
            this.label3.Text = "Phone Number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(47, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 26);
            this.label2.TabIndex = 37;
            this.label2.Text = "Surname:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(48, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 26);
            this.label1.TabIndex = 36;
            this.label1.Text = "Name:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(835, 362);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 26);
            this.label10.TabIndex = 55;
            this.label10.Text = "Name:";
            // 
            // BtnClear
            // 
            this.BtnClear.BackColor = System.Drawing.Color.SkyBlue;
            this.BtnClear.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnClear.Location = new System.Drawing.Point(1194, 115);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(259, 47);
            this.BtnClear.TabIndex = 56;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = false;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // TxtSearch
            // 
            this.TxtSearch.BackColor = System.Drawing.Color.White;
            this.TxtSearch.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtSearch.Location = new System.Drawing.Point(915, 356);
            this.TxtSearch.MaxLength = 11;
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(257, 32);
            this.TxtSearch.TabIndex = 57;
            this.TxtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
            // 
            // CostumerInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(1513, 703);
            this.Controls.Add(this.TxtSearch);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.ComboBoxGender);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TxtCost);
            this.Controls.Add(this.DtpExit);
            this.Controls.Add(this.DtpEntry);
            this.Controls.Add(this.MskTxtPhoneNo);
            this.Controls.Add(this.TxtRoomNo);
            this.Controls.Add(this.TxtSurname);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.TxtTc);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.BtnList);
            this.Controls.Add(this.listViewInfo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CostumerInformation";
            this.Text = "Costumer Information";
            this.Load += new System.EventHandler(this.ListCostumer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewInfo;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.Button BtnList;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.ComboBox ComboBoxGender;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtCost;
        private System.Windows.Forms.DateTimePicker DtpExit;
        private System.Windows.Forms.DateTimePicker DtpEntry;
        private System.Windows.Forms.MaskedTextBox MskTxtPhoneNo;
        private System.Windows.Forms.TextBox TxtRoomNo;
        private System.Windows.Forms.TextBox TxtSurname;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.TextBox TxtTc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.TextBox TxtSearch;
    }
}