/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму
натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

Console.WriteLine("Введите Число М");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Число N");
int n = Convert.ToInt32(Console.ReadLine());
int temp = 0;
if (m > n)
{
    temp = m;
    m = n;
    n = temp;
}


int SumOfNum(int m, int n)

{
    if (m > n) return 0;
    return n + SumOfNum(m, n - 1) ;
     
    
}



SumOfNum(m, n);
int sumOfNum = SumOfNum(m, n);
Console.WriteLine(sumOfNum);

