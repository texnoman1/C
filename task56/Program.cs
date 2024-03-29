﻿/* Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка */

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



int[] SumNumInStrings(int[,] matrix)
{
    int [] arr = new int [matrix.GetLength(0)];
    int sum = 0;
    //int max =  matrix [0, 0];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
           sum += matrix[i, j];
        }
       arr[i] = sum;
       sum = 0;
       //Console.WriteLine(arr[i]);
      
   }
    return arr;
     
  
}

void MinSum (int[] sumNum )
{
    int min = 10000;
   int minstr = 0;


    for (int i = 0; i < sumNum.Length ; i++)
    {
       if (sumNum[i] < min)
       {
        min = sumNum[i];
         minstr = i;
       } 
    }
    Console.WriteLine();
    Console.WriteLine($"Номер строки с наименьшей суммой элементов: {minstr}");
}


int[,] array2D = CreateMatrixRndInt(3, 4, -10, 10);
PrintMatrix(array2D);

SumNumInStrings(array2D);
int [] sumNumInStrings = SumNumInStrings(array2D);

MinSum (sumNumInStrings);




