// программа принимает на вход число и выдает колличество цифр в нем

Console.WriteLine("Ведите число:");
int number = int.Parse(Console.ReadLine());
//int number1 = Convert.ToInt32(Console.ReadLine());

int numberOfDigit = NumberOfDigit(number);
Console.WriteLine($"Сумма чисел от 1 до {number} = {numberOfDigit}");

int NumberOfDigit(int num)
{
    int sum = 0;
    //for (int i = 0; i > 1; i++);
    while ( num > 0)
    {
      num = num / 10;
      sum = sum +1;  
    }
    return sum;
}
