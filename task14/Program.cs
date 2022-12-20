// See https://aka.ms/new-console-template for more information


Console.WriteLine("Введите число");
int number = Conver.ToInt32(Console.ReadLine());
if(number % 7 == 0 && number % 23 == 0) Console.WriteLine("Число делится на 23 и 7 без остатка");
else Console.WriteLine("Число не делится на 23 и 7 без остатка");
