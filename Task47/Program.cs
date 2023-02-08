//Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9

int GetNum(string text)
{
    Console.WriteLine(text);
    return int.Parse(Console.ReadLine());
}

double[,] GenerateMatrix(int Rows, int Columns, double LowerBound, double UpperBound)
{
    double[,] Result = new double[Rows, Columns];
    for (int i = 0; i < Rows; i++)
    {
        for (int j = 0; j < Columns; j++)
        {
            Result[i, j] = Math.Round(LowerBound + (UpperBound - LowerBound) * new Random().NextDouble(), 1); //UpperBound - LowerBound для масштабирования
        }
    }
    return Result;
}

void ShowMatrix(double[,] matrix)
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

}

int NumberRows = GetNum("Введите количество строк в массиве: ");
int NumberColumns = GetNum("Введите количество столбцов в массиве: ");

double[,] Matrix = GenerateMatrix(NumberRows, NumberColumns, -10, 10);

ShowMatrix(Matrix);