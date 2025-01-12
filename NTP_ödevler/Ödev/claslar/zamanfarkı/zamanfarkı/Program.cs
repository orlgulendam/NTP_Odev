using System;

namespace TarihFarkHesaplama
{
    class Program
    {
        // İlk sürüm: Gün cinsinden farkı hesaplar
        public static int TarihFarkHesapla(DateTime tarih1, DateTime tarih2)
        {
            TimeSpan fark = tarih2 - tarih1;
            return Math.Abs(fark.Days); // Mutlak değer, negatif farkları önlemek için
        }

        // İkinci sürüm: Saat cinsinden farkı hesaplar
        public static double TarihFarkHesapla(DateTime tarih1, DateTime tarih2, bool saatCinsinden)
        {
            TimeSpan fark = tarih2 - tarih1;
            return Math.Abs(fark.TotalHours); // Saat cinsinden toplam fark
        }

        // Üçüncü sürüm: Yıl, ay ve gün cinsinden farkı hesaplar
        public static void TarihFarkHesapla(DateTime tarih1, DateTime tarih2, out int yil, out int ay, out int gun)
        {
            // Tarihleri sıralı hale getir
            if (tarih1 > tarih2)
            {
                DateTime temp = tarih1;
                tarih1 = tarih2;
                tarih2 = temp;
            }

            yil = tarih2.Year - tarih1.Year;
            ay = tarih2.Month - tarih1.Month;
            gun = tarih2.Day - tarih1.Day;

            if (gun < 0)
            {
                ay--;
                gun += DateTime.DaysInMonth(tarih1.Year, tarih1.Month);
            }

            if (ay < 0)
            {
                yil--;
                ay += 12;
            }
        }

        static void Main(string[] args)
        {
            DateTime tarih1 = new DateTime(2020, 5, 15);
            DateTime tarih2 = new DateTime(2023, 8, 25);

            // İlk sürüm: Gün cinsinden fark
            int gunFarki = TarihFarkHesapla(tarih1, tarih2);
            Console.WriteLine($"İki tarih arasındaki gün farkı: {gunFarki} gün");

            // İkinci sürüm: Saat cinsinden fark
            double saatFarki = TarihFarkHesapla(tarih1, tarih2, true);
            Console.WriteLine($"İki tarih arasındaki saat farkı: {saatFarki:N2} saat");

            // Üçüncü sürüm: Yıl, ay ve gün cinsinden fark
            TarihFarkHesapla(tarih1, tarih2, out int yil, out int ay, out int gun);
            Console.WriteLine($"İki tarih arasındaki fark: {yil} yıl, {ay} ay, {gun} gün");
        }
    }
}