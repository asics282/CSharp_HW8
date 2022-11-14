// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

Console.Clear();
Console.WriteLine("Квадратная матрица размерностью 4х4, записанная по спирали");
Console.WriteLine();

int n = 4; //количество строк двумерного массива
int m = 4; //количество столбцов двумерного массива
int[,] array = new int[n, m];

void FillHelix(int[,] array) // метод получения квадратной матрицы, записанной по спирали
{int temp = 1; int i = 0; int j = 0;
    while (temp <= m * n)
    {array[i, j] = temp;
    temp++;
    if (i <= j + 1 && i + j < m - 1) j++;
    else if (i < j && i + j >= n - 1) i++;
    else if (i >= j && i + j > m - 1) j--;
    else i--;}}

void PrintTwoDimArray (int [,] array) // метод красиво печатает квадратную матрицу, записанную по спирали
{for (int i = 0; i < m; i++)
{for (int j = 0; j < n; j++)
{if (array[i, j] < 10) {Console.Write($"0{array[i, j]} ");} else {Console.Write(array[i, j] + " ");}} 
Console.WriteLine();}}

FillHelix(array);
PrintTwoDimArray(array);

Console.WriteLine();
Console.WriteLine("Для завершения работы программы нажмите Enter");
Console.Read();