/*Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
5 ->
1 | 1
2 | 8
3 | 27
4 | 64
5 | 125*/

Console.WriteLine("Введите число (N)");
int num = Convert.ToInt32(Console.ReadLine());

if (num < 0)
{
    Console.WriteLine("Вы ввели не корректное число");
}


Cube(num);

void Cube(int num1)
{
        int count = 1;
        while(count <= num1)
        {
             Console.WriteLine($"{count} -> {count * count * count}");
             count ++;  
        }

}


