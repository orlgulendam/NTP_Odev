using System;

namespace ZamanIslemleri
{
    struct Zaman
    {
        // Saat ve dakika özellikleri
        private int hour;
        private int minute;

        public int Hour
        {
            get => hour;
            set => hour = (value >= 0 && value < 24) ? value : 0; // Geçersiz saat 0 yapılır
        }

        public int Minute
        {
            get => minute;
            set => minute = (value >= 0 && value < 60) ? value : 0; // Geçersiz dakika 0 yapılır
        }

        // Yapıcı metot
        public Zaman(int hour, int minute)
        {
            this.hour = (hour >= 0 && hour < 24) ? hour : 0; // Geçersiz saat 0 yapılır
            this.minute = (minute >= 0 && minute < 60) ? minute : 0; // Geçersiz dakika 0 yapılır
        }

        // Zamanın toplam dakika değerini döndürür
        public int ToplamDakika()
        {
            return hour * 60 + minute;
        }

        // İki zaman arasındaki dakika farkını hesaplar
        public static int FarkHesapla(Zaman zaman1, Zaman zaman2)
        {
            int dakika1 = zaman1.ToplamDakika();
            int dakika2 = zaman2.ToplamDakika();
            return Math.Abs(dakika1 - dakika2); // Mutlak değer alır
        }

        // Zamanı okunabilir formatta yazdırır
        public override string ToString()
        {
            return $"{hour:D2}:{minute:D2}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Zaman nesnesi oluşturma
            Zaman zaman1 = new Zaman(14, 30);
            Zaman zaman2 = new Zaman(9, 45);
            Zaman zaman3 = new Zaman(25, 70); // Geçersiz değerler

            // Zamanların toplam dakikasını yazdır
            Console.WriteLine($"Zaman 1: {zaman1}, Toplam Dakika: {zaman1.ToplamDakika()}");
            Console.WriteLine($"Zaman 2: {zaman2}, Toplam Dakika: {zaman2.ToplamDakika()}");
            Console.WriteLine($"Zaman 3: {zaman3}, Toplam Dakika: {zaman3.ToplamDakika()}");

            // İki zaman arasındaki farkı hesapla
            int fark = Zaman.FarkHesapla(zaman1, zaman2);
            Console.WriteLine($"Zaman 1 ve Zaman 2 arasındaki fark: {fark} dakika");
        }
    }
}