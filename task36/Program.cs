﻿/* Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих
на нечётных позициях  3, 7, 23, 12] -> 19   [-4, -6, 89, 6] -> 0 */

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max + 1);        
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("Сумма элементов, стоящих на нечётных позициях: [");
    for (int i = 0; i < array.Length; i++)
    {
        
        if(i < array.Length - 1) Console.Write (array[i] + ",");
        else  Console.Write (array[i] );    
    }
    Console.Write("] = ");
}

void SumOfOddNambersInArray(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {

        if (i % 2 != 0)
        {
            sum = sum + array[i];

        }

    }
    Console.Write($"  {sum}");
}    

int[] arr = CreateArrayRndInt(4, -10, 10);
PrintArray(arr);

SumOfOddNambersInArray(arr);
