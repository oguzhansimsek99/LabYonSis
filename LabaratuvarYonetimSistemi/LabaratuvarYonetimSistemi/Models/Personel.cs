﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LabaratuvarYonetimSistemi.Models
{
    public class Personel
    {
        [Key]
        public int PersonelID { get; set; }

        [MaxLength(50, ErrorMessage = "En fazla 50 karakterlik bilgi girişi yapabilirsiniz.")]
        [Required(ErrorMessage = "Boş Geçemezsiniz")]
        public string Ad { get; set; }

        [MaxLength(50, ErrorMessage = "En fazla 50 karakterlik bilgi girişi yapabilirsiniz.")]
        [Required(ErrorMessage = "Boş Geçemezsiniz")]
        public string Soyad { get; set; }

        [MaxLength(50, ErrorMessage = "En fazla 50 karakterlik bilgi girişi yapabilirsiniz.")]
        [Required(ErrorMessage = "Boş Geçemezsiniz")]
        public string SicilNo { get; set; }

        [MaxLength(100, ErrorMessage = "En fazla 100 karakterlik bilgi girişi yapabilirsiniz.")]
        public string Eposta { get; set; }

        [MaxLength(20, ErrorMessage = "En fazla 20 karakterlik bilgi girişi yapabilirsiniz.")]
        [Required(ErrorMessage = "Boş Geçemezsiniz")]
        public string Telefon { get; set; }

       

        public bool Aktif { get; set; }
        public string EklemeZamani { get; set; }
        public string GuncellemeZamani { get; set; }
        public string GuncelleyenIP { get; set; }
        public string GuncelleyenBilgisi { get; set; }

        public virtual ICollection<CihazPersonel> CihazPersonel { get; set; }
        public virtual ICollection<LabaratuvarPersonel> LabaratuvarPersonel { get; set; }
    }
}