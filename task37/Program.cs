﻿/* Задача 37: Найдите произведение пар чисел в одномерном массиве.
Парой считаем первый и последний элемент, второй и предпоследний
и т.д. Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21 */

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
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        
        if(i < array.Length - 1) Console.Write (array[i] + ",");
        else  Console.Write (array[i] );    
    }
    Console.Write("] -> ");
}

void SumOfDigitInArray(int[] array, int digit)
{
     int sum = 0; 
    for (int i = 0; i < array.Length / 2; i++)    
       {
        
        Console.Write(array[i] * array[array.Length - i -1]);
           
        }
                    
}
    //Console.Write($"количество элементов массива, значения которых лежат в отрезке [10,99] = {sum}");
    //Console.Write();


int[] arr = CreateArrayRndInt(5, 0, 10);
PrintArray(arr);

SumOfDigitInArray(arr, 1);
