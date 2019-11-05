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
    public partial class FrmOgreenciAra : Form

    {
        SqlConnection cn = null;
        private Form1 form1;

        public FrmOgreenciAra()
        {
            InitializeComponent();
        }

        public FrmOgreenciAra(Form1 form1)
        {
            this.form1 = form1;
            InitializeComponent();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            Bul(int.Parse(txtOgrenciNo.Text.Trim()));
        }
        void Bul(int Numara)
        {

            try
            {
                cn = new SqlConnection(@"Data Source=localhost\SQLEXPRESS; Initial Catalog=TestDb;Integrated Security=true");



                SqlParameter[] p = { new SqlParameter("@Numara", txtOgrenciNo.Text.Trim()) };
                SqlCommand cmd = new SqlCommand("Select OgrenciId,Adı,Soyadı,Numara from tblOgrenciler where Numara=@Numara", cn);



                cmd.Parameters.AddRange(p);
                OpenConnection();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    // MessageBox.Show($"Ad:{dr["Adı"].ToString()}\nSoyad:{dr["Soyadı"]}\nNumara:{dr["Numara"]}\nOgrenciId{dr["OgrenciId"]}");

                    Form1 frm = (Form1)Application.OpenForms["Form1"]; //açık forma ulaştık kısa yol

                    frm.txtAd.Text = dr["Adı"].ToString();
                    frm.txtSoyad.Text = dr["Soyadı"].ToString();
                    frm.txtNumara.Text = dr["Numara"].ToString();
                }
                else
                {
                    MessageBox.Show("Öğrenci Bulunmadı");
                }
                dr.Close();
            }
            catch (SqlException ex)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                CloseConnection();
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

    }
}
