//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив
//1 4 7 2
//5 9 2 3
//8 4 2 4
//17 -> такого числа в массиве нет

int GetNum(string text)
{
    Console.WriteLine(text);
    return int.Parse(Console.ReadLine());
}

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

void ShowMatrix(int[,] Matrix, int NumberRowsPosition, int NumberColumnsPosition)
{
    int Rows = Matrix.GetLength(0);
    int Columns = Matrix.GetLength(1);
    for (int i = 0; i < Rows; i++)
    {
        for (int j = 0; j < Columns; j++)
        {
            Console.Write(Matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine($"{NumberRowsPosition}{NumberColumnsPosition} -> {Matrix[NumberRowsPosition, NumberColumnsPosition]}");
}
int NumberRowsPosition = GetNum("Введите адрес строки позиции в массиве: ");
int NumberColumnsPosition = GetNum("Введите адрес столбца позиции в массиве: ");

if (NumberRowsPosition > 2 || NumberColumnsPosition > 3)
{
    Console.WriteLine($"{NumberRowsPosition}{NumberColumnsPosition} -> такого числа в массиве нет");
}
else
{
    //Здесь первые 2 числа, мы сами устанавливаем размер матрицы, как в примере
    int[,] Matrix = GenerateMatrix(3, 4, 0, 10);

    ShowMatrix(Matrix, NumberRowsPosition, NumberColumnsPosition);
}