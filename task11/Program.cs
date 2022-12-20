// Вывести случайное трехзначное число, программа должна удалить вторую цифру этого числа
int number = new Random().Next(100, 1000 );
Console.WriteLine($"случайное число {number}");

int firstDigit = number / 100;
int secondDigit = number % 100;
int thirdDigit = number % 10;
int  result = firstDigit * 10 + thirdDigit;
Console.WriteLine(result);


//int number = new Random().Next(100, 1000);

int MakeDigit(int num)
{
    int firstDigit = num / 100;   //int result = (num/100)*10 + num % 10; 
    int secondDigit = num % 100;
    int thirdDigit = num % 10;
    int result = firstDigit * 10 + thirdDigit;
    return result;
}



int makeDigit = MakeDigit(number);
Console.WriteLine(makeDigit);
