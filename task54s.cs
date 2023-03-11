// Задача 54: Задайте двумерный массив. Напишите программу,
// которая упорядочит по убыванию элементы
// каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


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
            matrix[i, j] = new Random().Next(min, max+1);
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

void Change(int[,] matrix)
{
    // int lastMaxIndex = 0;
    int changeNumber = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int maxIndex = 0; maxIndex < matrix.GetLength(1); maxIndex++)
            {

                if (matrix[i, j] > matrix[i, maxIndex])
                {
                    // 1 4 7 2
                    // 1 4 7 2
                    // 4 1 7 2
                    changeNumber = matrix[i, maxIndex];
                    matrix[i, maxIndex] = matrix[i, j];
                    matrix[i, j] = changeNumber;

                }
                
            }
        }
    }
   
}







int[,] matrix = CreateMatrix();
PrintMatrix(matrix);
Change(matrix);
System.Console.WriteLine("");
PrintMatrix(matrix);