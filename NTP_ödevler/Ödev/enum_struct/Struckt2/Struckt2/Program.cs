using System;

namespace KarmasikSayiHesaplama
{
    struct KarmasikSayi
    {
        // Gerçek ve Sanal kısımlar
        public double Real { get; set; }
        public double Imaginary { get; set; }

        // Yapıcı metot
        public KarmasikSayi(double real, double imaginary)
        {
            Real = real;
            Imaginary = imaginary;
        }

        // Toplama işlemi
        public static KarmasikSayi Topla(KarmasikSayi sayi1, KarmasikSayi sayi2)
        {
            return new KarmasikSayi(sayi1.Real + sayi2.Real, sayi1.Imaginary + sayi2.Imaginary);
        }

        // Çıkarma işlemi
        public static KarmasikSayi Cikar(KarmasikSayi sayi1, KarmasikSayi sayi2)
        {
            return new KarmasikSayi(sayi1.Real - sayi2.Real, sayi1.Imaginary - sayi2.Imaginary);
        }

        // Karmaşık sayıyı (a + bi) formatında döndürür
        public override string ToString()
        {
            if (Imaginary >= 0)
                return $"{Real} + {Imaginary}i";
            else
                return $"{Real} - {Math.Abs(Imaginary)}i";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Karmaşık sayılar oluştur
            KarmasikSayi sayi1 = new KarmasikSayi(3, 4);  // 3 + 4i
            KarmasikSayi sayi2 = new KarmasikSayi(1, -2); // 1 - 2i

            // Toplama işlemi
            KarmasikSayi toplam = KarmasikSayi.Topla(sayi1, sayi2);
            Console.WriteLine($"{sayi1} + {sayi2} = {toplam}");

            // Çıkarma işlemi
            KarmasikSayi fark = KarmasikSayi.Cikar(sayi1, sayi2);
            Console.WriteLine($"{sayi1} - {sayi2} = {fark}");
        }
    }
}