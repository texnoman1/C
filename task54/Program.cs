/* Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2 */

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns]; // 0, 1
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++) // 2
    {
        for (int j = 0; j < matrix.GetLength(1); j++) //
        {
            matrix[i, j] = rnd.Next(min, max + 1); // 2 - 3 100, 1000
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],5},");
            else Console.Write($"{matrix[i, j],5} ");
        }
        Console.WriteLine("]");
    }
}



void AvgInString(int[,] matrix)
{
    int temp = 0;
    //int max =  matrix [0, 0];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            for (int k = 0; k < matrix.GetLength(1) - j- 1; k++)
            {

                if (matrix[i, k] < matrix[i, k + 1])
                {
                    temp = matrix[i, k];
                    (matrix[i, k]) = (matrix[i, k + 1]);
                    matrix[i, k + 1] = temp;
                }
            }
        }
      
   }
     
  
}



int[,] array2D = CreateMatrixRndInt(3, 4, -10, 10);
PrintMatrix(array2D);

AvgInString(array2D);
Console.WriteLine();
Console.WriteLine("Исходная матрица со строками упорядоченными по убыванию:");
PrintMatrix(array2D);
