using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LabaratuvarYonetimSistemi.Models
{
    public class ParolaIstek
    {
        [Key]
        public int ParolaIstekID { get; set; }
        
        [Required(ErrorMessage = "Boş Geçemezsiniz")]
        public string IstekKurumSicilNo { get; set; }

        [Required(ErrorMessage = "Boş Geçemezsiniz")]
        public string IstekAd { get; set; }

        [Required(ErrorMessage = "Boş Geçemezsiniz")]
        public string IstekSoyad { get; set; }
        public string KayitliAd { get; set; }
        public string KayitliSoyad { get; set; }

        [Required(ErrorMessage = "Boş Geçemezsiniz")]
        public string IstekEposta { get; set; }
        public bool IstekUygun { get; set; }
        public string IstekHataMesaji { get; set; }
        public string IstekZamani { get; set; }
        public string IstekIP { get; set; }
        public int IstekYapanNo { get; set; }
        public string GonderilenKod { get; set; }
        public string OnayZamani { get; set; }
        public string OnayIP { get; set; }
        public bool OnayDurum { get; set; }


        
    }
}