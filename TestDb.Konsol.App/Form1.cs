using Gazi.KazanMyo.BLL;
using Gazi.KazanMyo.Model;
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

namespace TestDb.Konsol.App
{
    public partial class Form1 : Form
    {
        SqlConnection cn = null;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        //sql injection

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                OgrenciBL obl = new OgrenciBL();
                Ogrenci ogrenci = new Ogrenci();
                ogrenci.Ad = txtAd.Text.Trim();
                ogrenci.Soyad = txtSoyad.Text.Trim();
                ogrenci.Numara = txtNumara.Text.Trim();
                
               
                MessageBox.Show(obl.OgrenciEkle(ogrenci) ? "Başarılı" : "Başarısız");
                
               

            }
            catch (SqlException ex)
            {
                switch (ex.Number)
                {
                    case 245:
                        MessageBox.Show("Numara Girişinde hata var!");
                        break;
                    default:
                        MessageBox.Show("veri tabanı hatası!");
                        break;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Bir Hata Oluştu");
            }

        }
        void OpenConnection()
        {
            try
            {
                if (cn != null && cn.State != ConnectionState.Open)
                {
                    cn.Open();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        void CloseConnection()
        {
            try
            {
                if (cn != null && cn.State != ConnectionState.Closed)
                {
                    cn.Close();
                }
            }
            catch (Exception)
            {

                throw;
            }

        }
       
        private void btnOgrenciAra_Click(object sender, EventArgs e)
        {
            FrmOgreenciAra frm = new FrmOgreenciAra(this);
            frm.Show();
        }
    }
}

