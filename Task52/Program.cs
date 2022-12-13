// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3
int [,] array = new int [5, 6];
string result = "";
int Sum = 0;
int column = 0;
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array [i, j] = new Random().Next(1, 10);
        Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
}
while (column < 6)
{
    for (int k = 0; k < 5; k++)
    {
        Sum += array[k, column];
    }
    double Average = Sum / 5.0;
    result += Average + " ";
    column++;
    Sum = 0;
}
Console.WriteLine();
Console.WriteLine(result);