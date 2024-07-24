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
    public partial class CostumerInformation : Form
    {
        public CostumerInformation()
        {
            InitializeComponent();
        }
        SqlConnection baglanti1 =new SqlConnection("Data Source=LAPTOP-SFV9JSRE;Initial Catalog=Pansiyon;Integrated Security=True");

        private void showData()
        {
            listViewInfo.Items.Clear();//the page is cleared to prevent the list from being overwritten
            baglanti1.Open();
            SqlCommand cmd = new SqlCommand("select * from AddCostumer", baglanti1);
            SqlDataReader read = cmd.ExecuteReader();

            while(read.Read())
            {
                ListViewItem add= new ListViewItem();
                add.Text = read["CostumerId"].ToString();
                add.SubItems.Add(read["TC"].ToString());
                add.SubItems.Add(read["Name"].ToString());
                add.SubItems.Add(read["Surname"].ToString());
                add.SubItems.Add(read["PhoneNumber"].ToString());
                add.SubItems.Add(read["RoomNumber"].ToString());
                add.SubItems.Add(read["Cost"].ToString());
                add.SubItems.Add(read["EntryDate"].ToString());
                add.SubItems.Add(read["ExitDate"].ToString());
                add.SubItems.Add(read["Gender"].ToString());

                listViewInfo.Items.Add(add);
            }
            baglanti1.Close();
        }
        private void ListCostumer_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            showData();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (TxtRoomNo.Text == "100")
            {
                baglanti1.Open();
                SqlCommand cmd = new SqlCommand("delete from Room100", baglanti1);
                cmd.ExecuteNonQuery();
                baglanti1.Close();
                showData();
            }
            if (TxtRoomNo.Text == "101")
            {
                baglanti1.Open();
                SqlCommand cmd = new SqlCommand("delete from Room101", baglanti1);
                cmd.ExecuteNonQuery();
                baglanti1.Close();
                showData();
            }
            if (TxtRoomNo.Text == "102")
            {
                baglanti1.Open();
                SqlCommand cmd = new SqlCommand("delete from Room102", baglanti1);
                cmd.ExecuteNonQuery();
                baglanti1.Close();
                showData();
            }
            if (TxtRoomNo.Text == "103")
            {
                baglanti1.Open();
                SqlCommand cmd = new SqlCommand("delete from Room103", baglanti1);
                cmd.ExecuteNonQuery();
                baglanti1.Close();
                showData();
            }
            if (TxtRoomNo.Text == "104")
            {
                baglanti1.Open();
                SqlCommand cmd = new SqlCommand("delete from Room104", baglanti1);
                cmd.ExecuteNonQuery();
                baglanti1.Close();
                showData();
            }
                if (TxtRoomNo.Text == "105")
            {
                baglanti1.Open();
                SqlCommand cmd = new SqlCommand("delete from Room105", baglanti1);
                cmd.ExecuteNonQuery();
                baglanti1.Close();
                showData();
            }
            if (TxtRoomNo.Text == "106")
            {
                baglanti1.Open();
                SqlCommand cmd = new SqlCommand("delete from Room106", baglanti1);
                cmd.ExecuteNonQuery();
                baglanti1.Close();
                showData();
            }
            if (TxtRoomNo.Text == "107")
            {
                baglanti1.Open();
                SqlCommand cmd = new SqlCommand("delete from Room107", baglanti1);
                cmd.ExecuteNonQuery();
                baglanti1.Close();
                showData();
            }

           
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            listViewInfo.Items.Clear();//the page is cleared to prevent the list from being overwritten
            baglanti1.Open();
            SqlCommand cmd = new SqlCommand("select * from AddCostumer where Name like '%"+TxtSearch.Text+"%'", baglanti1);
            SqlDataReader read = cmd.ExecuteReader();

            while (read.Read())
            {
                ListViewItem add = new ListViewItem();
                add.Text = read["CostumerId"].ToString();
                add.SubItems.Add(read["TC"].ToString());
                add.SubItems.Add(read["Name"].ToString());
                add.SubItems.Add(read["Surname"].ToString());
                add.SubItems.Add(read["PhoneNumber"].ToString());
                add.SubItems.Add(read["RoomNumber"].ToString());
                add.SubItems.Add(read["Cost"].ToString());
                add.SubItems.Add(read["EntryDate"].ToString());
                add.SubItems.Add(read["ExitDate"].ToString());
                add.SubItems.Add(read["Gender"].ToString());

                listViewInfo.Items.Add(add);
            }
            baglanti1.Close();
        }
        int id = 0;
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            //In this field, the tree code that shows the information when the customer number is double clicked was written
            id = int.Parse(listViewInfo.SelectedItems[0].SubItems[0].Text);
            TxtTc.Text = listViewInfo.SelectedItems[0].SubItems[1].Text;
            TxtName.Text = listViewInfo.SelectedItems[0].SubItems[2].Text;
            TxtSurname.Text = listViewInfo.SelectedItems[0].SubItems[3].Text;
            MskTxtPhoneNo.Text = listViewInfo.SelectedItems[0].SubItems[4].Text;
            TxtRoomNo.Text = listViewInfo.SelectedItems[0].SubItems[5].Text;
            TxtCost.Text = listViewInfo.SelectedItems[0].SubItems[6].Text;
            DtpEntry.Text = listViewInfo.SelectedItems[0].SubItems[7].Text;
            DtpExit.Text = listViewInfo.SelectedItems[0].SubItems[8].Text;
            ComboBoxGender.Text= listViewInfo.SelectedItems[0].SubItems[9].Text;
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            baglanti1.Open();
            SqlCommand cmd = new SqlCommand("update AddCostumer set TC='" + TxtTc.Text + "',Name='" + TxtName.Text + "',Surname='" + TxtSurname.Text + "',PhoneNumber='" + MskTxtPhoneNo.Text + "',RoomNumber='" + TxtRoomNo.Text + "',Cost='" + TxtCost.Text + "',EntryDate='" + DtpEntry.Value.ToString("yyyy-MM-dd") + "',ExitDate='" + DtpExit.Value.ToString("yyyy-MM-dd") + "',Gender='" + ComboBoxGender.Text + "'where CostumerId=" + id + "", baglanti1);
            cmd.ExecuteNonQuery();
            baglanti1.Close();
            showData();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            TxtTc.Clear();
            TxtName.Clear();
            TxtSurname.Clear();
            MskTxtPhoneNo.Clear();
            TxtRoomNo.Clear();
            TxtCost.Clear();
            DtpEntry.Text = "";
            DtpExit.Text = "";
            ComboBoxGender.Text = "";
        }
        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
//Data Source=LAPTOP-SFV9JSRE;Initial Catalog=Pansiyon;Integrated Security=True
// SqlCommand cmd = new SqlCommand("delete from AddCostumer where CostumerId=("+id+")", baglanti1);
