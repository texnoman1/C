/*Задача 65: Задайте значения M и N. Напишите программу, которая
выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5 -> "1, 2, 3, 4, 5"
M = 4; N = 8 -> "4, 6, 7, 8" 
Кирилл: Console.WriteLine("Please, enter number N");
int numberN = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please, enter number M");
int numberM = Convert.ToInt32(Console.ReadLine());
while (numberN == numberM)
{
Console.WriteLine("Your numbers are equal! Please, reenter neumber M");
numberM = Convert.ToInt32(Console.ReadLine());
}

int sign = Math.Sign((numberN - numberM));

NaturalNumbers(numberN, numberM);

void NaturalNumbers(int numN, int numM)
{
Console.Write($"{numN} ");
if (numN == numM) return;
NaturalNumbers(numN - 1 * sign, numM);
}

Alexander Pavlov: // Задача 65: Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"


int InsertDigit(string text) //Метод пользовательского ввода для целых чисел
{
int result; bool parse;
Console.WriteLine(text);
parse = Int32.TryParse(Console.ReadLine(), out result);
if (!parse) result = InsertDigit(text);//Если пользователь ввел некорректное значение вызываем повтороно метод.
return result;
}


void IntegerNumbers(int n, int m, int s)
{
if (n == m)
{
Console.Write($"{n} ");
return;
}
IntegerNumbers(n + s, m, s);

Console.Write($"{n} ");
}

int mUser = InsertDigit("Введите число N:");
int nUser = InsertDigit("Введите число M:");

int sign=Math.Sign((mUser-nUser));
Console.WriteLine($"sign = {sign}");

IntegerNumbers(nUser, mUser, sign);

*/

Console.WriteLine("Введите натуральное число m:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное число m:");
int n = Convert.ToInt32(Console.ReadLine());
NaturalNumbers(m, n);

void NaturalNumbers (int m,  int n)
{
if(n == m) return;
NaturalNumbers(m - 1, n);
Console.Write($"{m} ");
}
