using System;

namespace MatematikselIslemler
{
    class Program
    {
        // İlk sürüm: İki tam sayıyı toplar
        public static int Topla(int a, int b)
        {
            return a + b;
        }

        // İkinci sürüm: Üç tam sayıyı toplar
        public static int Topla(int a, int b, int c)
        {
            return a + b + c;
        }

        // Üçüncü sürüm: Bir dizi tam sayıyı toplar
        public static int Topla(int[] sayilar)
        {
            int toplam = 0;
            foreach (int sayi in sayilar)
            {
                toplam += sayi;
            }
            return toplam;
        }

        static void Main(string[] args)
        {
            // İlk sürüm kullanımı
            int sonuc1 = Topla(5, 10);
            Console.WriteLine($"5 + 10 = {sonuc1}");

            // İkinci sürüm kullanımı
            int sonuc2 = Topla(3, 7, 2);
            Console.WriteLine($"3 + 7 + 2 = {sonuc2}");

            // Üçüncü sürüm kullanımı
            int[] dizi = { 1, 2, 3, 4, 5 };
            int sonuc3 = Topla(dizi);
            Console.WriteLine($"[1, 2, 3, 4, 5] toplamı = {sonuc3}");
        }
    }
}