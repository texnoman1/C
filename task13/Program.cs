/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. 
Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

645 -> 5
78 -> третьей цифры нет
32679 -> 6*/

/*Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

   void  ThirdDigit( num)
{
    if (num < 100 )    
    {        
        Console.WriteLine("третьей цифры нет");
        return;
    } 
    else if(num > 99)
    {
        while (num < 100)
        num = num; // 10;
        num = num % 10;       
    }
    return num;
}

 int thirdDigit = ThirdDigit(number);
Console.WriteLine(thirdDigit);*/

/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. 
Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

645 -> 5
78 -> третьей цифры нет
32679 -> 6*/


Console.WriteLine("Введите число");
int costil =0;
int number = Convert.ToInt32(Console.ReadLine());
if (number < 100)
{

    Console.WriteLine("третьей цифры нет");
    return; // Это место стоило мне пол жизни)))

}

int  ThirdDigit(int num)
{
    
    
    {
        while (num < 100)
        num = num; // 10;
        num = num % 10;       
    }
    
    return num;
}

int thirdDigit = ThirdDigit(number);
Console.WriteLine(thirdDigit);
// Для отрицательных чисел не делал

