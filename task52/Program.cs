/* Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */

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



double[] AverageOfEveryColumns(int[,] matrix)
{
    //double[] arr = {1, 0, 0, 1};
    //double[] arr = new double [10];
    //for (int i = 0; i < matrix.GetLength(0); i++)
    //{
        
        //for (int j = 0; j < matrix.GetLength(1); j++)
        //{
    double[] arr = new double [matrix.GetLength(1)];
    //Console.WriteLine(arr);
    double avgj = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
           
            avgj = avgj + matrix[i,j] ;
          
           
        }
        arr[j] = Math.Round( avgj / matrix.GetLength(0), 1);
        //arr[j] = arr[j] + ";";

        avgj = 0;
        
       
    }    
    return arr;

}

int[,] array2D = CreateMatrixRndInt(3, 4, -10, 10);
PrintMatrix(array2D);

 double[] averageOfEveryColumns = AverageOfEveryColumns(array2D);
 AverageOfEveryColumns(array2D);

Console.Write("Cреднее арифметическое элементов в каждом столбце -> ");
 foreach (double i in averageOfEveryColumns) {
            Console.Write("{0} ", i); }

 
