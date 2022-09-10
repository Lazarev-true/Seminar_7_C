// Напишите программу, которая на вход принимает позиции 
// (две) элемента в двумерном массиве, и возвращает значение 
// этого элемента или же указание, что такого элемента нет.

int n = 10, m = 10;
Random rnd = new Random();
int[,] array = new int[n, m];

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        array[i, j] = rnd.Next(100);
        Console.Write("{0} ", array[i, j]);
}
    Console.WriteLine();
}

Console.WriteLine($"Введите позицию элемента (2 цифры через пробел) в массиве {n}x{m}");

string numbers = Console.ReadLine();
string[] num = numbers.Split(" ");

int k = Convert.ToInt32(num[0]),
    l = Convert.ToInt32(num[1]);

if(k >= n || l >= m)
{
    Console.Write($"({k}, {l}) -> Такого элемента нет");
}
else
Console.Write($"({k}, {l}) -> {array[k, l]}");