using System;

namespace KitaplikYonetim
{
    class Kitaplik
    {
        // Kitap koleksiyonunu tutan bir dizi
        private string[] kitaplar;

        // Yapıcı metot: Kitaplık başlatılırken kapasitesi belirlenir
        public Kitaplik(int kapasite)
        {
            kitaplar = new string[kapasite];
            for (int i = 0; i < kapasite; i++)
            {
                kitaplar[i] = $"Kitap {i + 1}"; // Varsayılan kitap adları
            }
        }

        // İndeksleyici
        public string this[int indeks]
        {
            get
            {
                if (indeks >= 0 && indeks < kitaplar.Length)
                {
                    return kitaplar[indeks];
                }
                else
                {
                    return "Geçersiz indeks! Bu indekste bir kitap bulunmuyor.";
                }
            }
            set
            {
                if (indeks >= 0 && indeks < kitaplar.Length)
                {
                    kitaplar[indeks] = value;
                }
                else
                {
                    Console.WriteLine("Geçersiz indeks! Bu indekste bir kitap güncellenemez.");
                }
            }
        }

        // Kitaplık bilgilerini listeleme metodu
        public void KitaplariListele()
        {
            Console.WriteLine("Kitaplık Koleksiyonu:");
            for (int i = 0; i < kitaplar.Length; i++)
            {
                Console.WriteLine($"İndeks {i}: {kitaplar[i]}");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Kitaplık oluştur
            Kitaplik kitaplik = new Kitaplik(5); // 5 kitap kapasiteli kitaplık

            // Kitapları listele
            kitaplik.KitaplariListele();
            Console.WriteLine();

            // Belirli bir indeksteki kitabı öğren
            Console.WriteLine($"İndeks 2'deki kitap: {kitaplik[2]}");

            // Bir kitabın adını değiştir
            kitaplik[2] = "C# Programlama"; // İndeks 2'deki kitap adı güncelleniyor
            Console.WriteLine($"İndeks 2'deki güncellenmiş kitap: {kitaplik[2]}");
            Console.WriteLine();

            // Geçersiz bir indekse erişim
            Console.WriteLine(kitaplik[10]); // Hata mesajı dönecek

            // Kitapları tekrar listele
            kitaplik.KitaplariListele();
        }
    }
}