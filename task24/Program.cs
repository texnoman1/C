// программа принимает на вход число А и выдает сумму чисел от 1 до А
// 7 -> 28, 8 -> 36

Console.WriteLine("Ведите число:");
int number = int.Parse(Console.ReadLine());
//int number1 = Convert.ToInt32(Console.ReadLine());

int sumnumbers = Sumnumbers(number);
Console.WriteLine($"Сумма чисел от 1 до {number} = {sumnumbers}");

int Sumnumbers (int num) //num = number
{
    int sum = 0;
    for (int i = 1; i <=  num; i++)
    {
      sum = sum + i; 
    }
    return sum;
}