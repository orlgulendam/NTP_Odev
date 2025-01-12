using System;

namespace HayvanatBahcesi
{
    // Temel Sınıf: Hayvan
    public class Hayvan
    {
        public string Ad { get; set; }
        public string Tur { get; set; }
        public int Yas { get; set; }

        // Ses çıkarma metodu (virtual)
        public virtual void SesCikar()
        {
            Console.WriteLine("Hayvan ses çıkarıyor...");
        }

        // Hayvan bilgilerini yazdırma
        public virtual void BilgiYazdir()
        {
            Console.WriteLine($"Ad: {Ad}, Tür: {Tur}, Yaş: {Yas}");
        }
    }

    // Türetilmiş Sınıf: Memeli
    public class Memeli : Hayvan
    {
        public string TuyRengi { get; set; }

        // Override SesCikar metodu
        public override void SesCikar()
        {
            Console.WriteLine($"{Ad} memeli bir hayvandır ve ses çıkarıyor: 'Grrr!'");
        }

        // Override BilgiYazdir metodu
        public override void BilgiYazdir()
        {
            Console.WriteLine($"Ad: {Ad}, Tür: {Tur}, Yaş: {Yas}, Tüy Rengi: {TuyRengi}");
        }
    }

    // Türetilmiş Sınıf: Kuş
    public class Kus : Hayvan
    {
        public double KanatGenisligi { get; set; }

        // Override SesCikar metodu
        public override void SesCikar()
        {
            Console.WriteLine($"{Ad} bir kuştur ve ses çıkarıyor: 'Cik cik!'");
        }

        // Override BilgiYazdir metodu
        public override void BilgiYazdir()
        {
            Console.WriteLine($"Ad: {Ad}, Tür: {Tur}, Yaş: {Yas}, Kanat Genişliği: {KanatGenisligi} cm");
        }
    }

    // Ana Program
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hayvan türünü seçin (1: Memeli, 2: Kuş): ");
            string secim = Console.ReadLine();

            if (secim == "1")
            {
                Memeli memeli = new Memeli();
                Console.Write("Ad: ");
                memeli.Ad = Console.ReadLine();
                Console.Write("Tür: ");
                memeli.Tur = Console.ReadLine();
                Console.Write("Yaş: ");
                memeli.Yas = Convert.ToInt32(Console.ReadLine());
                Console.Write("Tüy Rengi: ");
                memeli.TuyRengi = Console.ReadLine();

                Console.WriteLine("\nMemeli Bilgileri:");
                memeli.BilgiYazdir();
                memeli.SesCikar();
            }
            else if (secim == "2")
            {
                Kus kus = new Kus();
                Console.Write("Ad: ");
                kus.Ad = Console.ReadLine();
                Console.Write("Tür: ");
                kus.Tur = Console.ReadLine();
                Console.Write("Yaş: ");
                kus.Yas = Convert.ToInt32(Console.ReadLine());
                Console.Write("Kanat Genişliği (cm): ");
                kus.KanatGenisligi = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("\nKuş Bilgileri:");
                kus.BilgiYazdir();
                kus.SesCikar();
            }
            else
            {
                Console.WriteLine("Geçersiz seçim yaptınız.");
            }
        }
    }
}
