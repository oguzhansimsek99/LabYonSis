using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LabaratuvarYonetimSistemi.Models
{
    public class Cihaz
    {
        [Key]
        public int CihazID { get; set; }

        [MaxLength(100, ErrorMessage = "En fazla 100 karakterlik bilgi girişi yapabilirsiniz.")]
        [Required(ErrorMessage = "Boş Geçemezsiniz")]
        public string CihazAd { get; set; }

        public int MarkaID { get; set; }

        [MaxLength(100, ErrorMessage = "En fazla 100 karakterlik bilgi girişi yapabilirsiniz.")]
        public string Model { get; set; }
        public int CihazTuruID { get; set; }

        [MaxLength(50, ErrorMessage = "En fazla 50 karakterlik bilgi girişi yapabilirsiniz.")]
        public string KBSKodu { get; set; }

        [MaxLength(1000, ErrorMessage = "En fazla 1000 karakterlik bilgi girişi yapabilirsiniz.")]
        public string Aciklama { get; set; }
        public bool Aktif { get; set; }
        public string EklemeZamani { get; set; }
        public string GuncellemeZamani { get; set; }
        public string GuncelleyenIP { get; set; }
        public string GuncelleyenBilgisi { get; set; }

        public virtual Marka Marka { get; set; }
        public virtual CihazTuru CihazTuru { get; set; }
        public virtual ICollection<CihazPersonel> CihazPersonel { get; set; }
        public virtual ICollection<CihazResim> CihazResim { get; set; }
        public virtual ICollection<LabaratuvarCihaz> LabaratuvarCihaz { get; set; }

    }
}