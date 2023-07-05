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
    public partial class Sınavlar : Form
    {
        public Sınavlar()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=OMER-BILGISAYAR;Initial Catalog=CYTHotel;Integrated Security=True");
        private void verilergoster()
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Sinav", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Müsteriid"].ToString();
                ekle.SubItems.Add(oku["Adi"].ToString());
                ekle.SubItems.Add(oku["Soyadi"].ToString());
                ekle.SubItems.Add(oku["TC"].ToString());
                ekle.SubItems.Add(oku["Ders"].ToString());
                ekle.SubItems.Add(oku["Vize"].ToString());
                ekle.SubItems.Add(oku["Final"].ToString());
                ekle.SubItems.Add(oku["Bütünleme"].ToString());
                ekle.SubItems.Add(oku["Ortalama"].ToString());

                listView1.Items.Add(ekle);

            }
            baglanti.Close();
        }
        
        
        private void BtnVerileriGöster_Click(object sender, EventArgs e)
        {
            verilergoster();
        }

        private void Sınavlar_Load(object sender, EventArgs e)
        {

        }
        int id = 0;
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            TxtAdi.Text = listView1.SelectedItems[0].SubItems[1].Text;
            TxtSoy.Text = listView1.SelectedItems[0].SubItems[2].Text;
            TxtTC.Text = listView1.SelectedItems[0].SubItems[3].Text;
            TxtDers.Text = listView1.SelectedItems[0].SubItems[4].Text;
            TxtViz.Text = listView1.SelectedItems[0].SubItems[5].Text;
            TxtFin.Text = listView1.SelectedItems[0].SubItems[6].Text;
            TxtBüt.Text = listView1.SelectedItems[0].SubItems[7].Text;
            TxtOrt.Text = listView1.SelectedItems[0].SubItems[8].Text;
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("insert into Sinav(Adi,Soyadi,TC,Ders,Vize,Final,Bütünleme,Ortalama) values('" + TxtAdi.Text + "','" + TxtSoy.Text + "','" + TxtTC.Text + "','" + TxtDers.Text + "','" + TxtViz.Text + "','" + TxtFin.Text + "','" + TxtBüt.Text + "','" + TxtOrt.Text + "')", baglanti);
            komut3.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("Sınav  Kaydı Başarı ile Gerçekleştirildi");
        }

        private void TxtOrt_TextChanged(object sender, EventArgs e)
        {
           
            
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Update Sinav set Adi ='" + TxtAdi.Text + "', Soyadi ='" + TxtSoy.Text + "', TC ='" + TxtTC.Text + "', Ders ='" + TxtDers.Text + "',Vize='" + TxtViz.Text + "',Final='" + TxtFin.Text + "',Bütünleme='" + TxtBüt.Text + "', Ortalama='" + TxtOrt.Text + "'where Müsteriid=" + id + "", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            verilergoster();

           

        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from Sinav where Müsteriid=(" + id + ")", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            verilergoster();
        }
        private double hesaplama (double vize  ,double final)
    {
        return vize * 0.4 + final*0.6;
        
    }

        private void BtnTemiz_Click(object sender, EventArgs e)
        {
            TxtAdi.Clear();
            TxtSoy.Clear();
            TxtTC.Clear();
            TxtDers.Clear();
            TxtViz.Clear();
            TxtFin.Clear();
            TxtBüt.Clear();
            TxtOrt.Clear();
            

        }

        private void BtnOrt_Click(object sender, EventArgs e)
        {
            double vize = Convert.ToInt32(TxtViz.Text);
            double final = Convert.ToInt32(TxtFin.Text);
            TxtOrt.Text = hesaplama(vize, final).ToString();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
