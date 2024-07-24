namespace PansiyonOtomasyonu
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.BtnAddCostumer = new System.Windows.Forms.Button();
            this.BtnRooms = new System.Windows.Forms.Button();
            this.BtnCostumerInfo = new System.Windows.Forms.Button();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.BtnExitApp = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnIncomeExpenses = new System.Windows.Forms.Button();
            this.BtnReceivedItems = new System.Windows.Forms.Button();
            this.BtnUserLogin = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnAddCostumer
            // 
            this.BtnAddCostumer.BackColor = System.Drawing.Color.SkyBlue;
            this.BtnAddCostumer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnAddCostumer.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnAddCostumer.Location = new System.Drawing.Point(3, 85);
            this.BtnAddCostumer.Name = "BtnAddCostumer";
            this.BtnAddCostumer.Size = new System.Drawing.Size(234, 128);
            this.BtnAddCostumer.TabIndex = 1;
            this.BtnAddCostumer.Text = "Add Costumer";
            this.BtnAddCostumer.UseVisualStyleBackColor = false;
            this.BtnAddCostumer.Click += new System.EventHandler(this.button2_Click);
            // 
            // BtnRooms
            // 
            this.BtnRooms.BackColor = System.Drawing.Color.SkyBlue;
            this.BtnRooms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnRooms.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnRooms.Location = new System.Drawing.Point(243, 219);
            this.BtnRooms.Name = "BtnRooms";
            this.BtnRooms.Size = new System.Drawing.Size(242, 123);
            this.BtnRooms.TabIndex = 2;
            this.BtnRooms.Text = "Rooms";
            this.BtnRooms.UseVisualStyleBackColor = false;
            this.BtnRooms.Click += new System.EventHandler(this.button3_Click);
            // 
            // BtnCostumerInfo
            // 
            this.BtnCostumerInfo.BackColor = System.Drawing.Color.SkyBlue;
            this.BtnCostumerInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnCostumerInfo.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnCostumerInfo.Location = new System.Drawing.Point(3, 219);
            this.BtnCostumerInfo.Name = "BtnCostumerInfo";
            this.BtnCostumerInfo.Size = new System.Drawing.Size(234, 123);
            this.BtnCostumerInfo.TabIndex = 3;
            this.BtnCostumerInfo.Text = "Costumer Information";
            this.BtnCostumerInfo.UseVisualStyleBackColor = false;
            this.BtnCostumerInfo.Click += new System.EventHandler(this.button4_Click);
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelDate.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelDate.ForeColor = System.Drawing.Color.White;
            this.labelDate.Location = new System.Drawing.Point(243, 18);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(242, 26);
            this.labelDate.TabIndex = 4;
            this.labelDate.Text = "label1";
            this.labelDate.Click += new System.EventHandler(this.DateTime_Click);
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelTime.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelTime.ForeColor = System.Drawing.Color.White;
            this.labelTime.Location = new System.Drawing.Point(243, 44);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(79, 38);
            this.labelTime.TabIndex = 5;
            this.labelTime.Text = "label2";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // BtnExitApp
            // 
            this.BtnExitApp.BackColor = System.Drawing.Color.SkyBlue;
            this.BtnExitApp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnExitApp.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnExitApp.Location = new System.Drawing.Point(243, 348);
            this.BtnExitApp.Name = "BtnExitApp";
            this.BtnExitApp.Size = new System.Drawing.Size(242, 120);
            this.BtnExitApp.TabIndex = 6;
            this.BtnExitApp.Text = "Exit";
            this.BtnExitApp.UseVisualStyleBackColor = false;
            this.BtnExitApp.Click += new System.EventHandler(this.BtnExitApp_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.23077F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.76923F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 264F));
            this.tableLayoutPanel1.Controls.Add(this.BtnIncomeExpenses, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.BtnReceivedItems, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.labelDate, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelTime, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.BtnRooms, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.BtnExitApp, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.BtnUserLogin, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.BtnAddCostumer, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.BtnCostumerInfo, 0, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(590, 179);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.09734F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.90266F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 134F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 129F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 126F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 123F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(753, 595);
            this.tableLayoutPanel1.TabIndex = 8;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // BtnIncomeExpenses
            // 
            this.BtnIncomeExpenses.BackColor = System.Drawing.Color.SkyBlue;
            this.BtnIncomeExpenses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnIncomeExpenses.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnIncomeExpenses.Location = new System.Drawing.Point(3, 474);
            this.BtnIncomeExpenses.Name = "BtnIncomeExpenses";
            this.BtnIncomeExpenses.Size = new System.Drawing.Size(234, 118);
            this.BtnIncomeExpenses.TabIndex = 9;
            this.BtnIncomeExpenses.Text = "Total Income And Expenses";
            this.BtnIncomeExpenses.UseVisualStyleBackColor = false;
            this.BtnIncomeExpenses.Click += new System.EventHandler(this.BtnIncomeExpensess_Click);
            // 
            // BtnReceivedItems
            // 
            this.BtnReceivedItems.BackColor = System.Drawing.Color.SkyBlue;
            this.BtnReceivedItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnReceivedItems.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnReceivedItems.Location = new System.Drawing.Point(3, 348);
            this.BtnReceivedItems.Name = "BtnReceivedItems";
            this.BtnReceivedItems.Size = new System.Drawing.Size(234, 120);
            this.BtnReceivedItems.TabIndex = 8;
            this.BtnReceivedItems.Text = "Received Items";
            this.BtnReceivedItems.UseVisualStyleBackColor = false;
            this.BtnReceivedItems.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // BtnUserLogin
            // 
            this.BtnUserLogin.BackColor = System.Drawing.Color.SkyBlue;
            this.BtnUserLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnUserLogin.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnUserLogin.Location = new System.Drawing.Point(243, 85);
            this.BtnUserLogin.Name = "BtnUserLogin";
            this.BtnUserLogin.Size = new System.Drawing.Size(242, 128);
            this.BtnUserLogin.TabIndex = 0;
            this.BtnUserLogin.Text = "User Login";
            this.BtnUserLogin.UseVisualStyleBackColor = false;
            this.BtnUserLogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(1270, 701);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Main Page";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnAddCostumer;
        private System.Windows.Forms.Button BtnRooms;
        private System.Windows.Forms.Button BtnCostumerInfo;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button BtnExitApp;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button BtnReceivedItems;
        private System.Windows.Forms.Button BtnIncomeExpenses;
        private System.Windows.Forms.Button BtnUserLogin;
    }
}