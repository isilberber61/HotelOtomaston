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
    public partial class Login : Form
    {
        SqlConnection con;
        SqlDataReader dr;
        SqlCommand com;
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        SqlConnection baglanti1 = new SqlConnection("Data Source=LAPTOP-SFV9JSRE;Initial Catalog=Pansiyon;Integrated Security=True");
       

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void BtnLogin_Click_1(object sender, EventArgs e)
        {

            /* con = new SqlConnection("Data Source=LAPTOP-SFV9JSRE;Initial Catalog=Pansiyon;Integrated Security=True");
             com = new SqlCommand();
             con.Open();
             com.Connection = con;
             com.CommandText= "Select * from LoginUser where UserName='"+TxtUserName.Text+"'and Password='"+TxtPasswordd.Text + "'";
             dr = com.ExecuteReader();

             if(dr.Read())
             {
                 MessageBox.Show("Login succesfull");
                 MainForm main = new MainForm();
                 main.Show();
                 this.Hide();
             }
              else
              {
                  MessageBox.Show("Login failed");
                  TxtUserName.Text = "";
                  TxtPasswordd.Text = "";
                  TxtUserName.Focus();

              }
               con.Close();*/
            try
            {
                baglanti1.Open();
                string sql = "select * from LoginUser where UserName=@UserName AND Password=@Password";
                SqlParameter prm1 = new SqlParameter("UserName", TxtUserName.Text.Trim());
                SqlParameter prm2 = new SqlParameter("Password", TxtPasswordd.Text.Trim());
                SqlCommand cmd = new SqlCommand(sql, baglanti1);
                cmd.Parameters.Add(prm1);
                cmd.Parameters.Add(prm2);

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    MainForm main = new MainForm();
                    main.Show();
                    this.Hide();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Login Failed");

            }
            baglanti1.Close();
        }
    }
           
    }

