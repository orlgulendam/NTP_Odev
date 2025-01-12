using System;

namespace HavaDurumuTahmini
{
    // Hava durumu tiplerini temsil eden enum
    public enum HavaDurumu
    {
        Sunny,   // Güneşli
        Rainy,   // Yağmurlu
        Cloudy,  // Bulutlu
        Stormy   // Fırtınalı
    }

    // Hava durumu tavsiye sınıfı
    public class HavaDurumuTavsiyeleri
    {
        // Verilen hava durumuna göre tavsiye döndüren metot
        public static string TavsiyeVer(HavaDurumu durum)
        {
            switch (durum)
            {
                case HavaDurumu.Sunny:
                    return "Hava güzel, dışarıda vakit geçirebilirsiniz.";

                case HavaDurumu.Rainy:
                    return "Yağmurlu bir gün, şemsiyenizi almayı unutmayın.";

                case HavaDurumu.Cloudy:
                    return "Bulutlu bir hava, yanınıza hafif bir ceket alabilirsiniz.";

                case HavaDurumu.Stormy:
                    return "Fırtınalı bir hava, mümkünse evde kalmaya çalışın.";

                default:
                    return "Bilinmeyen hava durumu!";
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Hava durumu tahminlerini test et
            Console.WriteLine($"Güneşli: {HavaDurumuTavsiyeleri.TavsiyeVer(HavaDurumu.Sunny)}");
            Console.WriteLine($"Yağmurlu: {HavaDurumuTavsiyeleri.TavsiyeVer(HavaDurumu.Rainy)}");
            Console.WriteLine($"Bulutlu: {HavaDurumuTavsiyeleri.TavsiyeVer(HavaDurumu.Cloudy)}");
            Console.WriteLine($"Fırtınalı: {HavaDurumuTavsiyeleri.TavsiyeVer(HavaDurumu.Stormy)}");
        }
    }
}