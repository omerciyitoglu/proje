using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CYTOBS
{
    public partial class FrmAnaForm : Form
    {
        public FrmAnaForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAdminGiris fr = new FrmAdminGiris();
            fr.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmYeniMusteri fr = new FrmYeniMusteri();
            fr.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmMüsteriler fr = new FrmMüsteriler();
            fr.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("CYT OBS / Gaziantep 2021");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmOdalar fr = new FrmOdalar();
            fr.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("YENİ MESAJINIZ BULUNMAMAKTADIR");
        }

        private void FrmAnaForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Sınavlar fr = new Sınavlar();
            fr.Show();
            
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongDateString();
            label2.Text = DateTime.Now.ToLongTimeString();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
