using System;
using System.Collections.Generic;

namespace ObserverPattern
{
    // 1. IYayinci Arayüzü
    public interface IYayinci
    {
        void AboneEkle(IAbone abone);
        void AboneCikar(IAbone abone);
        void Bildir(string mesaj);
    }

    // 1. IAbone Arayüzü
    public interface IAbone
    {
        void BilgiAl(string mesaj);
    }

    // 2. Yayinci Sınıfı
    public class Yayinci : IYayinci
    {
        private readonly List<IAbone> aboneler;

        public Yayinci()
        {
            aboneler = new List<IAbone>();
        }

        public void AboneEkle(IAbone abone)
        {
            aboneler.Add(abone);
            Console.WriteLine("Yeni bir abone eklendi.");
        }

        public void AboneCikar(IAbone abone)
        {
            aboneler.Remove(abone);
            Console.WriteLine("Bir abone çıkarıldı.");
        }

        public void Bildir(string mesaj)
        {
            Console.WriteLine($"Yayıncı mesaj gönderiyor: {mesaj}");
            foreach (var abone in aboneler)
            {
                abone.BilgiAl(mesaj);
            }
        }
    }

    // 3. Abone Sınıfı
    public class Abone : IAbone
    {
        public string Ad { get; set; }

        public Abone(string ad)
        {
            Ad = ad;
        }

        public void BilgiAl(string mesaj)
        {
            Console.WriteLine($"{Ad} adlı aboneye mesaj iletildi: {mesaj}");
        }
    }

    // 4. Ana Program
    class Program
    {
        static void Main(string[] args)
        {
            // Yayıncı oluştur
            Yayinci yayinci = new Yayinci();

            // Aboneler oluştur
            Abone abone1 = new Abone("Ahmet");
            Abone abone2 = new Abone("Ayşe");
            Abone abone3 = new Abone("Fatma");

            // Aboneleri ekle
            yayinci.AboneEkle(abone1);
            yayinci.AboneEkle(abone2);
            yayinci.AboneEkle(abone3);

            // Yayıncıdan bir mesaj bildir
            yayinci.Bildir("Yeni bir makale yayınlandı!");

            // Bir aboneyi çıkar
            yayinci.AboneCikar(abone2);

            // Yayıncıdan ikinci mesaj bildir
            yayinci.Bildir("Haftalık haber bülteni yayınlandı!");
        }
    }
}
