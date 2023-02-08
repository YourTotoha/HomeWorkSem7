//Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] GenerateMatrix(int Rows, int Columns, int LowerBound, int UpperBound)
{
    int[,] Result = new int[Rows, Columns];
    for (int i = 0; i < Rows; i++)
    {
        for (int j = 0; j < Columns; j++)
        {
            Result[i, j] = new Random().Next(LowerBound, UpperBound + 1);
        }
    }
    return Result;
}

void ShowMatrix(int[,] matrix)
{
    int Rows = matrix.GetLength(0);
    int Columns = matrix.GetLength(1);
    for (int i = 0; i < Rows; i++)
    {
        for (int j = 0; j < Columns; j++)
        {
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
    Console.Write("Среднее арифметическое каждого столбца: ");
    for (int j = 0; j < Columns; j++)
    {
        double SumColumn = 0;
        double AverageColumn = 0;
        for (int i = 0; i < Rows; i++)
        {
            SumColumn = SumColumn + matrix[i, j];
            AverageColumn = Math.Round(SumColumn / 3, 1);
        }
        Console.Write($"{AverageColumn}; ");
    }
}

int[,] Matrix = GenerateMatrix(3, 4, 0, 10);

ShowMatrix(Matrix);