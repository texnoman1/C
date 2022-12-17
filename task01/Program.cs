//1. Напишите программу, которая на вход принимает два
//числа и проверяет, является ли первое число квадратом
//второго.
//a = 5; b = 25 -> да
//a = 2 b = 10 -> нет
//a = 9; b = -3 -> нет
//a = -3 b = 9 -> да




Console.WriteLine("Введите целое число 1");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите целое число 2");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number2 * number2 == number1)
{
    Console.WriteLine("Yes");
}
         else
{
    Console.WriteLine("No");
}
    
