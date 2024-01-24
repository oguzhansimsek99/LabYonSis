using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LabaratuvarYonetimSistemi.Models
{
    public class Ziyaretci
    {
        [Key]
        public int ZiyaretciID { get; set; }

        public int KullaniciNo { get; set; }


       
        public string KullaniciAd { get; set; }

        public string Ad { get; set; }

      
        public string Soyad { get; set; }

       
        public string SicilNo { get; set; }


        public int KullaniciTuru { get; set; }

        public string GirisIP { get; set; }
        public string GirisZamani { get; set; }
    }
}