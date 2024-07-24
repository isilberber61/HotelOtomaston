using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PansiyonOtomasyonu
{
    public partial class ReceivedItems : Form
    {
        public ReceivedItems()
        {
            InitializeComponent();
        }
        SqlConnection baglanti1 = new SqlConnection("Data Source=LAPTOP-SFV9JSRE;Initial Catalog=Pansiyon;Integrated Security=True");
        private void dataReceivedItems()
        {
            listView1.Items.Clear();
            baglanti1.Open();
            SqlCommand cmd = new SqlCommand("select * from ReceivedItems", baglanti1);
            SqlDataReader reader = cmd.ExecuteReader();

            while(reader.Read())
            {
                ListViewItem add = new ListViewItem();
                add.Text= reader["ForRestaurant"].ToString();
                add.SubItems.Add(reader["ForCleanStaff"].ToString());
                add.SubItems.Add(reader["ForRoomNeeds"].ToString());
                listView1.Items.Add(add);
            }
            baglanti1.Close();
        }

        private void dataBills()
        {
            listView2.Items.Clear();
            baglanti1.Open();
            SqlCommand cmd1 = new SqlCommand("select * from Bills", baglanti1);
            SqlDataReader reader1 = cmd1.ExecuteReader();

            while (reader1.Read())
            {
                ListViewItem add = new ListViewItem();
                add.Text = reader1["Electricity"].ToString();
                add.SubItems.Add(reader1["Water"].ToString());
                add.SubItems.Add(reader1["Internet"].ToString());
                listView2.Items.Add(add);
            }
            baglanti1.Close();
        }
        private void ReceivedItems_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'pansiyonDataSet.ReceivedItems' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            //this.receivedItemsTableAdapter.Fill(this.pansiyonDataSet.ReceivedItems);
            dataReceivedItems();
            dataBills();
        }

       
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnSave1_Click(object sender, EventArgs e)
        {
            baglanti1.Open();
            SqlCommand cmd = new SqlCommand("insert into Bills(Electricity,Water,Internet) values('" + TxtElectricity.Text + "','" + TxtWater.Text + "','" + TxtInternet.Text + "')", baglanti1);
            cmd.ExecuteNonQuery();
            baglanti1.Close();

            dataBills();
        }

        private void BtnSave_Click_1(object sender, EventArgs e)
        {
            baglanti1.Open();
            SqlCommand cmd = new SqlCommand("insert into ReceivedItems(ForRestaurant,ForCleanStaff,ForRoomNeeds) values('" + TxtForRestaurant.Text + "','" + TxtCleanStaff.Text + "','" + TxtRoomNeeds.Text + "')", baglanti1);
            cmd.ExecuteNonQuery();
            baglanti1.Close();

            dataReceivedItems();
        }
    }
}
