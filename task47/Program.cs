/********************************************************

Задача 47
Задайте двумерный массив размером m×n, заполненный 
случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9

********************************************************/


int ReadInt(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

double[,] GenerateMatrix(int rows, int cols, double leftRange, double rightRange)
{
    double[,] matrix = new double[rows, cols];
    Random rand = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Math.Round(rand.NextDouble() * (rightRange - leftRange) + leftRange, 1); 
            // как я понял, NextDouble возвращает значение [0.0, 1.0), но округление позволяет получить [0, 1].
            // Чем больше знаков после запятой, тем меньше вероятность получить rightRange.
        } 
    }
    return matrix;
}

void PrintMatrix(double[,] matrix)
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


int m = ReadInt("Укажите количество строк матрицы: ");
int n = ReadInt("Укажите количество столбцов матрицы: ");
double[,] myMatrix = GenerateMatrix(m, n, -9, 9);
PrintMatrix(myMatrix);