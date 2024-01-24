using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LabaratuvarYonetimSistemi.Models
{
    public class Labaratuvar
    {
        [Key]
        public int LabaratuvarID { get; set; }

        [MaxLength(100, ErrorMessage = "En fazla 100 karakterlik bilgi girişi yapabilirsiniz.")]
        [Required(ErrorMessage = "Boş Geçemezsiniz")]
        public string Ad { get; set; }


        public int BirimID { get; set; }



        [MaxLength(100, ErrorMessage = "En fazla 100 karakterlik bilgi girişi yapabilirsiniz.")]
        public string Eposta { get; set; }


        [MaxLength(20, ErrorMessage = "En fazla 20 karakterlik bilgi girişi yapabilirsiniz.")]
        [Required(ErrorMessage = "Boş Geçemezsiniz")]
        public string Telefon { get; set; }


        [MaxLength(200, ErrorMessage = "En fazla 200 karakterlik bilgi girişi yapabilirsiniz.")]
        public string Web { get; set; }


        [MaxLength(200, ErrorMessage = "En fazla 200 karakterlik bilgi girişi yapabilirsiniz.")]
        public string Adres { get; set; }

        public bool Aktif { get; set; }
        public string EklemeZamani { get; set; }
        public string GuncellemeZamani { get; set; }
        public string GuncelleyenIP { get; set; }
        public string GuncelleyenBilgisi { get; set; }

        public virtual Birim Birim { get; set; }

        public virtual ICollection<LabaratuvarTest> LabaratuvarTest { get; set; }
        public virtual ICollection<LabaratuvarCihaz> LabaratuvarCihaz { get; set; }
        public virtual ICollection<LabaratuvarYazilim> LabaratuvarYazilim { get; set; }
        public virtual ICollection<LabaratuvarPersonel> LabaratuvarPersonel { get; set; }
    }
}