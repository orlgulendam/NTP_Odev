using System;


class Program
{
    static void Main()
    {
        // Bir öğrenci nesnesi oluştur
        ogrenci ogrenci1 = new ogrenci("Ali", 20);

        // Bir okul nesnesi oluştur
        Okul okul1 = new Okul("75.yıl mtka Lisesi", "İstanbul");

        // Öğrenciye okul bilgisi ekle
        ogrenci1.Okul_Ekle(okul1);

        // Öğrenci bilgilerini yazdır
        Console.WriteLine($"Öğrenci Adı: {ogrenci1.ad}");
        Console.WriteLine($"Yaşı: {ogrenci1.yas}");
        Console.WriteLine($"Okulu: {ogrenci1.Okul.ad}");
        Console.WriteLine($"Adres: {ogrenci1.Okul.adres}");
    }
}
class ogrenci
{
    public string ad { get; set; }
    public int yas { get; set; }
    public Okul Okul { get; set; }
    public ogrenci(string ad, int yas)
    {
        this.ad = ad;
        this.yas = yas;
    }
    public void  Okul_Ekle(Okul okul)
    {
        Okul = okul;
        
    }

}
class Okul
{
    public string ad { get; set; }
    public string adres { get; set; }
    public Okul(string ad,string adres)
    {
        this.ad = ad;
        this.adres = adres;
    }

}
