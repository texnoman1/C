// программа принимает на вход число N и выдает произведение чисел от 1 до N

Console.WriteLine("Ведите число:");
int number = int.Parse(Console.ReadLine());

int mult = Mult(number);
Console.WriteLine($"произведение чисел от 1 до {number} = {mult}");

int Mult (int num)
{
    int mult = 1;
    int temp = 1;
    for (int i = 1; i - 1 < num; i++)
    {
      
         mult = mult * i;   

    }
    return mult;
}

