using System;
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
    public partial class FrmOgrDüzenle : Form
    {
        public FrmOgrDüzenle()
        {
            InitializeComponent();
        }
        public string id,ad,soyad,tc,telefon,dogum,bolum,mail,odano,veliad,velitel,veliadres;

        private void BtnSil_Click(object sender, EventArgs e)
        {  //öğrenci silme
            SqlCommand komutsil = new SqlCommand("delete from Ogrenci where Ogrid=@k1",bgl.baglanti());
            komutsil.Parameters.AddWithValue("@k1", Txtİd.Text);
            komutsil.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt Silindi");

            //odanın aktif öğrenci sayısını azaltma
            SqlCommand komutoda = new SqlCommand("update Odalarr set OdaAktif=OdaAktif-1 where OdaNo=@oda",bgl.baglanti());
            komutoda.Parameters.AddWithValue("@oda", CmbOdaNo.Text);
            komutoda.ExecuteNonQuery();
            bgl.baglanti().Close();

        }

        SqlBaglantim bgl = new SqlBaglantim();
        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut = new SqlCommand("update Ogrenci set OgrAd=@p2,OgrSoyad=@p3,OgrTC=@p4,OgrTelefon=@p5,OgrDogum=@p6,OgrBolum=@p7,OgrMail=@p8,OgrOdaNo=@p9,OgrVeliAdSoyad=@p10,OgrVeliTelefon=@p11,OgrVeliAdres=@p12 where Ogrid=@p1", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", Txtİd.Text);
                komut.Parameters.AddWithValue("@p2", TxtOgrAd.Text);
                komut.Parameters.AddWithValue("@p3", TxtOgrSoyad.Text);
                komut.Parameters.AddWithValue("@p4", MskTc.Text);
                komut.Parameters.AddWithValue("@p5", MskTel.Text);
                komut.Parameters.AddWithValue("@p6", MskDogum.Text);
                komut.Parameters.AddWithValue("@p7", CmbBolum.Text);
                komut.Parameters.AddWithValue("@p8", TxtMail.Text);
                komut.Parameters.AddWithValue("@p9", CmbOdaNo.Text);
                komut.Parameters.AddWithValue("@p10", TxtVeliAdSoyad.Text);
                komut.Parameters.AddWithValue("@p11", MskVeliTel.Text);
                komut.Parameters.AddWithValue("@p12", RchAdres.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Kayıt Güncellendi");
            }
            catch (Exception)
            {

                MessageBox.Show("HATA tekrar deneyin");
            }


        }

        private void FrmOgrDüzenle_Load(object sender, EventArgs e)
        {
            Txtİd.Text = id;
            TxtOgrAd.Text = ad;
            TxtOgrSoyad.Text = soyad;
            MskTc.Text = tc;
            MskTel.Text = telefon;
            MskDogum.Text = dogum;
            CmbBolum.Text = bolum;
            TxtMail.Text = mail;
            CmbOdaNo.Text = odano;
            TxtVeliAdSoyad.Text = veliad;
            MskVeliTel.Text = velitel;
            RchAdres.Text = veliadres;

        }
    }
}
