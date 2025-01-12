using System;
using System.Collections.Specialized;

using System;

class Program
{
    static void Main()
    {
        // Departman oluştur
        departman departman1 = new departman("Bilgi Teknolojileri", "Ankara");

        // Çalışan oluştur
        calısan calisan1 = new calısan("Ahmet Yılmaz", "Yazılım Geliştirici");

        // Çalışana departman ekle
        calisan1.depart_ekle(departman1);

        // Çalışan ve departman bilgilerini yazdır
        Console.WriteLine($"Çalışan Adı: {calisan1.ad}");
        Console.WriteLine($"Pozisyon: {calisan1.pozisyon}");
        Console.WriteLine($"Departman: {calisan1.depart.ad}");
        Console.WriteLine($"Lokasyon: {calisan1.depart.lokasyon}");
    }
}

class calısan
{
    public string ad { get; set; }
    public string pozisyon { get; set; }
    public departman depart;
    public calısan()
    {

    }
    public calısan(string Ad,string pozisyon)
    {
        ad = Ad;
        this.pozisyon = pozisyon;

    }
    public void depart_ekle(departman depart)
    {
        this.depart = depart;

    }

}
class departman
{
    public string ad { get; set; }
    public string lokasyon { get; set; }
     public departman(string Ad,string Lokasyon)
    {
        ad = Ad;
        lokasyon = Lokasyon;
    }
}