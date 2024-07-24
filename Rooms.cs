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
    public partial class Rooms : Form
    {
        public Rooms()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-SFV9JSRE;Initial Catalog=Pansiyon;Integrated Security=True");
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Rooms_Load(object sender, EventArgs e)
        {
            //Room100
            baglanti.Open();
            SqlCommand cmd1 = new SqlCommand("select * from Room100", baglanti);
            SqlDataReader read1 = cmd1.ExecuteReader();

            while(read1.Read()) 
            {
                BtnOda100.Text = read1["Name"].ToString() +" " +read1["Surname"].ToString();
            }
            baglanti.Close();
            if(BtnOda100.Text != "100")
            {
                BtnOda100.BackColor = Color.Red;
            }
            //Room101
            baglanti.Open();
            SqlCommand cmd2 = new SqlCommand("select * from Room101", baglanti);
            SqlDataReader read2 = cmd2.ExecuteReader();
            while (read2.Read())
            {
                BtnOda101.Text = read2["Name"].ToString() + " " + read2["Surname"].ToString();
            }
            baglanti.Close();
            if (BtnOda101.Text != "101")
            {
                BtnOda101.BackColor = Color.Red;
            }
            //Room102
            baglanti.Open();
            SqlCommand cmd3 = new SqlCommand("select * from Room102", baglanti);
            SqlDataReader read3 = cmd3.ExecuteReader();
            while (read3.Read())
            {
                BtnOda102.Text = read3["Name"].ToString() + " " + read3["Surname"].ToString();
            }
            baglanti.Close();
            if (BtnOda102.Text != "102")
            {
                BtnOda102.BackColor = Color.Red;
            }
            //Room103
            baglanti.Open();
            SqlCommand cmd4 = new SqlCommand("select * from Room103", baglanti);
            SqlDataReader read4 = cmd4.ExecuteReader();
            while (read4.Read())
            {
                BtnOda103.Text = read4["Name"].ToString() + " " + read4["Surname"].ToString();
            }
            baglanti.Close();
            if (BtnOda103.Text != "103")
            {
                BtnOda103.BackColor = Color.Red;
            }
            //Room104
            baglanti.Open();
            SqlCommand cmd5 = new SqlCommand("select * from Room104", baglanti);
            SqlDataReader read5 = cmd5.ExecuteReader();
            while (read5.Read())
            {
                BtnOda104.Text = read5["Name"].ToString() + " " + read5["Surname"].ToString();
            }
            baglanti.Close();
            if (BtnOda104.Text != "104")
            {
                BtnOda104.BackColor = Color.Red;
            }
            //Room105
            baglanti.Open();
            SqlCommand cmd6 = new SqlCommand("select * from Room105", baglanti);
            SqlDataReader read6 = cmd6.ExecuteReader();
            while (read6.Read())
            {
                BtnOda105.Text = read6["Name"].ToString() + " " + read6["Surname"].ToString();
            }
            baglanti.Close();
            if (BtnOda105.Text != "105")
            {
                BtnOda105.BackColor = Color.Red;
            }
            //Room106
            baglanti.Open();
            SqlCommand cmd7 = new SqlCommand("select * from Room106", baglanti);
            SqlDataReader read7 = cmd7.ExecuteReader();
            while (read7.Read())
            {
                BtnOda106.Text = read7["Name"].ToString() + " " + read7["Surname"].ToString();
            }
            baglanti.Close();
            if (BtnOda106.Text != "106")
            {
                BtnOda106.BackColor = Color.Red;
            }
            //Room107
            baglanti.Open();
            SqlCommand cmd8 = new SqlCommand("select * from Room107", baglanti);
            SqlDataReader read8 = cmd8.ExecuteReader();
            while (read8.Read())
            {
                BtnOda107.Text = read8["Name"].ToString() + " " + read8["Surname"].ToString();
            }
            baglanti.Close();
            if (BtnOda107.Text != "107")
            {
                BtnOda107.BackColor = Color.Red;
            }
        }
    }
}
