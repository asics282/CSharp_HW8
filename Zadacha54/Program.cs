// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.Clear();
Console.Write("Введите количество строк (m) массива: "); int m = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов (n) массива: "); int n = int.Parse(Console.ReadLine());
Console.WriteLine();

int[,] array = new int[m, n];

void FillRandomTwoDimArray (int [,] array) // метод задает заполнения двумерного массива случайными целыми числами
{for (int i = 0; i < m; i++)
{for (int j = 0; j < n; j++) {array[i, j] = new Random().Next(0, 10);}}}

void PrintTwoDimArray (int [,] array) // метод печатает двумерный массив
{for (int i = 0; i < m; i++)
{for (int j = 0; j < n; j++) {Console.Write(array[i, j] + " ");} Console.WriteLine();}}

FillRandomTwoDimArray(array);
Console.WriteLine($"Сгенерирован массив на {m} строк(и) и {n} слобца(ов):");
PrintTwoDimArray(array);

void SortArray (int [,] array) // метод сортирует строки двумерного массива по убыванию
{for (int k = 0; k < m; k++) {for (int i = 0; i < n; i++) {for (int j = n - 1; j > i; j--)
{if (array[k,j] > array[k,j-1]) {int a = array[k,j]; array[k,j] = array[k,j-1]; array[k,j-1] = a;}}}}}

SortArray(array);
Console.WriteLine("Массив, в котором упорядочены по убыванию элементы каждой строки");
PrintTwoDimArray(array);
Console.WriteLine();
Console.WriteLine("Нажмите Enter");
Console.Read();