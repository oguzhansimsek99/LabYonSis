using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LabaratuvarYonetimSistemi.Models
{
    public class CihazResim
    {
        [Key]
        public int CihazResimlID { get; set; }
        public int CihazID { get; set; }

        [Required(ErrorMessage = "Boş Geçemezsiniz")]
        public string ResimYol { get; set; }
        public bool Aktif { get; set; }
        public string EklemeZamani { get; set; }
        public string GuncellemeZamani { get; set; }
        public string GuncelleyenIP { get; set; }
        public string GuncelleyenBilgisi { get; set; }

        public virtual Cihaz Cihaz { get; set; }
    }
}