using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Management.Instrumentation;
using System.Web;

namespace PROJECTTRACKING.Models.Personel
{
    public class PersonelBilgileri
    {
        [Key]
        public int PersonelBilgileriId { get; set; }
        [DisplayName("E-POSTA")]
        public string Eposta  { get; set; }
        [DisplayName("ŞİFRE")]
        [StringLength(25,ErrorMessage ="Maksimum uzunluk 25 karakterden fazla olamaz.")]
        public string Sifre { get; set; }
        [DisplayName("YETKİ")]
        [StringLength(15, ErrorMessage = "Maksimum uzunluk 15 karakterden fazla olamaz.")]
        public string Yetki { get; set; }
        [DisplayName("AD SOYAD")]
        [StringLength(50, ErrorMessage = "Maksimum uzunluk 50 karakterden fazla olamaz.")]
        public string AdSoyad { get; set; }
        [DisplayName("TC KİMLİK NO")]
        [StringLength(11, ErrorMessage = "Maksimum uzunluk 11 karakterden fazla olamaz.")]
        public string TCNO { get; set; }
        [DisplayName("DEPARTMANI")]
        [StringLength(25, ErrorMessage = "Maksimum uzunluk 25 karakterden fazla olamaz.")]
        public string Departman { get; set; }
        [DisplayName("GOREVİ")]
        [StringLength(25, ErrorMessage = "Maksimum uzunluk 25 karakterden fazla olamaz.")]
        public string Gorev { get; set; }
        [DisplayName("AÇIKLAMA")]
        public string PozisyonAciklama { get; set; }
        [DisplayName("TELEFON NUMARASI")]
        [StringLength(15, ErrorMessage = "Maksimum uzunluk 15 karakterden fazla olamaz.")]
        public string TelNo { get; set; }
        [DisplayName("ADRES BİLGİLERİ")]
        public string Adres { get; set; }
        [DisplayName("MEDENİ HAL")]
        public string MedeniHal { get; set; }
        [DisplayName("YAKINLIK BİLGİSİ")]
        [StringLength(25, ErrorMessage = "Maksimum uzunluk 25 karakterden fazla olamaz.")]
        public string YakinBilgi { get; set; }
        [DisplayName("YAKIN TC NO")]
        [StringLength(11, ErrorMessage = "Maksimum uzunluk 11 karakterden fazla olamaz.")]
        public string YakinTC { get; set; }
        [DisplayName("YAKIN AD SOYAD")]
        [StringLength(25, ErrorMessage = "Maksimum uzunluk 25 karakterden fazla olamaz.")]
        public string YakinAdSoyad { get; set; }
        [DisplayName("YAKIN TEL")]
        [StringLength(15, ErrorMessage = "Maksimum uzunluk 15 karakterden fazla olamaz.")]
        public string YakinTel { get; set; }
        [DisplayName("DOĞUM TARİHİ")]
        public DateTime DogumTarihi { get; set; }
        [DisplayName("İŞE GİRİŞ TARİHİ")]
        public DateTime? İseGirisTarihi { get; set; }



    }
}