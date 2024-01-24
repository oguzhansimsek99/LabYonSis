using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LabaratuvarYonetimSistemi.Models
{
    public class Yazilim
    {
        [Key]
        public int YazilimID { get; set; }
        [MaxLength(200, ErrorMessage = "En fazla 200 karakterlik bilgi girişi yapabilirsiniz.")]
        [Required(ErrorMessage = "Boş Geçemezsiniz")]

        public string YazilimAd { get; set; }

        [MaxLength(100, ErrorMessage = "En fazla 100 karakterlik bilgi girişi yapabilirsiniz.")]
        public string Firma { get; set; }

        [MaxLength(100, ErrorMessage = "En fazla 100 karakterlik bilgi girişi yapabilirsiniz.")]
        public string Versiyon { get; set; }

        [MaxLength(100, ErrorMessage = "En fazla 100 karakterlik bilgi girişi yapabilirsiniz.")]
        public string LisansTuru { get; set; }
        public string LisansBaslangic { get; set; }
        public string LisansBitis { get; set; }
        public bool Aktif { get; set; }
        public string EklemeZamani { get; set; }
        public string GuncellemeZamani { get; set; }
        public string GuncelleyenIP { get; set; }
        public string GuncelleyenBilgisi { get; set; }
        public virtual ICollection<LabaratuvarYazilim> LabaratuvarYazilim { get; set; }
    }
}