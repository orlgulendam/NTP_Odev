using System;

namespace SatrancTahtasi
{
    class Tahta
    {
        // Satranç tahtası (8x8) için 2D dizi
        private string[,] tahtadakiTaslar;

        // Yapıcı metot: Boş bir tahta oluşturur
        public Tahta()
        {
            tahtadakiTaslar = new string[8, 8];

            // Tahtayı boş olarak başlat
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    tahtadakiTaslar[i, j] = "Boş";
                }
            }
        }

        // İndeksleyici: Bir kareye erişim sağlar
        public string this[int satir, int sutun]
        {
            get
            {
                if (satir >= 0 && satir < 8 && sutun >= 0 && sutun < 8)
                {
                    return tahtadakiTaslar[satir, sutun];
                }
                else
                {
                    return "Hata: Geçersiz kare!";
                }
            }
            set
            {
                if (satir >= 0 && satir < 8 && sutun >= 0 && sutun < 8)
                {
                    tahtadakiTaslar[satir, sutun] = value;
                    Console.WriteLine($"Taş '{value}' kareye ({satir}, {sutun}) yerleştirildi.");
                }
                else
                {
                    Console.WriteLine("Hata: Geçersiz kare! Bu kareye taş yerleştirilemez.");
                }
            }
        }

        // Tahtayı ekrana yazdırma metodu
        public void TahtayiYazdir()
        {
            Console.WriteLine("Satranç Tahtası:");
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Console.Write($"{tahtadakiTaslar[i, j],-10} ");
                }
                Console.WriteLine();
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Satranç tahtası oluştur
            Tahta tahta = new Tahta();

            // Tahtayı ekrana yazdır
            tahta.TahtayiYazdir();
            Console.WriteLine();

            // Bir taş yerleştir
            tahta[0, 0] = "Kale";
            tahta[1, 4] = "At";
            tahta[7, 7] = "Şah";

            // Bir taşın ne olduğunu öğren
            Console.WriteLine($"(0, 0) karesindeki taş: {tahta[0, 0]}");
            Console.WriteLine($"(7, 7) karesindeki taş: {tahta[7, 7]}");
            Console.WriteLine($"(3, 3) karesindeki taş: {tahta[3, 3]}"); // Boş

            // Geçersiz karelere erişim
            Console.WriteLine(tahta[8, 8]); // Hata mesajı verecek
            tahta[10, 10] = "Piyon"; // Hata mesajı verecek

            // Tahtayı tekrar yazdır
            Console.WriteLine();
            tahta.TahtayiYazdir();
        }
    }
}