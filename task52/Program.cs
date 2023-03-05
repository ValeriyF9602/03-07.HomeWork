/*********************************************************

Задача 52
Задайте двумерный массив из целых чисел. Найдите 
среднее арифметическое элементов в каждом столбце.

Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4

Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

*********************************************************/


int ReadInt(string text) // приглашение ко вводу
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GenerateMatrix(int rows, int cols, int leftRange, int rightRange) // генерация матрицы целых чисел
{
    int[,] matrix = new int[rows, cols];
    Random rand = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(leftRange, rightRange + 1);
        } 
    }

    return matrix;
}

void PrintMatrix(int[,] matrix) // вывод матрицы в консоль
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + "\t");
        }

        Console.WriteLine();
    }
}

void ArithmeticMeanOfColumns(int[,] matrix) // Определение среднего арифметического каждого столбца
{
    int sumColumn;
    Console.WriteLine("Среднее арифметическое каждого столбца:");

    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        sumColumn = 0; // обнуляем результат суммирования, заходя на новый столбец

        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            sumColumn += matrix[j, i]; // суммируем все элементы столбца
        }

        Console.Write(Math.Round((double)sumColumn / matrix.GetLength(0), 2) + "\t"); // результат суммирования переводим в double и делим на количество строк
    }

    Console.WriteLine();
}


int m = ReadInt("Укажите количество строк матрицы: ");
int n = ReadInt("Укажите количество столбцов матрицы: ");

int[,] myMatrix = GenerateMatrix(m, n, -9, 9);

PrintMatrix(myMatrix);
ArithmeticMeanOfColumns(myMatrix);