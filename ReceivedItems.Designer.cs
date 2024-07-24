namespace PansiyonOtomasyonu
{
    partial class ReceivedItems
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReceivedItems));
            this.pansiyonDataSet = new PansiyonOtomasyonu.PansiyonDataSet();
            this.receivedItemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.receivedItemsTableAdapter = new PansiyonOtomasyonu.PansiyonDataSetTableAdapters.ReceivedItemsTableAdapter();
            this.BtnSave1 = new System.Windows.Forms.Button();
            this.TxtInternet = new System.Windows.Forms.TextBox();
            this.TxtWater = new System.Windows.Forms.TextBox();
            this.TxtElectricity = new System.Windows.Forms.TextBox();
            this.LblInternetBill = new System.Windows.Forms.Label();
            this.LblWaterBill = new System.Windows.Forms.Label();
            this.LblElectricityBill = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BtnSave = new System.Windows.Forms.Button();
            this.TxtRoomNeeds = new System.Windows.Forms.TextBox();
            this.TxtCleanStaff = new System.Windows.Forms.TextBox();
            this.TxtForRestaurant = new System.Windows.Forms.TextBox();
            this.LblRoomNeeds = new System.Windows.Forms.Label();
            this.LblCleanStaff = new System.Windows.Forms.Label();
            this.LblForRestaurant = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pansiyonDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receivedItemsBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pansiyonDataSet
            // 
            this.pansiyonDataSet.DataSetName = "PansiyonDataSet";
            this.pansiyonDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // receivedItemsBindingSource
            // 
            this.receivedItemsBindingSource.DataMember = "ReceivedItems";
            this.receivedItemsBindingSource.DataSource = this.pansiyonDataSet;
            // 
            // receivedItemsTableAdapter
            // 
            this.receivedItemsTableAdapter.ClearBeforeFill = true;
            // 
            // BtnSave1
            // 
            this.BtnSave1.BackColor = System.Drawing.Color.SkyBlue;
            this.BtnSave1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSave1.ForeColor = System.Drawing.Color.Black;
            this.BtnSave1.Location = new System.Drawing.Point(241, 183);
            this.BtnSave1.Name = "BtnSave1";
            this.BtnSave1.Size = new System.Drawing.Size(130, 43);
            this.BtnSave1.TabIndex = 14;
            this.BtnSave1.Text = "Save";
            this.BtnSave1.UseVisualStyleBackColor = false;
            this.BtnSave1.Click += new System.EventHandler(this.BtnSave1_Click);
            // 
            // TxtInternet
            // 
            this.TxtInternet.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtInternet.Location = new System.Drawing.Point(241, 114);
            this.TxtInternet.Name = "TxtInternet";
            this.TxtInternet.Size = new System.Drawing.Size(130, 32);
            this.TxtInternet.TabIndex = 13;
            // 
            // TxtWater
            // 
            this.TxtWater.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtWater.Location = new System.Drawing.Point(241, 74);
            this.TxtWater.Name = "TxtWater";
            this.TxtWater.Size = new System.Drawing.Size(130, 32);
            this.TxtWater.TabIndex = 12;
            // 
            // TxtElectricity
            // 
            this.TxtElectricity.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtElectricity.Location = new System.Drawing.Point(241, 28);
            this.TxtElectricity.Name = "TxtElectricity";
            this.TxtElectricity.Size = new System.Drawing.Size(130, 32);
            this.TxtElectricity.TabIndex = 11;
            // 
            // LblInternetBill
            // 
            this.LblInternetBill.AutoSize = true;
            this.LblInternetBill.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblInternetBill.Location = new System.Drawing.Point(22, 117);
            this.LblInternetBill.Name = "LblInternetBill";
            this.LblInternetBill.Size = new System.Drawing.Size(157, 26);
            this.LblInternetBill.TabIndex = 10;
            this.LblInternetBill.Text = "Internet Bill:";
            this.LblInternetBill.Click += new System.EventHandler(this.label1_Click);
            // 
            // LblWaterBill
            // 
            this.LblWaterBill.AutoSize = true;
            this.LblWaterBill.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblWaterBill.Location = new System.Drawing.Point(22, 74);
            this.LblWaterBill.Name = "LblWaterBill";
            this.LblWaterBill.Size = new System.Drawing.Size(132, 26);
            this.LblWaterBill.TabIndex = 9;
            this.LblWaterBill.Text = "Water Bill:";
            // 
            // LblElectricityBill
            // 
            this.LblElectricityBill.AutoSize = true;
            this.LblElectricityBill.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblElectricityBill.Location = new System.Drawing.Point(22, 31);
            this.LblElectricityBill.Name = "LblElectricityBill";
            this.LblElectricityBill.Size = new System.Drawing.Size(177, 26);
            this.LblElectricityBill.TabIndex = 8;
            this.LblElectricityBill.Text = "Electricity Bill:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listView2);
            this.groupBox1.Controls.Add(this.TxtElectricity);
            this.groupBox1.Controls.Add(this.BtnSave1);
            this.groupBox1.Controls.Add(this.LblElectricityBill);
            this.groupBox1.Controls.Add(this.TxtInternet);
            this.groupBox1.Controls.Add(this.LblWaterBill);
            this.groupBox1.Controls.Add(this.TxtWater);
            this.groupBox1.Controls.Add(this.LblInternetBill);
            this.groupBox1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(1040, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(532, 477);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bills";
            // 
            // listView2
            // 
            this.listView2.BackColor = System.Drawing.Color.LightCyan;
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listView2.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(8, 308);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(518, 156);
            this.listView2.TabIndex = 15;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Electricity";
            this.columnHeader4.Width = 173;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Water";
            this.columnHeader5.Width = 150;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Internet";
            this.columnHeader6.Width = 165;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listView1);
            this.groupBox2.Controls.Add(this.BtnSave);
            this.groupBox2.Controls.Add(this.TxtRoomNeeds);
            this.groupBox2.Controls.Add(this.TxtCleanStaff);
            this.groupBox2.Controls.Add(this.TxtForRestaurant);
            this.groupBox2.Controls.Add(this.LblRoomNeeds);
            this.groupBox2.Controls.Add(this.LblCleanStaff);
            this.groupBox2.Controls.Add(this.LblForRestaurant);
            this.groupBox2.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(68, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(932, 477);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Received Items";
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.LightCyan;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(20, 312);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(597, 156);
            this.listView1.TabIndex = 15;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Restaurant";
            this.columnHeader1.Width = 206;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Clean Metarials";
            this.columnHeader2.Width = 203;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Room Needs";
            this.columnHeader3.Width = 165;
            // 
            // BtnSave
            // 
            this.BtnSave.BackColor = System.Drawing.Color.SkyBlue;
            this.BtnSave.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSave.ForeColor = System.Drawing.Color.Black;
            this.BtnSave.Location = new System.Drawing.Point(689, 183);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(209, 43);
            this.BtnSave.TabIndex = 14;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click_1);
            // 
            // TxtRoomNeeds
            // 
            this.TxtRoomNeeds.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtRoomNeeds.Location = new System.Drawing.Point(689, 114);
            this.TxtRoomNeeds.Name = "TxtRoomNeeds";
            this.TxtRoomNeeds.Size = new System.Drawing.Size(209, 32);
            this.TxtRoomNeeds.TabIndex = 13;
            // 
            // TxtCleanStaff
            // 
            this.TxtCleanStaff.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtCleanStaff.Location = new System.Drawing.Point(689, 71);
            this.TxtCleanStaff.Name = "TxtCleanStaff";
            this.TxtCleanStaff.Size = new System.Drawing.Size(209, 32);
            this.TxtCleanStaff.TabIndex = 12;
            // 
            // TxtForRestaurant
            // 
            this.TxtForRestaurant.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtForRestaurant.Location = new System.Drawing.Point(689, 25);
            this.TxtForRestaurant.Name = "TxtForRestaurant";
            this.TxtForRestaurant.Size = new System.Drawing.Size(209, 32);
            this.TxtForRestaurant.TabIndex = 11;
            // 
            // LblRoomNeeds
            // 
            this.LblRoomNeeds.AutoSize = true;
            this.LblRoomNeeds.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblRoomNeeds.Location = new System.Drawing.Point(6, 117);
            this.LblRoomNeeds.Name = "LblRoomNeeds";
            this.LblRoomNeeds.Size = new System.Drawing.Size(677, 26);
            this.LblRoomNeeds.TabIndex = 10;
            this.LblRoomNeeds.Text = "The amount of purchased materials necessary for the room:";
            // 
            // LblCleanStaff
            // 
            this.LblCleanStaff.AutoSize = true;
            this.LblCleanStaff.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblCleanStaff.Location = new System.Drawing.Point(6, 74);
            this.LblCleanStaff.Name = "LblCleanStaff";
            this.LblCleanStaff.Size = new System.Drawing.Size(550, 26);
            this.LblCleanStaff.TabIndex = 9;
            this.LblCleanStaff.Text = "The amount of purchases for cleaning materials:";
            // 
            // LblForRestaurant
            // 
            this.LblForRestaurant.AutoSize = true;
            this.LblForRestaurant.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblForRestaurant.Location = new System.Drawing.Point(6, 31);
            this.LblForRestaurant.Name = "LblForRestaurant";
            this.LblForRestaurant.Size = new System.Drawing.Size(569, 26);
            this.LblForRestaurant.TabIndex = 8;
            this.LblForRestaurant.Text = "The amount of what was taken for the restaurant:";
            // 
            // ReceivedItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(1770, 556);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReceivedItems";
            this.Text = "ReceivedItems";
            this.Load += new System.EventHandler(this.ReceivedItems_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pansiyonDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receivedItemsBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private PansiyonDataSet pansiyonDataSet;
        private System.Windows.Forms.BindingSource receivedItemsBindingSource;
        private PansiyonDataSetTableAdapters.ReceivedItemsTableAdapter receivedItemsTableAdapter;
        private System.Windows.Forms.Button BtnSave1;
        private System.Windows.Forms.TextBox TxtInternet;
        private System.Windows.Forms.TextBox TxtWater;
        private System.Windows.Forms.TextBox TxtElectricity;
        private System.Windows.Forms.Label LblInternetBill;
        private System.Windows.Forms.Label LblWaterBill;
        private System.Windows.Forms.Label LblElectricityBill;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.TextBox TxtRoomNeeds;
        private System.Windows.Forms.TextBox TxtCleanStaff;
        private System.Windows.Forms.TextBox TxtForRestaurant;
        private System.Windows.Forms.Label LblRoomNeeds;
        private System.Windows.Forms.Label LblCleanStaff;
        private System.Windows.Forms.Label LblForRestaurant;
    }
}