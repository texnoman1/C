// Задача 30 Напишите программу, которая выдает массив из 8 элементов, заполненный нулями и единицами в случайном порядке.

*void FillArray(int[] collection)
{
    for (int i = 0; i < collection.Length; i++)
    {
        collection[i] = new Random().Next(0, 2);
        //Console.Write(collection[i]);
    }
}

void PrintArray(int[] collection)
{
    for (int i = 0; i < collection.Length; i++)
    {
        Console.Write($"{collection[i]}");
    }
}

int[] array = new int[8];
FillArray(array);
PrintArray(array); 


/*void FillArray(int[] collection)
{
    for (int i = 0; i < collection.Length; i++)
    {
        collection[i] = new Random().Next(0, 2);
        //Console.Write(collection[i]);
    }
}

void PrintArray(int[] collection)
{
    for (int i = 0; i < collection.Length; i++)
    {
        Console.Write($"{collection[i]}");
    }
}

int[] array = new int[8];
FillArray(array);
PrintArray(array); */

/* Андрей Булгаков: 
int[] CreateArray(int size)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(0, 2);
    }
    return array;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}
int[] arr1 = CreateArray(8);
PrintArray(arr1);

 variant of Pavel Nagornov: 
int[] CreateArray(int size)
{
    int[] array = new int[size];
     //Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 2);
    }
    return array;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}
int[] arr = CreateArray(8);
PrintArray(arr);*/
