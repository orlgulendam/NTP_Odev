using System;
using System.Net.Sockets;
class Program
{
    static void Main()
    {
        // Şirket oluştur
        sirket sirket1 = new sirket("ABC Teknoloji","müdür");

        // Çalışanlar oluştur
        calisan calisan1 = new calisan("Ali", "Yazılım Geliştirici");
        calisan calisan2 = new calisan("Ayşe", "Veri Analisti");

        // Çalışanları şirkete ekle
        sirket1.CalisanEkle(calisan1);
        sirket1.CalisanEkle(calisan2);

   
    }
}
class calisan
{
    public string Ad { get; set; }
    public string pozisyon { get; set; }

    public calisan(string ad, string pozisyon)
    {
        Ad = ad;
        this.pozisyon = pozisyon;

    }
    public void CalısanBilgisi()
    {
        Console.WriteLine($"calısn Ad:{Ad} calosan pozisyon {pozisyon}");
    }
}
class sirket
{
    public string Ad { get; set; }
    public List<calisan> calısanlar { get; set; }


    public sirket(string ad , string pozisyon)
    {
        Ad = ad;
        calısanlar = new List<calisan>();

    }
   public void CalisanEkle(calisan calıs)
    {
        calısanlar.Add(calıs);
    }
}