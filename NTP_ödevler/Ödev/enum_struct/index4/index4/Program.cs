using System;

namespace OtoparkSistemi
{
    class Otopark
    {
        // Otopark katları ve park yerlerini temsil eden 2D dizi
        private string[,] parkYerleri;

        // Yapıcı metot: Kat ve park yeri sayısına göre otopark oluşturur
        public Otopark(int katSayisi, int parkYeriSayisi)
        {
            parkYerleri = new string[katSayisi, parkYeriSayisi];

            // Tüm park yerlerini "Empty" olarak başlat
            for (int kat = 0; kat < katSayisi; kat++)
            {
                for (int yer = 0; yer < parkYeriSayisi; yer++)
                {
                    parkYerleri[kat, yer] = "Boş";
                }
            }
        }

        // İndeksleyici: Belirli bir kat ve park yeri kombinasyonuna erişim sağlar
        public string this[int kat, int parkYeri]
        {
            get
            {
                if (IsValid(kat, parkYeri))
                {
                    return parkYerleri[kat, parkYeri];
                }
                else
                {
                    return "Hata: Geçersiz park yeri!";
                }
            }
            set
            {
                if (IsValid(kat, parkYeri))
                {
                    if (value == "Boş" || IsPlateValid(value))
                    {
                        parkYerleri[kat, parkYeri] = value;
                        Console.WriteLine($"({kat}, {parkYeri}) park yerine '{value}' yerleştirildi.");
                    }
                    else
                    {
                        Console.WriteLine("Hata: Geçersiz plaka formatı!");
                    }
                }
                else
                {
                    Console.WriteLine("Hata: Geçersiz park yeri!");
                }
            }
        }

        // Park yeri geçerlilik kontrolü
        private bool IsValid(int kat, int parkYeri)
        {
            return kat >= 0 && kat < parkYerleri.GetLength(0) && parkYeri >= 0 && parkYeri < parkYerleri.GetLength(1);
        }

        // Plaka formatı geçerlilik kontrolü (örneğin: ABC-123 formatında olmalı)
        private bool IsPlateValid(string plate)
        {
            return plate.Length > 0; // Basit kontrol, daha karmaşık kontrol eklenebilir
        }

        // Tüm otopark durumunu listeleme metodu
        public void OtoparkDurumunuYazdir()
        {
            Console.WriteLine("Otopark Durumu:");
            for (int kat = 0; kat < parkYerleri.GetLength(0); kat++)
            {
                Console.Write($"Kat {kat}: ");
                for (int yer = 0; yer < parkYerleri.GetLength(1); yer++)
                {
                    Console.Write($"{parkYerleri[kat, yer],-10} ");
                }
                Console.WriteLine();
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // 3 katlı ve her katta 5 park yeri olan bir otopark oluştur
            Otopark otopark = new Otopark(3, 5);

            // Otopark durumunu yazdır
            otopark.OtoparkDurumunuYazdir();
            Console.WriteLine();

            // Araç yerleştir
            otopark[0, 0] = "ABC-123"; // Kat 0, Park Yeri 0
            otopark[1, 2] = "DEF-456"; // Kat 1, Park Yeri 2
            otopark[2, 4] = "GHI-789"; // Kat 2, Park Yeri 4

            // Geçersiz park yerine erişim
            Console.WriteLine(otopark[3, 0]); // Hata mesajı verir
            otopark[0, 5] = "JKL-111";       // Hata mesajı verir

            // Otopark durumunu tekrar yazdır
            Console.WriteLine();
            otopark.OtoparkDurumunuYazdir();

            // Park yerini boşalt
            otopark[0, 0] = "Boş"; // Kat 0, Park Yeri 0 boşaltılır

            // Otopark durumunu tekrar yazdır
            Console.WriteLine();
            otopark.OtoparkDurumunuYazdir();
        }
    }
}