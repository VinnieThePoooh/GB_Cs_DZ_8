// Задача 58: Задайте две матрицы. Напишите программу, которая будет
// находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

int[,] CreateNextMatrix(int[,] matrix1)
{
    System.Console.WriteLine("Введите минимальное значение второй матрицы");
    int min = Convert.ToInt32(Console.ReadLine());

    System.Console.WriteLine("Введите максимальное значение второй матрицы");
    int max = Convert.ToInt32(Console.ReadLine());

    int[,] matrix2 = new int[matrix1.GetLength(1), matrix1.GetLength(0)];

    for (int i = 0; i < matrix2.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            matrix2[i, j] = new Random().Next(min, max + 1);
        }
    }

    return matrix2;
}

int[,] Multiplication(int[,] matrix1, int[,] matrix2)
{
    int w = 0;
    int i = 0;
    int sum = 0;
    int[,] multiMatrix = new int[matrix1.GetLength(0), matrix1.GetLength(0)];
    // новая матрица заполняется поэлементно через простой вложенный фор.
    // сперва [i,j]*[j,i] [i,j]*[j,i+1]
    //        [i+1,j]*[j,i] [i+1,j]*[j,i+1]

    // может быть нужны два отдельных цикла фор для заполнения мультиматрицы

    for (int q = 0; q < matrix1.GetLength(0); q++)//multimatrix i
    {
        while (w < matrix1.GetLength(0))
        {
            while (i < matrix1.GetLength(0))
            {
                // for (int i = q; i < matrix1.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix1.GetLength(0); j++)
                    {
                        sum += matrix1[i, j] * matrix2[j, i];
                    }
                    multiMatrix[w, q] = sum;
                    sum = 0;
                    w++;

                }
                i++;
            }
            i = 0;
        }

        w = 0;
    }
    return multiMatrix;

}





int[,] matrix1 = CreateMatrix();
int[,] matrix2 = CreateNextMatrix(matrix1);
System.Console.WriteLine("");
PrintMatrix(matrix1);
System.Console.WriteLine("");
PrintMatrix(matrix2);
int[,] multimatrix = Multiplication(matrix1, matrix2);
System.Console.WriteLine("Барабанная дробь");
PrintMatrix(multimatrix);