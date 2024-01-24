using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace LabaratuvarYonetimSistemi.Models
{
    public class Context : DbContext
    {
        public Context() : base("LabDB")
        {

        }
        public DbSet<Birim> Birim { get; set; }
        public DbSet<Cihaz> Cihaz { get; set; }
        public DbSet<CihazPersonel> CihazPersonel { get; set; }
        public DbSet<CihazResim> CihazResim { get; set; }
        public DbSet<CihazTuru> CihazTuru { get; set; }
        public DbSet<Kullanici> Kullanici { get; set; }
        public DbSet<Labaratuvar> Labaratuvar { get; set; }
        public DbSet<LabaratuvarCihaz> LabaratuvarCihaz { get; set; }
        public DbSet<LabaratuvarPersonel> LabaratuvarPersonel { get; set; }
        public DbSet<LabaratuvarTest> LabaratuvarTest { get; set; }
        public DbSet<LabaratuvarYazilim> LabaratuvarYazilim { get; set; }
        public DbSet<Log> Log { get; set; }
        public DbSet<Marka> Marka { get; set; }
        public DbSet<Parametre> Parametre { get; set; }
        public DbSet<ParametreEposta> ParametreEposta { get; set; }
        public DbSet<ParolaIstek> ParolaIstek { get; set; }
        public DbSet<Personel> Personel { get; set; }
        public DbSet<Test> Test { get; set; }
        public DbSet<Yazilim> Yazilim { get; set; }
        public DbSet<Ziyaretci> Ziyaretci { get; set; }
    }
}