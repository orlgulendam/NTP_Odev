using System;

class Program
{
    // Asal sayı kontrolü yapan fonksiyon
    static bool AsalMi(int sayi)
    {
        if (sayi <= 1)
            return false;

        for (int i = 2; i * i <= sayi; i++)
        {
            if (sayi % i == 0)
                return false;
        }

        return true;
    }

    static void Main()
    {
        // Kullanıcıdan N sayısını al
        Console.Write("N sayısını giriniz: ");
        int n;
        while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
        {
            Console.WriteLine("Geçersiz giriş. Lütfen pozitif bir tam sayı giriniz.");
        }

        int toplam = 0;

        // 2'den N'ye kadar olan asal sayıları topla
        for (int i = 2; i <= n; i++)
        {
            if (AsalMi(i))
            {
                toplam += i;
            }
        }

        // Sonucu ekrana yazdır
        Console.WriteLine($"1'den {n}'ye kadar olan asal sayıların toplamı: {toplam}");
    }
}