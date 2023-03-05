/********************************************************

Задача 50
Напишите программу, которая на вход принимает позиции 
элемента в двумерном массиве, и возвращает значение 
этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4

1 7 -> такого числа в массиве нет

********************************************************/



int ReadInt(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

double[,] GenerateMatrix(double leftRange, double rightRange) // В условии задачи НЕ указан тип чисел в матрице
{
    Random rand = new Random();
    double[,] matrix = new double[rand.Next(2, 7), rand.Next(2, 7)]; // задаём случайный размер матрицы

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Math.Round(rand.NextDouble() * (rightRange - leftRange) + leftRange, 2);
        }
    }
    return matrix;
}

void PrintMatrix(double[,] matrix) // вывод матрицы в консоль
{
    for (int i = 0; i < matrix.GetLength(1); i++) // добавляем нумерацию столбцов
    {
        Console.Write("\t" + $"({i})");
    }

    Console.WriteLine();
    Console.WriteLine(); // делаем отступ от номеров столбцов

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write($"({i}):" + "\t"); // добавляем нумерацию строк 

        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + "\t");
        }

        Console.WriteLine();
    }
}

void FindElement(double[,] matrix, int row, int col)
{
    if (row < 0
        || row >= matrix.GetLength(0)
        || col < 0
        || col >= matrix.GetLength(1))
    {
        Console.WriteLine("Указаны неверные значения!");
    }
    else
    {
        Console.WriteLine($"A({row}, {col}) = {matrix[row, col]}");
    }
}


double[,] myMatrix = GenerateMatrix(-9, 9); // указываем только минимальный и максимальный элементы матрицы
PrintMatrix(myMatrix);
int m = ReadInt("Укажите строку матрицы: ");
int n = ReadInt("Укажите столбец матрицы: ");
FindElement(myMatrix, m, n);