namespace CYTOBS
{
    partial class Sınavlar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sınavlar));
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BtnGuncelle = new System.Windows.Forms.Button();
            this.BtnVerileriGöster = new System.Windows.Forms.Button();
            this.TxtOrt = new System.Windows.Forms.TextBox();
            this.TxtBüt = new System.Windows.Forms.TextBox();
            this.TxtFin = new System.Windows.Forms.TextBox();
            this.TxtViz = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.BtnSil = new System.Windows.Forms.Button();
            this.BtnTemiz = new System.Windows.Forms.Button();
            this.BtnOrt = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtSoy = new System.Windows.Forms.TextBox();
            this.TxtTC = new System.Windows.Forms.TextBox();
            this.TxtAdi = new System.Windows.Forms.TextBox();
            this.TxtDers = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(891, 174);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "No";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ad";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Soyadı";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "TC";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Ders";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Vize";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Final";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Bütünleme";
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Ortalama";
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGuncelle.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnGuncelle.Location = new System.Drawing.Point(655, 315);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(200, 50);
            this.BtnGuncelle.TabIndex = 4;
            this.BtnGuncelle.Text = "Güncelle";
            this.BtnGuncelle.UseVisualStyleBackColor = true;
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // BtnVerileriGöster
            // 
            this.BtnVerileriGöster.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnVerileriGöster.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnVerileriGöster.Location = new System.Drawing.Point(655, 256);
            this.BtnVerileriGöster.Name = "BtnVerileriGöster";
            this.BtnVerileriGöster.Size = new System.Drawing.Size(200, 50);
            this.BtnVerileriGöster.TabIndex = 3;
            this.BtnVerileriGöster.Text = "Kayıtları Göster";
            this.BtnVerileriGöster.UseVisualStyleBackColor = true;
            this.BtnVerileriGöster.Click += new System.EventHandler(this.BtnVerileriGöster_Click);
            // 
            // TxtOrt
            // 
            this.TxtOrt.Location = new System.Drawing.Point(174, 454);
            this.TxtOrt.Name = "TxtOrt";
            this.TxtOrt.Size = new System.Drawing.Size(185, 20);
            this.TxtOrt.TabIndex = 6;
            this.TxtOrt.TextChanged += new System.EventHandler(this.TxtOrt_TextChanged);
            // 
            // TxtBüt
            // 
            this.TxtBüt.Location = new System.Drawing.Point(174, 419);
            this.TxtBüt.Name = "TxtBüt";
            this.TxtBüt.Size = new System.Drawing.Size(185, 20);
            this.TxtBüt.TabIndex = 7;
            // 
            // TxtFin
            // 
            this.TxtFin.Location = new System.Drawing.Point(174, 384);
            this.TxtFin.Name = "TxtFin";
            this.TxtFin.Size = new System.Drawing.Size(185, 20);
            this.TxtFin.TabIndex = 8;
            // 
            // TxtViz
            // 
            this.TxtViz.Location = new System.Drawing.Point(174, 346);
            this.TxtViz.Name = "TxtViz";
            this.TxtViz.Size = new System.Drawing.Size(185, 20);
            this.TxtViz.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(112, 306);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "Ders:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(114, 347);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "Vize:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(111, 388);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 21;
            this.label3.Text = "Final:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(73, 423);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 16);
            this.label4.TabIndex = 22;
            this.label4.Text = "Bütünleme:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(82, 454);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 16);
            this.label5.TabIndex = 23;
            this.label5.Text = "Ortalama:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKaydet.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Location = new System.Drawing.Point(655, 189);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(200, 50);
            this.btnKaydet.TabIndex = 24;
            this.btnKaydet.Text = "Sınavları Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(-3, 518);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(13, 13);
            this.label11.TabIndex = 44;
            this.label11.Text = "0";
            this.label11.Visible = false;
            // 
            // BtnSil
            // 
            this.BtnSil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSil.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSil.Location = new System.Drawing.Point(655, 380);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(200, 50);
            this.BtnSil.TabIndex = 45;
            this.BtnSil.Text = "Sınavı Sil";
            this.BtnSil.UseVisualStyleBackColor = true;
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // BtnTemiz
            // 
            this.BtnTemiz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnTemiz.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnTemiz.Location = new System.Drawing.Point(655, 447);
            this.BtnTemiz.Name = "BtnTemiz";
            this.BtnTemiz.Size = new System.Drawing.Size(200, 50);
            this.BtnTemiz.TabIndex = 46;
            this.BtnTemiz.Text = "Temizle";
            this.BtnTemiz.UseVisualStyleBackColor = true;
            this.BtnTemiz.Click += new System.EventHandler(this.BtnTemiz_Click);
            // 
            // BtnOrt
            // 
            this.BtnOrt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnOrt.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnOrt.Location = new System.Drawing.Point(449, 447);
            this.BtnOrt.Name = "BtnOrt";
            this.BtnOrt.Size = new System.Drawing.Size(200, 50);
            this.BtnOrt.TabIndex = 47;
            this.BtnOrt.Text = "Ortalama Hesapla";
            this.BtnOrt.UseVisualStyleBackColor = true;
            this.BtnOrt.Click += new System.EventHandler(this.BtnOrt_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(43, 267);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 16);
            this.label6.TabIndex = 53;
            this.label6.Text = "TC/ÖğrenciNo:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(95, 229);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 16);
            this.label7.TabIndex = 52;
            this.label7.Text = "Soyadı:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(127, 189);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 16);
            this.label8.TabIndex = 51;
            this.label8.Text = "Ad:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // TxtSoy
            // 
            this.TxtSoy.Location = new System.Drawing.Point(174, 229);
            this.TxtSoy.Name = "TxtSoy";
            this.TxtSoy.Size = new System.Drawing.Size(185, 20);
            this.TxtSoy.TabIndex = 50;
            this.TxtSoy.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TxtTC
            // 
            this.TxtTC.Location = new System.Drawing.Point(174, 267);
            this.TxtTC.Name = "TxtTC";
            this.TxtTC.Size = new System.Drawing.Size(185, 20);
            this.TxtTC.TabIndex = 49;
            this.TxtTC.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // TxtAdi
            // 
            this.TxtAdi.Location = new System.Drawing.Point(174, 189);
            this.TxtAdi.Name = "TxtAdi";
            this.TxtAdi.Size = new System.Drawing.Size(185, 20);
            this.TxtAdi.TabIndex = 48;
            this.TxtAdi.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // TxtDers
            // 
            this.TxtDers.Location = new System.Drawing.Point(174, 306);
            this.TxtDers.Name = "TxtDers";
            this.TxtDers.Size = new System.Drawing.Size(185, 20);
            this.TxtDers.TabIndex = 54;
            // 
            // Sınavlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(891, 531);
            this.Controls.Add(this.TxtDers);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TxtSoy);
            this.Controls.Add(this.TxtTC);
            this.Controls.Add(this.TxtAdi);
            this.Controls.Add(this.BtnOrt);
            this.Controls.Add(this.BtnTemiz);
            this.Controls.Add(this.BtnSil);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtViz);
            this.Controls.Add(this.TxtFin);
            this.Controls.Add(this.TxtBüt);
            this.Controls.Add(this.TxtOrt);
            this.Controls.Add(this.BtnGuncelle);
            this.Controls.Add(this.BtnVerileriGöster);
            this.Controls.Add(this.listView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Sınavlar";
            this.Text = "Sınavlar";
            this.Load += new System.EventHandler(this.Sınavlar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button BtnGuncelle;
        private System.Windows.Forms.Button BtnVerileriGöster;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.TextBox TxtOrt;
        private System.Windows.Forms.TextBox TxtBüt;
        private System.Windows.Forms.TextBox TxtFin;
        private System.Windows.Forms.TextBox TxtViz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.Button BtnTemiz;
        private System.Windows.Forms.Button BtnOrt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtSoy;
        private System.Windows.Forms.TextBox TxtTC;
        private System.Windows.Forms.TextBox TxtAdi;
        private System.Windows.Forms.TextBox TxtDers;
    }
}