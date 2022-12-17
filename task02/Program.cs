//Задача 2: Напишите программу, которая на вход
//принимает два числа и выдаёт, какое число большее, а
//какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

Console.WriteLine("Введите число А");
int num_a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число Б");
int num_b = Convert.ToInt32(Console.ReadLine());
if (num_a < num_b)
{
    Console.WriteLine($"max = {num_b}");
}
else
{
    Console.WriteLine($"max = {num_a}");  
}