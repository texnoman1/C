/* *Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07 */

void Spiral2d(int index)
{
    int[,] spiral2d = new int[index, index]; // 0, 1
    int count = 0;

    for (int i = 0; i < index; i++) // 2
    {
        for (int j = 0; j < index/3 ; j++) //
        {
            for (int k = 0; k < index; k++)
            {
                spiral2d[i, k] = count;
                
                Console.Write($"{spiral2d[i,k], 5}");
                count ++;
            }
            Console.WriteLine();
        }
        
    }
    //return spiral2d;

}

Spiral2d(4);