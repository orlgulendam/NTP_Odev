using System;

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Kitap nesneleri oluştur
        kitap kitap1 = new kitap("Savaş ve Barış", "978-3-16-148410-0");
        kitap kitap2 = new kitap("Anna Karenina", "978-0-14-044917-4");

        // Kitapları bir listeye ekle
        List<kitap> kitapListesi = new List<kitap> { kitap1, kitap2 };

        // Yazar nesnesi oluştur
        Yazar yazar1 = new Yazar
        {
            ad = "Lev Tolstoy",
            ulke = "Rusya",
            kitaplar = "Dünya klasikleri arasında yer alan kitaplar"
        };

        // Yazara kitap listesini ekle
        yazar1.kitapekle(kitapListesi);

        // Yazar ve kitap bilgilerini yazdır
        Console.WriteLine($"Yazar: {yazar1.ad}");
        Console.WriteLine($"Ülke: {yazar1.ulke}");
        Console.WriteLine($"Kitaplar:");
        foreach (var kitap in yazar1.kitap)
        {
            Console.WriteLine($"  - Başlık: {kitap.başlık}, ISBN: {kitap.Isbm}");
        }
    }
}

class Yazar
{
    public string ad { get;set; }
    public string ulke { get; set; }
    public string kitaplar { get; set; }
    public List<kitap> kitap;

    public void kitapekle(List<kitap> kitap)
    {
        this.kitap = kitap;
    }

}
class kitap
{
    public string başlık { get; set; }

    public string Isbm { get; set; }
    
    public kitap(string başlık,string isbm)
    {
        this.başlık = başlık;
        Isbm = isbm;
    }
}
