// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.Clear();
Console.Write("Введите количество строк (m) массива: "); int m = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов (n) массива: "); int n = int.Parse(Console.ReadLine());
Console.WriteLine();

int[,] array1 = new int[m, n];
int[,] array2 = new int[m, n];

void FillRandomTwoDimArray (int [,] array) // метод задает заполнения двумерного массива случайными целыми числами
{for (int i = 0; i < m; i++)
{for (int j = 0; j < n; j++) {array[i, j] = new Random().Next(0, 10);}}}

void PrintTwoDimArray (int [,] array) // метод печатает двумерный массив
{for (int i = 0; i < m; i++)
{for (int j = 0; j < n; j++) {Console.Write(array[i, j] + " ");} Console.WriteLine();}}

FillRandomTwoDimArray(array1);
FillRandomTwoDimArray(array2);

Console.WriteLine($"Сгенерирована матрица №1 на {m} строк(и) и {n} слобца(ов):");
PrintTwoDimArray(array1);
Console.WriteLine();
Console.WriteLine($"Сгенерирована матрица №2 на {m} строк(и) и {n} слобца(ов):");
PrintTwoDimArray(array2);

int[,] MatrixMultiplication(int[,] array1, int[,] array2, int m, int n) //метод умножает одну матрицу на другую
{var array3 = new int[m, n];
for (int i = 0; i < m; i++)
{for (int j = 0; j < n; j++) {array3[i, j] = 0; for (int k = 0; k < m; k++) {array3[i, j] += array1[i, k] * array2[k, j];}}}
return array3;}

Console.WriteLine();
Console.WriteLine("Произведение матриц:");
PrintTwoDimArray(MatrixMultiplication(array1, array2, m, n)); // печать результата умножения матриц

Console.WriteLine();
Console.WriteLine("Нажмите Enter");
Console.Read();