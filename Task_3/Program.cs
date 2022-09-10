// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

int n = 3, m = 4; 
double avg;
int[,] array = new int[n, m];


Random rand = new Random();

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        array[i, j] = rand.Next(10);
        Console.Write("{0} ", array[i, j]);
    }
    Console.WriteLine();
}
Console.WriteLine();
Console.Write("Среднее арифметическое каждого столбца: ");

for (int i = 0; i < m; i++)
{
    int sum = 0;

    for (int j = 0; j < n; j++)
    {
        sum += array[j, i];
    }
    avg = (double) sum / n;
    Console.Write("{0:f2} ", avg);
}