/* *Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Например, задан массив размером 2 x 2 x 2.
Результат:
66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1) */

int[,,] Creatematrix3d(int rows, int columns, int dep, int min, int max)
{
    int[,,] matrix3d = new int[rows, columns, dep]; // 0, 1
    int count = 10;

    for (int i = 0; i < matrix3d.GetLength(0); i++) // 2
    {
        for (int j = 0; j < matrix3d.GetLength(1); j++) //
        {
            for (int k = 0; k < matrix3d.GetLength(2); k++)
            {
                matrix3d[i, j, k] = count;
                count ++;
            }
        }
    }
    return matrix3d;
}

 

 void PrintMatrix3d(int[,,] matrix3d)
{
    for (int i = 0; i < matrix3d.GetLength(0); i++)
    {
        //Console.Write("[");
        for (int j = 0; j < matrix3d.GetLength(1); j++)
        {
           for (int k = 0; k < matrix3d.GetLength(2); k++)
           {
             
            Console.Write($" {matrix3d[i, j, k],5 }  ({i}, {j}, {k})");
           // if (k < matrix3d.GetLength(2) - 1) Console.Write($"{matrix3d[i, j, k],5},");
            //else Console.Write($"{matrix3d[i, j, k],5} ");
           } 
        }
        Console.WriteLine("");
    }
}
 Creatematrix3d(2,2,2,10,10);
 int[,,]creatematrix3d = Creatematrix3d(2,2,2,10,10);

 PrintMatrix3d(creatematrix3d);
 


 