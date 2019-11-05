
using Gazi.KazanMyo.DAL;
using Gazi.KazanMyo.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gazi.KazanMyo.BLL
{
    public class OgrenciBL
    {
        public bool OgrenciEkle(Ogrenci ogr)
        {
            Helper hlp = new Helper();
            SqlParameter[] p = { new SqlParameter("@Adı", ogr.Ad), new SqlParameter("@Soyadı", ogr.Soyad), new SqlParameter("@Numara", ogr.Numara) };
            return hlp.ExecuteNonQuery("ınsert into tblOgrenciler values (@Adı,@Soyadı,@Numara", p) > 0;
        }
    }
}
