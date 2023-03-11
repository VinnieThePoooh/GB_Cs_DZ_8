// Задача 56: Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить
// строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер 
// строки с наименьшей суммой элементов: 1 строка

int[,] CreateMatrix()
{
    System.Console.WriteLine("Введите колличество строк");
    int rows = Convert.ToInt32(Console.ReadLine());

    System.Console.WriteLine("Введите колличество столбцов");
    int colums = Convert.ToInt32(Console.ReadLine());

    System.Console.WriteLine("Введите минимальное значение");
    int min = Convert.ToInt32(Console.ReadLine());

    System.Console.WriteLine("Введите максимальное значение");
    int max = Convert.ToInt32(Console.ReadLine());

    int[,] matrix = new int[rows, colums];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(min, max + 1);
        }
    }

    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i, j] + "  ");
        }
        System.Console.WriteLine("");
    }
}

void FindMinSumRows(int[,] matrix)
{
    int minSumRowNumber = 0;
    int minSumRow = 0;
    int SumRow = 0;

    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        minSumRow += matrix[0, j];
    }
    System.Console.WriteLine($"Cумма членов {1} строки равна {minSumRow}");



    for (int i = 1; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            SumRow += matrix[i, j];
        }
        System.Console.WriteLine($"Cумма членов {i+1} строки равна {SumRow}");

        if (SumRow < minSumRow)
        {
            minSumRowNumber = i;
            minSumRow = SumRow;
        }
        SumRow = 0;
    }
    System.Console.WriteLine("");
    System.Console.WriteLine($"Наименьшая сумма элементов в строке {minSumRowNumber + 1}");
}

int[,] matrix = CreateMatrix();
PrintMatrix(matrix);
System.Console.WriteLine("");
FindMinSumRows(matrix);