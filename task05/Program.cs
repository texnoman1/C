﻿//5. Напишите программу, которая на вход принимает
//одно число (N), а на выходе показывает все целые
//числа в промежутке от -N до N.
//4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
//2 -> " -2, -1, 0, 1, 2"

Console.WriteLine("Введите целое число ");
int a = Convert.ToInt32(Console.ReadLine());
int count = -a;
while(count <= a)
{
    Console.Write(count); //Console.Write(count + " "); добавит ковычки 
    count = count + 1; //counter ++ 
}
