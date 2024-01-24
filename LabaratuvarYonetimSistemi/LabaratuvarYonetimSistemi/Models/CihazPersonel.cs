using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LabaratuvarYonetimSistemi.Models
{
    public class CihazPersonel
    {
        [Key]
        public int CihazPersonelID { get; set; }
        public int CihazID { get; set; }
        public int PersonelID { get; set; }

        public bool Aktif { get; set; }
        public string EklemeZamani { get; set; }
        public string GuncellemeZamani { get; set; }
        public string GuncelleyenIP { get; set; }
        public string GuncelleyenBilgisi { get; set; }

        public virtual Cihaz Cihaz { get; set; }
        public virtual Personel Personel { get; set; }
    }
}