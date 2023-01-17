// Задача 29: Напишите программу, которая задаёт
//массив из 8 элементов, заполненный
//псевдослучайными числами и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

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
    Console.Write($"[");
    for (int i = 0; i + 1 < arr.Length; i++)
    {
        
        Console.Write($"{arr[i]}, ");
    }
    Console.Write($"{arr[arr.Length -1]}");
    Console.Write($"]");
}
int[] arr1 = CreateArray(8);
PrintArray(arr1);