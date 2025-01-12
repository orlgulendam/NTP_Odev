using System;
class Program
{
    static void Main()
    {
        // Bilgisayar nesnesi oluşturuluyor
        bilgisaray bilgisayar1 = new bilgisaray("Lenovo ThinkPad");

        // Bilgisayarın işlemci bilgisini yazdır
        Console.WriteLine($"Bilgisayar Modeli: {bilgisayar1.model}");
        bilgisayar1.islemci.islemcibilgisi(); // İşlemci bilgisi yazdırılır
    }
}
class bilgisaray
{
   public string model { get; set; }
   public islemci islemci { get; set; }

    public bilgisaray(string model)
    {
        this.model = model;
        islemci = new islemci(10,20);
    }

}
class islemci
{
    public int cekirdekler { get; set; }
    public int frekans { get; set; }

    public islemci(int cedirdekler,int frekasn)
    {
        this.cekirdekler = cedirdekler;
        this.frekans = frekasn;

    }
    public void islemcibilgisi()
    {
        Console.WriteLine($"c{cekirdekler}f{frekans}");
    }
    
}