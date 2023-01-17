// Задача 25: Напишите цикл, который принимает на вход
//два числа (A и B) и возводит число A в натуральную
//степень B.


Console.WriteLine("Ведите число A:");
int A = int.Parse(Console.ReadLine());
Console.WriteLine("Ведите число B:");
int B = int.Parse(Console.ReadLine());

int DegreeOfNumber(int A1, int B1)
{
    int result = 1;
    
        for (int i = 1; i <= B1; i++)
        {
            result = result * A1;
        }
    
    return result;
}

int degreeOfNumber = DegreeOfNumber(A, B);
Console.WriteLine($"число {A} в степени {B} = {degreeOfNumber}");
