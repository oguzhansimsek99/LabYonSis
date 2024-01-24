using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LabaratuvarYonetimSistemi.Models
{
    public class CihazTuru
    {
        [Key]
        public int CihazTuruID { get; set; }
        [MaxLength(100, ErrorMessage = "En fazla 100 karakterlik bilgi girişi yapabilirsiniz.")]
        [Required(ErrorMessage = "Boş Geçemezsiniz")]

        public string CihazTuruAd { get; set; }
        public bool Aktif { get; set; }
        public string EklemeZamani { get; set; }
        public string GuncellemeZamani { get; set; }
        public string GuncelleyenIP { get; set; }
        public string GuncelleyenBilgisi { get; set; }
        public virtual ICollection<Cihaz> Cihaz { get; set; }
    }
}