﻿/*Задача 68: Напишите программу вычисления функции Аккермана с помощью
рекурсии. Даны два неотрицательных числа m и n.
m = 3, n = 2 -> A(m,n) = 29 */

Console.WriteLine("Введите Число М");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Число N");
int n = Convert.ToInt32(Console.ReadLine());


int A(int m, int n)
{
  if (m == 0)
  {
    return n+ 1;
  }
  else
  {
    if ((m != 0) && (n == 0))
    {
      return A(m - 1, 1);
    }
    else
    {
      return A(m - 1, A(m, n - 1));
    }
  }
}

A(m, n);
int a = A(m, n);
Console.WriteLine($"A(m,n) = {a}");