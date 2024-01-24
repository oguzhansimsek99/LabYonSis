using LabaratuvarYonetimSistemi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;

namespace LabaratuvarYonetimSistemi.Fonksiyonlar
{
    public class Ziyaretci_Log
    {
        Context db = new Context();
        public void ZiyaretciEkle(Kullanici gelenKayit, string ipAdresi)
        {
            Ziyaretci z = new Ziyaretci();
            z.KullaniciNo = gelenKayit.KullaniciID;
            z.KullaniciAd = gelenKayit.KullaniciAd;
            z.Ad = gelenKayit.Ad;
            z.Soyad = gelenKayit.Soyad;
            z.SicilNo = gelenKayit.SicilNo;
            z.KullaniciTuru = gelenKayit.KullaniciTuru;
            z.GirisIP = ipAdresi;
            z.GirisZamani = DateTime.Now.ToString();
            db.Ziyaretci.Add(z);
            db.SaveChanges();
        }
    }
}