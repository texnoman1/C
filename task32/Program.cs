﻿/*Задача 32: Напишите программу замена элементов
массива: положительные элементы замените на
соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2] */

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

void PrintInvertArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = - array[i];
        if(i < array.Length - 1) Console.Write (array[i] + ",");
        else  Console.Write (array[i] );    
    }
    Console.Write("]");
}




int[] arr = CreateArrayRndInt(4, -10, 10);
PrintArray(arr);

PrintInvertArray(arr);


//Console.WriteLine($"Сумма положительных чисел = {sumPositive}");

// Задача 32: Напишите программу замена элементов
// массива: положительные элементы замените на
// соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

/*Решение с семинара
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
System.Console.Write("[");
for (int i = 0; i < array.Length; i++)
{
if (i < array.Length - 1) System.Console.Write(array[i] + ",");
else System.Console.Write(array[i]);
}
System.Console.WriteLine("]");
}

void ChangeOverNumb(int[] array)
{
for (int i = 0; i < array.Length; i++)
{
array[i] = -array[i];
}
}

int[] create = CreateArrayRndInt(4, -10, 10);

PrintArray(create);
ChangeOverNumb(create);
PrintArray(create);
