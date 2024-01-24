using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LabaratuvarYonetimSistemi.Models
{
    public class Log
    {
        [Key]
        public int LogID { get; set; }

        public string TabloAdi { get; set; }

        public int TabloID { get; set; }

        public int IslemTuru { get; set; }

        
        public string Aciklama { get; set; }

       
        public int KullaniciNo { get; set; }


        public string KullaniciAdi { get; set; }

        public string SicilNo { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int KullaniciTuru { get; set; }
        public string IslemZamani { get; set; }
        public string IslemYapanIP { get; set; }
    }
}