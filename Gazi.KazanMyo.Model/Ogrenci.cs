using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gazi.KazanMyo.Model
{
    public class Ogrenci
    {


        public string Ogrenciid { get; set; }

        string ad;
        string soyad;

        public string Numara { get; set; }

        public string Ad { get => ad; set => ad = value.ToUpper(); }

        public string Soyad { get => soyad; set => soyad = value.ToUpper(); }
    }

}
