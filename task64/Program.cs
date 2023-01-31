/* Задача 64: Задайте значение N. Напишите программу, которая выведет все
натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1" */

//int EnterNumber()
//{
    Console.WriteLine("Ведите число М");
    int m = Convert.ToInt32(Console.ReadLine());
    //return m;
//}


void NumberFromMto1(int m)
{

    if (m != 1)
    {
        Console.Write($"{m},");
        NumberFromMto1(m - 1);

    }
    //Console.Write(1);
}


//int enterNumber = EnterNumber();
//EnterNumber();
Console.Write($"M = {m} -> \"");
NumberFromMto1(m);
Console.Write("1\"");

