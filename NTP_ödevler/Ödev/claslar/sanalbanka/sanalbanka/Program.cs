using System;

namespace BankaHesapYonetim
{
    // 1. Soyut Sınıf: Hesap
    public abstract class Hesap
    {
        public string HesapNo { get; set; }
        public decimal Bakiye { get; protected set; }

        public abstract void ParaYatir(decimal miktar);
        public abstract void ParaCek(decimal miktar);
    }

    // 3. Arayüz: IBankaHesabi
    public interface IBankaHesabi
    {
        DateTime HesapAcilisTarihi { get; set; }
        void HesapOzeti();
    }

    // 2. Türetilmiş Sınıf: BirikimHesabi
    public class BirikimHesabi : Hesap, IBankaHesabi
    {
        public decimal FaizOrani { get; set; }
        public DateTime HesapAcilisTarihi { get; set; }

        public BirikimHesabi(decimal faizOrani)
        {
            FaizOrani = faizOrani;
            HesapAcilisTarihi = DateTime.Now;
        }

        public override void ParaYatir(decimal miktar)
        {
            decimal faiz = miktar * FaizOrani / 100;
            Bakiye += miktar + faiz;
            Console.WriteLine($"Yatırılan miktar: {miktar:C}, Hesaplanan faiz: {faiz:C}, Yeni Bakiye: {Bakiye:C}");
        }

        public override void ParaCek(decimal miktar)
        {
            if (Bakiye >= miktar)
            {
                Bakiye -= miktar;
                Console.WriteLine($"Çekilen miktar: {miktar:C}, Kalan Bakiye: {Bakiye:C}");
            }
            else
            {
                Console.WriteLine("Yetersiz bakiye!");
            }
        }

        public void HesapOzeti()
        {
            Console.WriteLine($"Hesap No: {HesapNo}, Bakiye: {Bakiye:C}, Faiz Oranı: %{FaizOrani}, Açılış Tarihi: {HesapAcilisTarihi}");
        }
    }

    // 2. Türetilmiş Sınıf: VadesizHesap
    public class VadesizHesap : Hesap, IBankaHesabi
    {
        public decimal IslemUcreti { get; set; }
        public DateTime HesapAcilisTarihi { get; set; }

        public VadesizHesap(decimal islemUcreti)
        {
            IslemUcreti = islemUcreti;
            HesapAcilisTarihi = DateTime.Now;
        }

        public override void ParaYatir(decimal miktar)
        {
            Bakiye += miktar;
            Console.WriteLine($"Yatırılan miktar: {miktar:C}, Yeni Bakiye: {Bakiye:C}");
        }

        public override void ParaCek(decimal miktar)
        {
            decimal toplamCekilecek = miktar + IslemUcreti;
            if (Bakiye >= toplamCekilecek)
            {
                Bakiye -= toplamCekilecek;
                Console.WriteLine($"Çekilen miktar: {miktar:C}, İşlem Ücreti: {IslemUcreti:C}, Kalan Bakiye: {Bakiye:C}");
            }
            else
            {
                Console.WriteLine("Yetersiz bakiye!");
            }
        }

        public void HesapOzeti()
        {
            Console.WriteLine($"Hesap No: {HesapNo}, Bakiye: {Bakiye:C}, İşlem Ücreti: {IslemUcreti:C}, Açılış Tarihi: {HesapAcilisTarihi}");
        }
    }

    // Ana Program
    class Program
    {
        static void Main(string[] args)
        {
            // Birikim Hesabı oluşturma ve test etme
            BirikimHesabi birikimHesabi = new BirikimHesabi(5); // %5 faiz oranı
            birikimHesabi.HesapNo = "123456";
            birikimHesabi.ParaYatir(1000); // 1000 TL yatır
            birikimHesabi.ParaCek(500);   // 500 TL çek
            birikimHesabi.HesapOzeti();  // Hesap özetini yazdır

            Console.WriteLine();

            // Vadesiz Hesap oluşturma ve test etme
            VadesizHesap vadesizHesap = new VadesizHesap(10); // 10 TL işlem ücreti
            vadesizHesap.HesapNo = "789012";
            vadesizHesap.ParaYatir(2000); // 2000 TL yatır
            vadesizHesap.ParaCek(1000);   // 1000 TL çek
            vadesizHesap.HesapOzeti();  // Hesap özetini yazdır
        }
    }
}