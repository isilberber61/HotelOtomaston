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
    public partial class AddCostumer : Form
    {
        public AddCostumer()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-SFV9JSRE;Initial Catalog=Pansiyon;Integrated Security=True");

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void MusteriForm_Load(object sender, EventArgs e)
        {
            //Room100
            baglanti.Open();
            SqlCommand cmd1 = new SqlCommand("select * from Room100", baglanti);
            SqlDataReader read1 = cmd1.ExecuteReader();

            while (read1.Read())
            {
                BtnOda100.Text = read1["Name"].ToString() + " " + read1["Surname"].ToString();
            }
            baglanti.Close();
            if (BtnOda100.Text != "100")
            {
                BtnOda100.BackColor = Color.Red;
                BtnOda100.Enabled = false;
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
                BtnOda101.Enabled = false;
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
                BtnOda102.Enabled = false;
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
                BtnOda103.Enabled = false;
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
                BtnOda104.Enabled = false;
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
                BtnOda105.Enabled = false;
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
                BtnOda106.Enabled = false;
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
                BtnOda107.Enabled = false;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnOda100_Click(object sender, EventArgs e)
        {
            TxtRoomNo.Text = "100";
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("insert into Room100 (Name,Surname) values('" + TxtName.Text + "','" + TxtSurname.Text + "')", baglanti);
            cmd.ExecuteNonQuery();
            baglanti.Close();
        }
        private void BtnOda101_Click(object sender, EventArgs e)
        {
            TxtRoomNo.Text = "101";
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("insert into Room101 (Name,Surname) values('" + TxtName.Text + "','" + TxtSurname.Text + "')", baglanti);
            cmd.ExecuteNonQuery();
            baglanti.Close();
        }
        private void BtnOda102_Click(object sender, EventArgs e)
        {
            TxtRoomNo.Text = "102";
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("insert into Room102(Name,Surname) values('" + TxtName.Text + "','" + TxtSurname.Text + "')", baglanti);
            cmd.ExecuteNonQuery();
            baglanti.Close();
        }
        private void BtnOda103_Click(object sender, EventArgs e)
        {
            TxtRoomNo.Text = "103";
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("insert into Room103(Name,Surname) values('" + TxtName.Text + "','" + TxtSurname.Text + "')", baglanti);
            cmd.ExecuteNonQuery();
            baglanti.Close();
        }

        private void BtnOda104_Click(object sender, EventArgs e)
        {
            TxtRoomNo.Text = "104";
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("insert into Room104(Name,Surname) values('" + TxtName.Text + "','" + TxtSurname.Text + "')", baglanti);
            cmd.ExecuteNonQuery();
            baglanti.Close();
        }

        private void BtnOda105_Click(object sender, EventArgs e)
        {
            TxtRoomNo.Text = "105";
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("insert into Room105(Name,Surname) values('" + TxtName.Text + "','" + TxtSurname.Text + "')", baglanti);
            cmd.ExecuteNonQuery();
            baglanti.Close();
        }

        private void BtnOda106_Click(object sender, EventArgs e)
        {
            TxtRoomNo.Text = "106";
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("insert into Room106(Name,Surname) values('" + TxtName.Text + "','" + TxtSurname.Text + "')", baglanti);
            cmd.ExecuteNonQuery();
            baglanti.Close();
        }
        private void BtnOda107_Click(object sender, EventArgs e)
        {
            TxtRoomNo.Text = "107";
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("insert into Room107(Name,Surname) values('" + TxtName.Text + "','" + TxtSurname.Text + "')", baglanti);
            cmd.ExecuteNonQuery();
            baglanti.Close();
        }

        private void BtnFull_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Red coloured buttons are full");
        }

        private void BtnEmpty_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aquamarine coloured buttons are empty");
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void DtpExit_ValueChanged(object sender, EventArgs e)
        {
            int cost;
            DateTime FirstTime = Convert.ToDateTime(DtpEntry.Text);
            DateTime LastTime = Convert.ToDateTime(DtpExit.Text);

            TimeSpan finalCost= LastTime- FirstTime;

            LblınvisibleCost.Text = finalCost.TotalDays.ToString();

            cost=Convert.ToInt32(LblınvisibleCost.Text)*200;
            TxtCost.Text = cost.ToString();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into AddCostumer (Tc,Name,Surname,PhoneNumber,RoomNumber,Cost,EntryDate,ExitDate,Gender) values('"+TxtTc.Text +"','"+TxtName.Text+ "','"+TxtSurname.Text+ "','"+MskTxtPhoneNo.Text + "','"+TxtRoomNo.Text + "','"+TxtCost.Text + "','"+DtpEntry.Value.ToString("yyyy-MM-dd") + "','"+DtpExit.Value.ToString("yyyy-MM-dd") + "','"+ComboBoxGender.Text + "')",baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Customer registration successfully saved.");
        }

        private void TxtTc_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void TxtRoomNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void LblınvisibleCost_Click(object sender, EventArgs e)
        {

        }
    }
}
//Data Source = LAPTOP - SFV9JSRE; Initial Catalog = Pansiyon; Integrated Security = True
