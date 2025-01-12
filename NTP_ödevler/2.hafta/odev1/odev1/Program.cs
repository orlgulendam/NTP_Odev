using System;

class Program
{
    static void Main()
    {
        int n;
        Console.Write("Matris boyutunu giriniz (NxN): ");
        while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
        {
            Console.WriteLine("Geçersiz giriş. Lütfen pozitif bir tam sayı giriniz.");
        }

        int[,] spiralMatris = new int[n, n];
        int deger = 1;
        int sol = 0, sag = n - 1, ust = 0, alt = n - 1;

        while (sol <= sag && ust <= alt)
        {
            // Üstten sola doğru
            for (int i = sol; i <= sag; i++)
            {
                spiralMatris[ust, i] = deger++;
            }
            ust++;

            // Sağdan aşağıya doğru
            for (int i = ust; i <= alt; i++)
            {
                spiralMatris[i, sag] = deger++;
            }
            sag--;

            // Alttan sağa doğru
            if (ust <= alt)
            {
                for (int i = sag; i >= sol; i--)
                {
                    spiralMatris[alt, i] = deger++;
                }
                alt--;
            }

            // Soldan yukarıya doğru
            if (sol <= sag)
            {
                for (int i = alt; i >= ust; i--)
                {
                    spiralMatris[i, sol] = deger++;
                }
                sol++;
            }
        }

        // Matrisi yazdırma
        Console.WriteLine("Spiral matris:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(spiralMatris[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}