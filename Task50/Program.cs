// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает 
// значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
int [,] array = new int [5, 6];
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 6; j++)
    {
        array [i, j] = new Random().Next(1, 10);
    }
}
Console.WriteLine("Введите номер строки и столбца");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
if (m > 5 || n > 6)
    Console.WriteLine("Такого числа нет");
else
    Console.WriteLine(array[m, n]);