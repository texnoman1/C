﻿/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите
программу, которая покажет количество чётных чисел в массиве.
345, 897, 568, 234] -> 2 */

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
    Console.Write("Количество чётных чисел в массиве: [");
    for (int i = 0; i < array.Length; i++)
    {
        
        if(i < array.Length - 1) Console.Write (array[i] + ",");
        else  Console.Write (array[i] );    
    }
    Console.Write("] = ");
}

void NumberOfEvenInArray(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {

        if (array[i] % 2 == 0)
        {
            sum = sum + 1;

        }

    }
    Console.Write($"  {sum}");
    //Console.Write();
}

int[] arr = CreateArrayRndInt(10, 100, 1000);
PrintArray(arr);

NumberOfEvenInArray(arr);