using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LabaratuvarYonetimSistemi.Models
{
    public class ParametreEposta
    {
        [Key]
        public int ParametreID { get; set; }
        [MaxLength(200, ErrorMessage = "En fazla 200 karakterlik bilgi girişi yapabilirsiniz.")]
        [Required(ErrorMessage = "Boş Geçemezsiniz")]
        public string MailUsername { get; set; }

        [MaxLength(200, ErrorMessage = "En fazla 200 karakterlik bilgi girişi yapabilirsiniz.")]
        [Required(ErrorMessage = "Boş Geçemezsiniz")]
        public string MailPassword { get; set; }

        [MaxLength(200, ErrorMessage = "En fazla 200 karakterlik bilgi girişi yapabilirsiniz.")]
        [Required(ErrorMessage = "Boş Geçemezsiniz")]
        public string MailSmptpHost { get; set; }

        [MaxLength(200, ErrorMessage = "En fazla 200 karakterlik bilgi girişi yapabilirsiniz.")]
        [Required(ErrorMessage = "Boş Geçemezsiniz")]
        public string MailSmptpPort { get; set; }

        [MaxLength(200, ErrorMessage = "En fazla 200 karakterlik bilgi girişi yapabilirsiniz.")]
        [Required(ErrorMessage = "Boş Geçemezsiniz")]
        public string MailSmptpAuth { get; set; }

        [MaxLength(200, ErrorMessage = "En fazla 200 karakterlik bilgi girişi yapabilirsiniz.")]
        [Required(ErrorMessage = "Boş Geçemezsiniz")]
        public string MailSmptpStartTLSEnable { get; set; }

        [MaxLength(200, ErrorMessage = "En fazla 200 karakterlik bilgi girişi yapabilirsiniz.")]
        [Required(ErrorMessage = "Boş Geçemezsiniz")]
        public string MailSmptSSLProtokol { get; set; }
        public bool Aktif { get; set; }
        public string EklemeZamani { get; set; }
        public string GuncellemeZamani { get; set; }
        public string GuncelleyenIP { get; set; }
        public string GuncelleyenBilgisi { get; set; }
    }
}