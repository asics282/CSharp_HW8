// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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

int [] SumStringArray (int [,] array) // метод считает сумму элементов каждой строки двумерного массива и возвращает одномерный массив, в котором элементы - это суммы строк двумерного массива
{int [] sum = new int[m]; // дополнительный одномерный массив, в котором элементы - это суммы строк двумерного массива
for (int i = 0; i < m; i++) 
{for (int j = 0; j < n; j++) {sum[i] += array[i, j];}}
return sum;}

SumStringArray (array);

void PrintMinSumString (int [] sum) // метод определяет минимальный элемент массива и показывает его индекс, который сооответствует строке двумерного массива
{int minValue = sum[0]; int index = 0;
for (int i = 1; i < sum.Length; i++) 
{if (minValue > sum[i]) {minValue = sum[i]; index = i;}}
Console.WriteLine("Номер строки с наименьшей суммой элементов: " + (index+1));}

PrintMinSumString(SumStringArray(array));

Console.WriteLine();
Console.WriteLine("Нажмите Enter");
Console.Read();