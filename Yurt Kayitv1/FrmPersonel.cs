﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Yurt_Kayitv1
{
    public partial class FrmPersonel : Form
    {
        public FrmPersonel()
        {
            InitializeComponent();
        }
        SqlBaglantim bgl = new SqlBaglantim();
        private void FrmPersonel_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yurtKayıtDataSet6.Personel' table. You can move, or remove it, as needed.
            this.personelTableAdapter.Fill(this.yurtKayıtDataSet6.Personel);

        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Personel (PersonelAdSoyad,PersonelDepartman) values (@p1,@p2)",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtPersonelad.Text);
            komut.Parameters.AddWithValue("@p2", TxtPersonelGroev.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt Başarılı");
            this.personelTableAdapter.Fill(this.yurtKayıtDataSet6.Personel);

        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand ("delete from Personel where Personelid=@p1",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtPersonelid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Silme İşlemi Başarılı");
            this.personelTableAdapter.Fill(this.yurtKayıtDataSet6.Personel);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen;
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            string ad, gorev, id;
            id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            ad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            gorev = dataGridView1.Rows[secilen].Cells[2].Value.ToString();

            TxtPersonelad.Text = ad;
            TxtPersonelGroev.Text = gorev;
            TxtPersonelid.Text = id;
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komutgun = new SqlCommand("update Personel set PersonelAdSoyad=@p1,PersonelDepartman=@p2 where Personelid=@p3", bgl.baglanti());
            komutgun.Parameters.AddWithValue("@p1", TxtPersonelad.Text);
            komutgun.Parameters.AddWithValue("@p2", TxtPersonelGroev.Text);
            komutgun.Parameters.AddWithValue("@p3", TxtPersonelid.Text);
            komutgun.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("İşlem Başarılır");
            this.personelTableAdapter.Fill(this.yurtKayıtDataSet6.Personel);

        }
    }
}
