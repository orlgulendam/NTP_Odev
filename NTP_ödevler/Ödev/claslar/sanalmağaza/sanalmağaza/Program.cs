using System;
using System.Collections.Generic;

namespace MagazaYonetimSistemi
{
    // 1. Soyut Sınıf: Urun
    public abstract class Urun
    {
        public string Ad { get; set; }
        public decimal Fiyat { get; set; }

        // Soyut metot: HesaplaOdeme
        public abstract decimal HesaplaOdeme();

        // Virtual metot: BilgiYazdir
        public virtual void BilgiYazdir()
        {
            Console.WriteLine($"Ürün Adı: {Ad}, Fiyat: {Fiyat:C}");
        }
    }

    // 2. Türetilmiş Sınıf: Kitap
    public class Kitap : Urun
    {
        public string Yazar { get; set; }

        public override decimal HesaplaOdeme()
        {
            // Kitap için %10 vergi
            return Fiyat + (Fiyat * 0.10m);
        }

        public override void BilgiYazdir()
        {
            Console.WriteLine($"Kitap Adı: {Ad}, Yazar: {Yazar}, Fiyat: {Fiyat:C}, Ödenecek Tutar: {HesaplaOdeme():C}");
        }
    }

    // 2. Türetilmiş Sınıf: Elektronik
    public class Elektronik : Urun
    {
        public string Marka { get; set; }

        public override decimal HesaplaOdeme()
        {
            // Elektronik için %25 vergi
            return Fiyat + (Fiyat * 0.25m);
        }

        public override void BilgiYazdir()
        {
            Console.WriteLine($"Elektronik Ürün: {Ad}, Marka: {Marka}, Fiyat: {Fiyat:C}, Ödenecek Tutar: {HesaplaOdeme():C}");
        }
    }

    // Ana Program
    class Program
    {
        static void Main(string[] args)
        {
            // 4. Ürün Listesi Oluştur
            List<Urun> urunler = new List<Urun>();

            // Kitap ekle
            Kitap kitap1 = new Kitap
            {
                Ad = "C# Programlama",
                Fiyat = 100,
                Yazar = "Ahmet Yılmaz"
            };
            urunler.Add(kitap1);

            Kitap kitap2 = new Kitap
            {
                Ad = "Veri Yapıları",
                Fiyat = 150,
                Yazar = "Ayşe Demir"
            };
            urunler.Add(kitap2);

            // Elektronik ürün ekle
            Elektronik elektronik1 = new Elektronik
            {
                Ad = "Laptop",
                Fiyat = 5000,
                Marka = "Dell"
            };
            urunler.Add(elektronik1);

            Elektronik elektronik2 = new Elektronik
            {
                Ad = "Akıllı Telefon",
                Fiyat = 3000,
                Marka = "Samsung"
            };
            urunler.Add(elektronik2);

            // Ürün bilgilerini yazdır
            Console.WriteLine("Mağazadaki Ürünler:");
            foreach (Urun urun in urunler)
            {
                urun.BilgiYazdir();
                Console.WriteLine();
            }
        }
    }
}
