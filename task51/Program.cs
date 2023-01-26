/* Задача 51: Задайте двумерный массив. Найдите сумму
элементов, находящихся на главной диагонали (с индексами
(0,0); (1;1) и т.д.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Сумма элементов главной диагонали: 1+9+2 = 12  */

Павел: int GetSum(int[,] matrix)
{
int sum=0;
int size=matrix.GetLength(0)<matrix.GetLength(1)?matrix.GetLength(0):matrix.GetLength(0);
for (int j = 0; j < size; j++)
{
sum+=matrix[j,j];
}
return sum;
}
Павел: int GetSum(int[,] matrix)
{
int sum=0;
int size=matrix.GetLength(0)<matrix.GetLength(1)?matrix.GetLength(0):matrix.GetLength(0);
for (int j = 0; j < size; j++)
{
sum+=matrix[j,j];
}
return sum;
}

int[,] array2D = CreateMatrixRndInt(3, 4, -100, 100);
PrintMatrix(array2D);
int sum=GetSum(array2D);
Console.WriteLine(sum);