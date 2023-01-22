﻿/*Задача 42: Напишите программу, которая будет преобразовывать
десятичное число в двоичное.
45 -> 101101
3 -> 11
2 -> 10 */

int ParseIn2(int num)
{
    int result = num % 2;
    if (num == 0) return 0;
    num /= 2;
    result += ParseIn2(num)*10;
    return result;
}

Console.WriteLine("Введите число");
var num = Console.ReadLine();
Console.WriteLine(ParseIn2(Convert.ToInt32(num)));

/*Кирилл:
 // Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

int number = NumberInput("Please, input your number");
Console.WriteLine(DecToBin(number));

int NumberInput(string text) // Method fot Number input
{
Console.WriteLine(text);
int numberinput = Convert.ToInt32(Console.ReadLine());
return numberinput;
}

string DecToBin(int num)
{
string result = string.Empty;
while (num > 0)
{
result = num % 2 + result;
num /= 2;
}
return result;
}*/
