// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
// которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)
void Main ()
{Console.Clear();
Console.Write("Введите количество строк (m) массива: "); int m = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов (n) массива: "); int n = int.Parse(Console.ReadLine());
Console.Write("Введите количество страниц (z) массива: "); int z = int.Parse(Console.ReadLine());
Console.WriteLine();
Console.Write("Далее программа потребует ввести элементы массива.");
Console.Write("!!!ВАЖНО!!! Ввести неповторяющихся двузначные числа");
Console.WriteLine();

int[,,] array = new int[z, m, n];

FillThreeDimArray(array);
Console.WriteLine($"Сгенерирован массив размером {m} x {n} x {z}: ");
PrintThreeDimArray(array);
Console.WriteLine();
Console.WriteLine("Нажмите Enter");
Console.Read();}

void FillThreeDimArray (int [,,] array) // метод заполнения трехмерного массива с клавиатуры
{for (int i = 0; i < array.GetLength(0); i++)
    {for (int j = 0; j < array.GetLength(1); j++)
        {for (int k = 0; k < array.GetLength(2); k++)
            {Console.Write($"Введите элемент массива под индексом ({i}, {j}, {k}): ");
                array[i, j, k] = int.Parse(Console.ReadLine());}}}}

void PrintThreeDimArray (int [,,] array) // метод печатает трехмерный массив
{for (int i = 0; i < array.GetLength(0); i++)
    {for (int j = 0; j < array.GetLength(1); j++)
        {for (int k = 0; k < array.GetLength(2); k++)
            {Console.Write(array[i, j, k]);Console.Write(($"({i}, {j}, {k})") + " ");}
            Console.WriteLine();} Console.WriteLine();}}

Main();