using System;

namespace TrafikIsigi
{
    // Trafik ışığı durumlarını temsil eden enum
    public enum TrafikDurumu
    {
        Red,    // Kırmızı
        Yellow, // Sarı
        Green   // Yeşil
    }

    // Trafik ışığı sınıfı
    public class TrafikIsigi
    {
        // Verilen trafik durumu için yapılması gerekeni döndüren metot
        public static string DurumKontrol(TrafikDurumu durum)
        {
            switch (durum)
            {
                case TrafikDurumu.Red:
                    return "Dur! Güvenli bir şekilde bekle.";

                case TrafikDurumu.Yellow:
                    return "Hazırlan! Durmaya veya hareket etmeye hazır ol.";

                case TrafikDurumu.Green:
                    return "Geç! Hareket edebilirsin.";

                default:
                    return "Bilinmeyen trafik durumu!";
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Trafik durumlarını test et
            Console.WriteLine($"Kırmızı ışık: {TrafikIsigi.DurumKontrol(TrafikDurumu.Red)}");
            Console.WriteLine($"Sarı ışık: {TrafikIsigi.DurumKontrol(TrafikDurumu.Yellow)}");
            Console.WriteLine($"Yeşil ışık: {TrafikIsigi.DurumKontrol(TrafikDurumu.Green)}");
        }
    }
}