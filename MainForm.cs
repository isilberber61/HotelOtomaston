using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace PansiyonOtomasyonu
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            labelDate.Text = DateTime.Now.ToLongDateString();
            labelTime.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

       private void button1_Click(object sender, EventArgs e)
        {

            Login fr = new Login();
            fr.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddCostumer fr = new AddCostumer();
            fr.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Rooms fr = new Rooms();
            fr.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CostumerInformation fr = new CostumerInformation();
            fr.Show();
        }

        private void DateTime_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelDate.Text = DateTime.Now.ToLongDateString();
            labelTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void BtnExitApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

     
        private void button4_Click_1(object sender, EventArgs e)
        {
            ReceivedItems fr= new ReceivedItems();
            fr.Show();
        }

        private void BtnIncomeExpensess_Click(object sender, EventArgs e)
        {
            TotalIncomeAndExpenses fr = new TotalIncomeAndExpenses();
            fr.Show();
        }
    }
}
