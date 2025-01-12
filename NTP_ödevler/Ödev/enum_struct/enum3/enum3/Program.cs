using System;

namespace CalisanRolleri
{
    // Çalışan rolleri için enum
    public enum CalisanRol
    {
        Manager,   // Yönetici
        Developer, // Geliştirici
        Designer,  // Tasarımcı
        Tester     // Test Uzmanı
    }

    // Maaş hesaplama sınıfı
    public class MaasHesaplama
    {
        // Rollere göre maaşı döndüren metot
        public static decimal MaasHesapla(CalisanRol rol)
        {
            switch (rol)
            {
                case CalisanRol.Manager:
                    return 15000; // Yönetici maaşı

                case CalisanRol.Developer:
                    return 12000; // Geliştirici maaşı

                case CalisanRol.Designer:
                    return 10000; // Tasarımcı maaşı

                case CalisanRol.Tester:
                    return 9000;  // Test Uzmanı maaşı

                default:
                    return 0; // Bilinmeyen rol
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Her rol için maaşı hesaplayıp yazdır
            Console.WriteLine($"Manager maaşı: {MaasHesaplama.MaasHesapla(CalisanRol.Manager):C}");
            Console.WriteLine($"Developer maaşı: {MaasHesaplama.MaasHesapla(CalisanRol.Developer):C}");
            Console.WriteLine($"Designer maaşı: {MaasHesaplama.MaasHesapla(CalisanRol.Designer):C}");
            Console.WriteLine($"Tester maaşı: {MaasHesaplama.MaasHesapla(CalisanRol.Tester):C}");
        }
    }
}