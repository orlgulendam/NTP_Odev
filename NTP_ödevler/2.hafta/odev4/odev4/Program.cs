using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ödev4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] grid = {
            { 1, 1, 0, 1 },
            { 0, 1, 0, 0 },
            { 1, 1, 1, 0 },
            { 0, 0, 1, 1 }
        };

            // Robot başlangıç pozisyonları  
            List<Tuple<int, int>> robotStartPositions = new List<Tuple<int, int>>
        {
            Tuple.Create(0, 0), // Robot 1  
            Tuple.Create(2, 2), // Robot 2  
            Tuple.Create(3, 3)  // Robot 3  
        };

            int totalSavedNodes = CountSavedNodes(grid, robotStartPositions);
            Console.WriteLine($"Toplam kurtarılan düğüm sayısı: {totalSavedNodes}");
            Console.ReadLine();
        }

        static int CountSavedNodes(int[,] grid, List<Tuple<int, int>> robotStartPositions)
        {
            int rows = grid.GetLength(0);
            int cols = grid.GetLength(1);
            bool[,] visited = new bool[rows, cols];
            int totalSaved = 0;

            foreach (var start in robotStartPositions)
            {
                int row = start.Item1;
                int col = start.Item2;

                totalSaved += SaveNodes(grid, visited, row, col);
            }

            return totalSaved;
        }

        static int SaveNodes(int[,] grid, bool[,] visited, int row, int col)
        {
            if (row < 0 || row >= grid.GetLength(0) || col < 0 || col >= grid.GetLength(1))
                return 0; // Dışarı çıkıldı  
            if (grid[row, col] == 0 || visited[row, col])
                return 0; // Zarar görmüş ya da zaten ziyaret edilmiş  

            // Düğüm kurtarıldı  
            visited[row, col] = true;
            int savedCount = 1; // Bu düğüm kurtarıldı  

            // Komşu düğümlere git  
            savedCount += SaveNodes(grid, visited, row + 1, col); // Aşağı  
            savedCount += SaveNodes(grid, visited, row - 1, col); // Yukarı  
            savedCount += SaveNodes(grid, visited, row, col + 1); // Sağa  
            savedCount += SaveNodes(grid, visited, row, col - 1); // Sola  

            return savedCount;
        }
    }
}