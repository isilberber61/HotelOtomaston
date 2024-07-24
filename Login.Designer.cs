namespace PansiyonOtomasyonu
{
    partial class Login
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.LblUserName = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.TxtPasswordd = new System.Windows.Forms.TextBox();
            this.LblPasswordd = new System.Windows.Forms.Label();
            this.TxtUserName = new System.Windows.Forms.TextBox();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.LblHotelName = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblUserName
            // 
            this.LblUserName.AutoSize = true;
            this.LblUserName.Dock = System.Windows.Forms.DockStyle.Right;
            this.LblUserName.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblUserName.Location = new System.Drawing.Point(123, 0);
            this.LblUserName.Name = "LblUserName";
            this.LblUserName.Size = new System.Drawing.Size(132, 60);
            this.LblUserName.TabIndex = 0;
            this.LblUserName.Text = "Username:";
            this.LblUserName.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.217F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.783F));
            this.tableLayoutPanel1.Controls.Add(this.TxtPasswordd, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.LblUserName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.LblPasswordd, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.TxtUserName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.BtnLogin, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(192, 171);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(525, 205);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // TxtPasswordd
            // 
            this.TxtPasswordd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtPasswordd.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtPasswordd.Location = new System.Drawing.Point(261, 63);
            this.TxtPasswordd.Name = "TxtPasswordd";
            this.TxtPasswordd.Size = new System.Drawing.Size(261, 32);
            this.TxtPasswordd.TabIndex = 3;
            this.TxtPasswordd.UseSystemPasswordChar = true;
            // 
            // LblPasswordd
            // 
            this.LblPasswordd.AutoSize = true;
            this.LblPasswordd.Dock = System.Windows.Forms.DockStyle.Right;
            this.LblPasswordd.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblPasswordd.Location = new System.Drawing.Point(132, 60);
            this.LblPasswordd.Name = "LblPasswordd";
            this.LblPasswordd.Size = new System.Drawing.Size(123, 90);
            this.LblPasswordd.TabIndex = 1;
            this.LblPasswordd.Text = "Password:";
            // 
            // TxtUserName
            // 
            this.TxtUserName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtUserName.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtUserName.Location = new System.Drawing.Point(261, 3);
            this.TxtUserName.Name = "TxtUserName";
            this.TxtUserName.Size = new System.Drawing.Size(261, 32);
            this.TxtUserName.TabIndex = 2;
            // 
            // BtnLogin
            // 
            this.BtnLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnLogin.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnLogin.Location = new System.Drawing.Point(261, 153);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(261, 49);
            this.BtnLogin.TabIndex = 4;
            this.BtnLogin.Text = "Login";
            this.BtnLogin.UseVisualStyleBackColor = true;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click_1);
            // 
            // LblHotelName
            // 
            this.LblHotelName.AutoSize = true;
            this.LblHotelName.BackColor = System.Drawing.Color.Transparent;
            this.LblHotelName.Font = new System.Drawing.Font("MV Boli", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHotelName.Location = new System.Drawing.Point(178, 25);
            this.LblHotelName.Name = "LblHotelName";
            this.LblHotelName.Size = new System.Drawing.Size(565, 79);
            this.LblHotelName.TabIndex = 0;
            this.LblHotelName.Text = "TURKUAZ HOTEL";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1379, 602);
            this.Controls.Add(this.LblHotelName);
            this.Controls.Add(this.tableLayoutPanel1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.Text = "User Login Page";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LblUserName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox TxtPasswordd;
        private System.Windows.Forms.Label LblPasswordd;
        private System.Windows.Forms.TextBox TxtUserName;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.Label LblHotelName;
    }
}

