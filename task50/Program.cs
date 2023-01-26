/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
1, 7 -> такого элемента в массиве нет */

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

int[] EnterXY ()
{
    int[] xy = {0,0};
    Console.WriteLine("Введите Х");
    int x = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите Y");
    int y = Convert.ToInt32(Console.ReadLine());
    xy[0] = x;
    xy[1] = y;
    return xy;

}

void IsNumInMatrix(int[] xy, int[,] matrix)
{
  if (xy[0] > matrix.GetLength(0) || xy[1] > matrix.GetLength(1))
  Console.WriteLine("такого элемента в массиве нет");
  else
  {
     Console.WriteLine($"Элемент матрицы на позиции x{xy[0]}, y{xy[1]} = {matrix[xy[0], xy[1]]}");
  }

}

int[] enterXY = EnterXY();
//EnterXY ();

int[,] array2D = CreateMatrixRndInt(3, 4, -10, 10);
PrintMatrix(array2D);

IsNumInMatrix(enterXY, array2D);
