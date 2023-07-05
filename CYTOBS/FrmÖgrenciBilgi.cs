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

namespace CYTOBS
{
    public partial class FrmMüsteriler : Form
    {
        public FrmMüsteriler()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=OMER-BILGISAYAR;Initial Catalog=CYTHotel;Integrated Security=True");

        private void verilergoster()
    {
        listView1.Items.Clear();
        baglanti.Open();
        SqlCommand komut = new SqlCommand("select * from MusteriEkle",baglanti);
        SqlDataReader oku = komut.ExecuteReader();
        while (oku.Read())
        {
            ListViewItem ekle = new ListViewItem();
            ekle.Text = oku["Müsteriid"].ToString();
            ekle.SubItems.Add(oku["Adi"].ToString());
            ekle.SubItems.Add(oku["Soyadi"].ToString());
            ekle.SubItems.Add(oku["Cinsiyet"].ToString());
            ekle.SubItems.Add(oku["Ders"].ToString());
            ekle.SubItems.Add(oku["Bölüm"].ToString());
            ekle.SubItems.Add(oku["Sınıf"].ToString());
            ekle.SubItems.Add(oku["TC"].ToString());
            ekle.SubItems.Add(oku["OdaNo"].ToString());
            ekle.SubItems.Add(oku["Harc"].ToString());
            ekle.SubItems.Add(oku["GirisTarihi"].ToString());
            ekle.SubItems.Add(oku["CikisTarihi"].ToString());

            listView1.Items.Add(ekle);

        }
        baglanti.Close();
    }

        private void button1_Click(object sender, EventArgs e)
        {
            verilergoster();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        int id = 0;
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            TxtAdi.Text = listView1.SelectedItems[0].SubItems[1].Text;
            TxtSoyadi.Text= listView1.SelectedItems[0].SubItems[2].Text;
            comboBox1.Text = listView1.SelectedItems[0].SubItems[3].Text;
            comboBox2.Text = listView1.SelectedItems[0].SubItems[4].Text;
            comboBoxB.Text = listView1.SelectedItems[0].SubItems[5].Text;
            comboBoxS.Text = listView1.SelectedItems[0].SubItems[6].Text;
            TxtKimlikNo.Text= listView1.SelectedItems[0].SubItems[7].Text;
            TxtOdaNo.Text = listView1.SelectedItems[0].SubItems[8].Text;
            TxtUcret.Text= listView1.SelectedItems[0].SubItems[9].Text;
            DtpGirisTarihi.Text= listView1.SelectedItems[0].SubItems[10].Text;
            DtpCikisTarihi.Text = listView1.SelectedItems[0].SubItems[11].Text;
            

        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Update MusteriEkle set Adi ='" + TxtAdi.Text + "',Soyadi='" + TxtSoyadi.Text + "',Cinsiyet='" + comboBox1.Text + "',Ders='"+ comboBox2.Text+"', Bölüm='" + comboBoxB.Text + "',Sınıf='" + comboBoxS.Text + "',TC='" + TxtKimlikNo.Text + "',OdaNo='" + TxtOdaNo.Text + "',Harc='" + TxtUcret.Text + "',GirisTarihi='"+ DtpGirisTarihi.Value.ToString("yyyy-MM-dd") +"',CikisTarihi='"+DtpCikisTarihi.Value.ToString("yyyy-MM-dd")+ "'where Müsteriid=" + id + "", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            verilergoster();
        
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from MusteriEkle where Müsteriid=(" + id + ")", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            verilergoster();
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            TxtAdi.Clear();
            TxtSoyadi.Clear();
            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBoxB.Text = "";
            comboBoxS.Text = "";
            TxtKimlikNo.Clear();
            TxtOdaNo.Clear();
            TxtUcret.Clear();
            DtpGirisTarihi.Text = "";
            DtpCikisTarihi.Text = "";


        }

        private void BtnAra_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from MusteriEkle where Adi like'%"+textBox1.Text+"%'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Müsteriid"].ToString();
                ekle.SubItems.Add(oku["Adi"].ToString());
                ekle.SubItems.Add(oku["Soyadi"].ToString());
                ekle.SubItems.Add(oku["Cinsiyet"].ToString());
                ekle.SubItems.Add(oku["Ders"].ToString());
                ekle.SubItems.Add(oku["Bölüm"].ToString());
                ekle.SubItems.Add(oku["Sınıf"].ToString());
                ekle.SubItems.Add(oku["TC"].ToString());
                ekle.SubItems.Add(oku["OdaNo"].ToString());
                ekle.SubItems.Add(oku["Harc"].ToString());
                ekle.SubItems.Add(oku["GirisTarihi"].ToString());
                ekle.SubItems.Add(oku["CikisTarihi"].ToString());

                listView1.Items.Add(ekle);

            }
            baglanti.Close();
        }

        private void FrmMüsteriler_Load(object sender, EventArgs e)
        {

        }

        private void BtnOdaSil_Click(object sender, EventArgs e)
        {
            if (TxtOdaNo.Text == "101")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda101", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilergoster();
            }
            if (TxtOdaNo.Text == "102")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda102", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilergoster();
            }
            if (TxtOdaNo.Text == "103")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda103", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilergoster();
            }
            if (TxtOdaNo.Text == "104")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda104", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilergoster();
            }
            if (TxtOdaNo.Text == "105")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda105", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilergoster();
            }
            if (TxtOdaNo.Text == "106")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda106", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilergoster();
            }
            if (TxtOdaNo.Text == "107")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda107", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilergoster();
            }
            if (TxtOdaNo.Text == "108")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda108", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilergoster();
            }
            if (TxtOdaNo.Text == "109")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda109", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilergoster();
            }
        }
    }
}
//Data Source=OMER-BILGISAYAR;Initial Catalog=CYTHotel;Integrated Security=True