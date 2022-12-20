// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. 
//Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

//456 -> 5
//782 -> 8
//918 -> 1


/*Console.WriteLine("Введите трёхзначное число");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 100 || number > 999)
{
    Console.WriteLine("Число не является трехзначным");  
    break;                                                     Как сделать чтобы дальнейшие команды не выполнялись? разобрался return

int SecondDigit(int num)
{
    return (num / 10) % 10;
}

int secondDigit = SecondDigit(number); 
Console.WriteLine($"Вторая цифра числа = {secondDigit}");*/

/*Console.WriteLine("Введите трёхзначное число"); 
   int number = Convert.ToInt32(Console.ReadLine());

int SecondDigit(int num)
{
   int result = number < 100 || number > 999 ? (num / 10) % 10 : "Число не является трехзначным";
    return result;
}

int secondDigit = SecondDigit(number); 
Console.WriteLine($"Вторая цифра числа = {secondDigit}");

Console.WriteLine("Введите трёхзначное число"); 
   int number = Convert.ToInt32(Console.ReadLine());

 bool SecondDigit(int num)
{
   bool result = num < 100 || num > 999 ;
    return result;  
}

Console.WriteLine(SecondDigit(number) ? "Число не является трехзначным" : $"Вторая цифра числа = {(number / 10) % 10}");*/

// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. 
//Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

//456 -> 5
//782 -> 8
//918 -> 1


Console.WriteLine("Введите трёхзначное число");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 100 || number > 999)
{
    Console.WriteLine("Число не является трехзначным");
    return; 
}
int SecondDigit(int num)
   {
        return (num / 10) % 10;
    }

    int secondDigit = SecondDigit(number);
    Console.WriteLine($"Вторая цифра числа = {secondDigit}"); // для отрицательных чисел добавить доп проверку, num брать по модулю?

