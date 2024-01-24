using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LabaratuvarYonetimSistemi.Models
{
    public class Parametre
    {
        [Key]
        public int ParametreID { get; set; }
        public bool GirisIzni { get; set; }
        public string GirisBaslangicZamani { get; set; }
        public string GirisBitisZamani { get; set; }
        public bool Aktif { get; set; }
        public string EklemeZamani { get; set; }
        public string GuncellemeZamani { get; set; }
        public string GuncelleyenIP { get; set; }
        public string GuncelleyenBilgisi { get; set; }
    }
}