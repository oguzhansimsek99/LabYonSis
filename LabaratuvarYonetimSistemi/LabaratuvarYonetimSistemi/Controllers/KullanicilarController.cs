using LabaratuvarYonetimSistemi.Fonksiyonlar;
using LabaratuvarYonetimSistemi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Web;
using System.Web.Mvc;

namespace LabaratuvarYonetimSistemi.Controllers
{
    public class KullanicilarController : Controller
    {
        Context db = new Context();
        Md5Pw md5 = new Md5Pw();
        Ziyaretci_Log Ziyaretci_Log = new Ziyaretci_Log();
        public ActionResult Index()
        {
            Session["tur"] = 1;
            Session["name"] = "oğuzhan";

            //if (Session["id"] == null) return RedirectToAction("Giris");
            return View();
        }
        public ActionResult IndexAra()
        {
            Session["tur"] = 1;
            Session["name"] = "oğuzhan";

            //if (Session["id"] == null) return RedirectToAction("Giris");
            return View();
        }


        public ActionResult Giris()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Giris(Kullanici p)
        {
            p.KullaniciParolasi = md5.MD5(p.KullaniciParolasi);
            var gelenKayit = db.Kullanici.Where(x => x.KullaniciAd == p.KullaniciAd && x.KullaniciParolasi == p.KullaniciParolasi && x.Aktif == true).FirstOrDefault();
            if (gelenKayit != null)
            {
                string bilgisayarAdi = Dns.GetHostName();
                string ipAdresi = Dns.GetHostByName(bilgisayarAdi).AddressList[0].ToString();
                Session["id"] = gelenKayit.KullaniciID;
                Session["name"] = gelenKayit.Ad;
                Session["soyad"] = gelenKayit.Soyad;
                Session["tur"] = gelenKayit.KullaniciTuru;

                // ZİYARETÇİ TABLOSUNA EKLEME
                //Ziyaretci z = new Ziyaretci();
                //z.KullaniciNo = gelenKayit.KullaniciID;
                //z.KullaniciAd = gelenKayit.KullaniciAd;
                //z.Ad = gelenKayit.Ad;
                //z.Soyad = gelenKayit.Soyad;
                //z.SicilNo = gelenKayit.SicilNo;
                //z.KullaniciTuru = gelenKayit.KullaniciTuru;
                //z.GirisIP = ipAdresi;
                //z.GirisZamani = DateTime.Now.ToString();
                //db.Ziyaretci.Add(z);
                //db.SaveChanges();

                Ziyaretci_Log.ZiyaretciEkle(gelenKayit, ipAdresi);


                return RedirectToAction("Index");
            }
            else
            {
                TempData["message"] = "Kullanıcı adı veya şifre hatalı";
                TempData["icon"] = "error";
                return View();
            }
        }


        public PartialViewResult FormKullanici()
        {
            return PartialView();
        }
        public PartialViewResult FormKullaniciDuzenle()
        {
            var kullaniciListesi = db.Kullanici.ToList();
            return PartialView(kullaniciListesi);
        }
        public PartialViewResult Ara()
        {
            return PartialView();
        }
        public PartialViewResult Tablo()
        {
            var kullaniciListesi = db.Kullanici.ToList();
            return PartialView(kullaniciListesi);
        }
        public PartialViewResult TabloAra()
        {

            return PartialView();
        }


        [HttpPost]
        public ActionResult KullaniciEkle(Kullanici p)
        {
            string bilgisayarAdi = Dns.GetHostName();
            string ipAdresi = Dns.GetHostByName(bilgisayarAdi).AddressList[0].ToString();
            p.KullaniciParolasi = md5.MD5(p.KullaniciParolasi);
            p.EklemeZamani = DateTime.Now.ToString();
            p.GuncellemeZamani = DateTime.Now.ToString();
            p.GuncelleyenIP = ipAdresi;
            p.GuncelleyenBilgisi = Session["id"].ToString() + " - " + Session["name"] + " " + Session["soyad"];
            db.Kullanici.Add(p);
            db.SaveChanges();
            TempData["message"] = "İşlem Başarılı";
            TempData["icon"] = "success";
            return RedirectToAction("Index");
        }
        [HttpPost]
        public ActionResult KullaniciGuncelle(Kullanici p)
        {
            string bilgisayarAdi = Dns.GetHostName();
            string ipAdresi = Dns.GetHostByName(bilgisayarAdi).AddressList[0].ToString();
            var gelenKayit = db.Kullanici.Find(p.KullaniciID);
            gelenKayit.KullaniciAd = p.KullaniciAd;
            gelenKayit.Ad = p.Ad;
            gelenKayit.Soyad = p.Soyad;
            gelenKayit.SicilNo = p.SicilNo;
            gelenKayit.Eposta = p.Eposta;
            gelenKayit.Telefon = p.Telefon;
            gelenKayit.KullaniciTuru = p.KullaniciTuru;
            gelenKayit.Aktif = p.Aktif;
            gelenKayit.GuncellemeZamani = DateTime.Now.ToString();
            gelenKayit.GuncelleyenIP = ipAdresi;
            gelenKayit.GuncelleyenBilgisi = Session["id"].ToString() + " - " + Session["name"] + " " + Session["soyad"];
            db.SaveChanges();
            TempData["message"] = "İşlem Başarılı";
            TempData["icon"] = "success";
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult Sil(int id)
        {
            var gelenKayit = db.Kullanici.Find(id);
            db.Kullanici.Remove(gelenKayit);
            db.SaveChanges();
            TempData["message"] = "İşlem Başarılı";
            TempData["icon"] = "success";
            return RedirectToAction("Index");
        }
        [HttpPost]
        public ActionResult KullaniciAra(Kullanici p)
        {
            if (p.KullaniciAd == null) p.KullaniciAd = "";
            if (p.Ad == null) p.Ad = "";
            if (p.Soyad == null) p.Soyad = "";
            if (p.SicilNo == null) p.SicilNo = "";
            if (p.Eposta == null) p.Eposta = "";
            if (p.Telefon == null) p.Telefon = "";
            var kullanicilar = db.Kullanici.ToList();
            List<Kullanici> arananListe = new List<Kullanici>();
            if (p.KullaniciTuru != 0)
                arananListe = kullanicilar.Where(i => i.KullaniciAd.Contains(p.KullaniciAd) && i.Ad.Contains(p.Ad) &&
                i.Soyad.Contains(p.Soyad) && i.SicilNo.Contains(p.SicilNo) &&
                i.Eposta.Contains(p.Eposta) && i.Telefon.Contains(p.Telefon) && i.KullaniciTuru == p.KullaniciTuru
                && i.Aktif == p.Aktif).ToList();
            else
                arananListe = kullanicilar.Where(i => i.KullaniciAd.Contains(p.KullaniciAd) && i.Ad.Contains(p.Ad) &&
                i.Soyad.Contains(p.Soyad) && i.SicilNo.Contains(p.SicilNo) &&
                i.Eposta.Contains(p.Eposta) && i.Telefon.Contains(p.Telefon)
                && i.Aktif == p.Aktif).ToList();


            
            TempData["liste"] = arananListe;
            TempData["model"] = p;
            return RedirectToAction("IndexAra");
        }

        public ActionResult AktiflikAyari(int id)
        {
            var gelenKayit = db.Kullanici.Find(id);
            if (gelenKayit.Aktif)
                gelenKayit.Aktif = false;

            else gelenKayit.Aktif = true;
            db.SaveChanges();
            TempData["message"] = "İşlem Başarılı";
            TempData["icon"] = "success";
            return RedirectToAction("Index");
        }
    }
}