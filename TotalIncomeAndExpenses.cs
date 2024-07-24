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
    public partial class TotalIncomeAndExpenses : Form
    {
        public TotalIncomeAndExpenses()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-SFV9JSRE;Initial Catalog=Pansiyon;Integrated Security=True");
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            int staff;
            staff = Convert.ToInt32(TxtNumberStaff.Text);
            LblStaffSalaries.Text = (staff * 3000).ToString();

            int result;
            result = Convert.ToInt32(LblTotalAmount.Text) - (Convert.ToInt32(LblStaffSalaries.Text) + Convert.ToInt32(LblAmountOfProductsReceived1.Text) + Convert.ToInt32(LblAmountOfProductsReceived2.Text) + Convert.ToInt32(LblAmountOfProductsReceived3.Text) + Convert.ToInt32(LblElectricity.Text) + Convert.ToInt32(LblWater.Text) + Convert.ToInt32(LblInternet.Text));
            LblResult.Text = result.ToString();
        }

        private void TotalIncomeAndExpenses_Load(object sender, EventArgs e)
        {
            //coins in the safe from the customer
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("Select sum(Cost) as total from AddCostumer ", baglanti);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                LblTotalAmount.Text = reader["total"].ToString();
            }
            baglanti.Close();

            //ForRestaurant
            baglanti.Open();
            SqlCommand cmd1 = new SqlCommand("Select sum(ForRestaurant) as total1 from ReceivedItems ", baglanti);
            SqlDataReader reader1 = cmd1.ExecuteReader();

            while (reader1.Read())
            {
                LblAmountOfProductsReceived1.Text = reader1["total1"].ToString();
            }
            baglanti.Close();

            //ForCleanStaff
            baglanti.Open();
            SqlCommand cmd2 = new SqlCommand("Select sum(ForCleanStaff) as total2 from ReceivedItems ", baglanti);
            SqlDataReader reader2 = cmd2.ExecuteReader();

            while (reader2.Read())
            {
                LblAmountOfProductsReceived2.Text = reader2["total2"].ToString();
            }
            baglanti.Close();

            //ForRoomNeeds
            baglanti.Open();
            SqlCommand cmd3 = new SqlCommand("Select sum(ForRoomNeeds) as total3 from ReceivedItems ", baglanti);
            SqlDataReader reader3 = cmd3.ExecuteReader();

            while (reader3.Read())
            {
                LblAmountOfProductsReceived3.Text = reader3["total3"].ToString();
            }
            baglanti.Close();

            //Electricity
            baglanti.Open();
            SqlCommand cmd4 = new SqlCommand("Select sum(Electricity) as total4 from Bills ", baglanti);
            SqlDataReader reader4 = cmd4.ExecuteReader();

            while (reader4.Read())
            {
                LblElectricity.Text = reader4["total4"].ToString();
            }
            baglanti.Close();

            //Water
            baglanti.Open();
            SqlCommand cmd5 = new SqlCommand("Select sum(Water) as total5 from Bills ", baglanti);
            SqlDataReader reader5 = cmd5.ExecuteReader();

            while (reader5.Read())
            {
                LblWater.Text = reader5["total5"].ToString();
            }
            baglanti.Close();

            //Internet
            baglanti.Open();
            SqlCommand cmd6 = new SqlCommand("Select sum(Internet) as total6 from Bills ", baglanti);
            SqlDataReader reader6 = cmd6.ExecuteReader();

            while (reader6.Read())
            {
                LblInternet.Text = reader6["total6"].ToString();
            }
            baglanti.Close();

        
           
        }

        private void LblStaffSalaries_Click(object sender, EventArgs e)
        {

        }

        private void LblFor_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void NumberStaff_Click(object sender, EventArgs e)
        {

        }

        private void TxtNumberStaff_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnGraphic_Click(object sender, EventArgs e)
        {
            float d1,d2,d3,d4,d5,d6,d7,d8,total;

            d1 = int.Parse(LblTotalAmount.Text);
            d2 = int.Parse(LblStaffSalaries.Text);
            d3 = int.Parse(LblAmountOfProductsReceived1.Text);
            d4 = int.Parse(LblAmountOfProductsReceived2.Text);
            d5 = int.Parse(LblAmountOfProductsReceived3.Text);
            d6 = int.Parse(LblElectricity.Text);
            d7 = int.Parse(LblWater.Text);
            d8 = int.Parse(LblInternet.Text);

            total = d1 + d2 + d3 + d4 + d5 + d6 + d7 + d8;

            float pd1, pd2, pd3, pd4, pd5, pd6, pd7, pd8;
            pd1 = (d1 / total) * 360;
            pd2 = (d2 / total) * 360;
            pd3 = (d3 / total) * 360;
            pd4 = (d4 / total) * 360;
            pd5 = (d5 / total) * 360;
            pd6 = (d6 / total) * 360;
            pd7 = (d7 / total) * 360;
            pd8 = (d8 / total) * 360;

            Pen pen = new Pen(Color.Black,2);

            Graphics g =this.CreateGraphics();

            Rectangle rectangle = new Rectangle(BtnGraphic.Location.X + BtnGraphic.Size.Width + 30, 30,180, 190);

            Brush b1= new SolidBrush(Color.Green);
            Brush b2= new SolidBrush(Color.LightGreen);
            Brush b3= new SolidBrush(Color.Brown);
            Brush b4= new SolidBrush(Color.Purple);
            Brush b5 = new SolidBrush(Color.Crimson);
            Brush b6 = new SolidBrush(Color.Orange);
            Brush b7 = new SolidBrush(Color.MistyRose);
            Brush b8 = new SolidBrush(Color.Khaki);  

            //g.Clear(TotalIncomeAndExpenses.DefaultBackColor);
            g.DrawPie(pen, rectangle, 0, pd1);
            g.FillPie(b1, rectangle, 0, pd1);

            g.DrawPie(pen, rectangle, pd1, pd2);
            g.FillPie(b2, rectangle, pd1 , pd2);

            g.DrawPie(pen, rectangle, pd1+pd2, pd3);
            g.FillPie(b3, rectangle, pd1+pd2, pd3);

            g.DrawPie(pen, rectangle, pd1+pd2+pd3, pd4);
            g.FillPie(b4, rectangle, pd1+pd2+pd3, pd4);

            g.DrawPie(pen, rectangle, pd1 + pd2 + pd3+pd4, pd5);
            g.FillPie(b5, rectangle, pd1 + pd2 + pd3+pd4, pd5);

            g.DrawPie(pen, rectangle, pd1 + pd2 + pd3+pd4+pd5, pd6);
            g.FillPie(b6, rectangle, pd1 + pd2 + pd3 + pd4 + pd5, pd6);

            g.DrawPie(pen, rectangle, pd1 + pd2 + pd3 + pd4 + pd5+pd6, pd7);
            g.FillPie(b7, rectangle, pd1 + pd2 + pd3 + pd4 + pd5 + pd6, pd7);

            g.DrawPie(pen, rectangle, pd1 + pd2 + pd3 + pd4 + pd5 + pd6+pd7, pd8);
            g.FillPie(b8, rectangle, pd1 + pd2 + pd3 + pd4 + pd5 + pd6+pd7, pd8);
        }
    }
}
