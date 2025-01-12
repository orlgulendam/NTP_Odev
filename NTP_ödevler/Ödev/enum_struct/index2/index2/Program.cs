using System;
using System.Collections.Generic;

namespace OgrenciNotSistemi
{
    class OgrenciNotlar
    {
        // Dersler ve notlar için bir sözlük (dictionary)
        private Dictionary<string, int> dersNotlari;

        // Yapıcı metot: Boş bir sözlük başlatılır
        public OgrenciNotlar()
        {
            dersNotlari = new Dictionary<string, int>();
        }

        // İndeksleyici: Ders adına göre notlara erişim sağlar
        public int this[string dersAdi]
        {
            get
            {
                if (dersNotlari.ContainsKey(dersAdi))
                {
                    return dersNotlari[dersAdi];
                }
                else
                {
                    Console.WriteLine($"Hata: {dersAdi} dersi bulunamadı.");
                    return -1; // Geçersiz bir değer döndürür
                }
            }
            set
            {
                if (dersNotlari.ContainsKey(dersAdi))
                {
                    dersNotlari[dersAdi] = value;
                    Console.WriteLine($"{dersAdi} dersinin notu güncellendi.");
                }
                else
                {
                    dersNotlari.Add(dersAdi, value);
                    Console.WriteLine($"{dersAdi} dersi ve notu eklendi.");
                }
            }
        }

        // Tüm dersleri ve notları listeleme metodu
        public void NotlariListele()
        {
            Console.WriteLine("Öğrenci Notları:");
            foreach (var ders in dersNotlari)
            {
                Console.WriteLine($"Ders: {ders.Key}, Not: {ders.Value}");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Öğrenci not sistemi oluştur
            OgrenciNotlar ogrenci = new OgrenciNotlar();

            // Ders ve not ekleme
            ogrenci["Matematik"] = 85;
            ogrenci["Fizik"] = 90;
            ogrenci["Kimya"] = 78;

            // Tüm notları listele
            ogrenci.NotlariListele();
            Console.WriteLine();

            // Bir dersin notunu öğren
            Console.WriteLine($"Matematik notu: {ogrenci["Matematik"]}");
            Console.WriteLine($"Tarih notu: {ogrenci["Tarih"]}"); // Hata mesajı verecek

            // Bir dersin notunu güncelle
            ogrenci["Fizik"] = 95;
            Console.WriteLine();

            // Tüm notları tekrar listele
            ogrenci.NotlariListele();
        }
    }
}