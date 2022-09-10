// Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными 
// (тип double) числами.

int n = 3, m = 3;

Random rnd = new Random();

double[,] array = new double[n, m];

Console.WriteLine($"Матрица {n}x{m}");

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        array[i, j] = rnd.NextDouble() * 100;
        Console.Write("{0:F2} ", array[i,j]);
    }
    Console.WriteLine();
}