using System;

namespace GPSKonumMesafesi
{
    struct Konum
    {
        // Enlem ve Boylam Özellikleri
        public double Latitude { get; set; }  // Enlem
        public double Longitude { get; set; } // Boylam

        // Yapıcı Metot
        public Konum(double latitude, double longitude)
        {
            Latitude = latitude;
            Longitude = longitude;
        }

        // İki GPS konumu arasındaki mesafeyi kilometre olarak hesaplar
        public static double MesafeHesapla(Konum konum1, Konum konum2)
        {
            const double YARICAP = 6371; // Dünya'nın yarıçapı (km)

            // Radyan cinsine çevir
            double radian(double derece) => derece * Math.PI / 180;

            double lat1 = radian(konum1.Latitude);
            double lon1 = radian(konum1.Longitude);
            double lat2 = radian(konum2.Latitude);
            double lon2 = radian(konum2.Longitude);

            // Haversine Formülü
            double deltaLat = lat2 - lat1;
            double deltaLon = lon2 - lon1;

            double a = Math.Sin(deltaLat / 2) * Math.Sin(deltaLat / 2) +
                       Math.Cos(lat1) * Math.Cos(lat2) *
                       Math.Sin(deltaLon / 2) * Math.Sin(deltaLon / 2);

            double c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));

            return YARICAP * c; // Mesafe (km)
        }

        // ToString metodu: Konum bilgilerini okunabilir formatta döndürür
        public override string ToString()
        {
            return $"Enlem: {Latitude}, Boylam: {Longitude}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // İki GPS konumu oluştur
            Konum konum1 = new Konum(41.0082, 28.9784); // İstanbul
            Konum konum2 = new Konum(40.7128, -74.0060); // New York

            // Mesafeyi hesapla
            double mesafe = Konum.MesafeHesapla(konum1, konum2);

            // Sonuçları yazdır
            Console.WriteLine($"Konum 1: {konum1}");
            Console.WriteLine($"Konum 2: {konum2}");
            Console.WriteLine($"İki konum arasındaki mesafe: {mesafe:F2} km");
        }
    }
}