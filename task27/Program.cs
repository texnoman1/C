// Задача 27: Напишите программу, которая принимает на
//вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

Console.WriteLine("Ведите число:");
int number = int.Parse(Console.ReadLine());

int SumOfDigits (int num)
{
    int i = 0;
    int sum = 0;
    int temp = 0;
    while (num > 0)
    {
        temp = num % 10;
        num = num / 10;
        sum = sum + temp;
        i = i + 1;        
    }
    return sum;
}

int sumOfDigits = SumOfDigits(number);
Console.WriteLine(sumOfDigits);

