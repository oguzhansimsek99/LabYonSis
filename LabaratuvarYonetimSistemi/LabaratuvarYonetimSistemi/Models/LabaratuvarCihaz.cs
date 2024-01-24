using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LabaratuvarYonetimSistemi.Models
{
    public class LabaratuvarCihaz
    {
        [Key]
        public int LabaratuvarCihazID { get; set; }
        public int LabaratuvarID { get; set; }
        public int CihazID { get; set; }

        public bool Aktif { get; set; }
        public string EklemeZamani { get; set; }
        public string GuncellemeZamani { get; set; }
        public string GuncelleyenIP { get; set; }
        public string GuncelleyenBilgisi { get; set; }

        public virtual Labaratuvar Labaratuvar { get; set; }
        public virtual Cihaz Cihaz { get; set; }
    }
}