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


int[] arr = { 0, 5, 4, 3, 2, 1 };
foreach (double i in arr) { Console.Write("{0} ", i); }
Console.Write(arr.Length);
int temp = 2;
for (int i = 0; i < arr.Length; i++)
{
    for (int j = 0; j < arr.Length - 1; j++)
    {

        if (arr[j] < arr[j + 1])
        {
            temp = arr[j];
            (arr[j]) = (arr[j + 1]);
            arr[j + 1] = temp;
        }
    }
    
    }
    foreach (double i in arr) { Console.Write("{0} ", i); }


//int[] arr1 = CreateArray(4);
//PrintArray(arr1);

//AvgInString(arr);
//PrintArray(arr);

/*Console.Write("Cреднее арифметическое элементов в каждом столбце -> ");
 foreach (double i in averageOfEveryColumns) {
            Console.Write("{0} ", i); }   */


