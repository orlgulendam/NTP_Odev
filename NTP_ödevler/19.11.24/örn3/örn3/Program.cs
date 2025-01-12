using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Doktor oluştur
        Doktor doktor1 = new Doktor("Dr. Ali", "Cardiyoloji");

        // Hasta oluştur
        hasta hasta1 = new hasta("Ahmet Yılmaz", "12345678901");
        hasta hasta2 = new hasta("Ayşe Demir", "98765432100");

        // Hastaları doktora ekle
        doktor1.hasta_ekle(hasta1);
        doktor1.hasta_ekle(hasta2);

        // Hastaların doktorlarını atama
        hasta1.Doktor_atama(doktor1);
        hasta2.Doktor_atama(doktor1);

        // Hastaların doktor bilgilerini yazdır
        Console.WriteLine($"{hasta1.Ad} adlı hastanın doktoru: {hasta1.doktor.Ad}");
        Console.WriteLine($"{hasta2.Ad} adlı hastanın doktoru: {hasta2.doktor.Ad}");

        // Doktorun hastalarını yazdır
        Console.WriteLine($"\n{doktor1.Ad} adlı doktorun hastaları:");
        foreach (var hasta in doktor1.hastalar)
        {
            Console.WriteLine($"- {hasta.Ad}");
        }
    }
}

class Doktor
{
    public string Ad { get; set; }
    public string Brans { get; set; }
    public List<hasta> hastalar { get; set; }
    public Doktor(string ad,string brans)
    {
        Ad = ad;
        Brans = brans;
        hastalar = new List<hasta>();
    }
    public void hasta_ekle(hasta hasta)
    {
        hastalar.Add(hasta);
    }
    
}
class hasta
{
    public string Ad { get; set; }
    public string tcno { get; set; }
    public Doktor doktor;
    public hasta(string ad, string tcno)
    {
        Ad = ad;
        this.tcno = tcno;
    }
    public void Doktor_atama(Doktor doktor)
    {
        this.doktor = doktor;
    }
}
