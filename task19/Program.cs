/* Задача 19

Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

14212 -> нет
12821 -> да
23432 -> да
*/

Console.WriteLine("Введите пятизначное число");
int num = Convert.ToInt32(Console.ReadLine());
if (num < 10000 || num > 99999)
{
    Console.WriteLine("Число не пятизначное");
    return;
}

IsPolindrom(num);


void IsPolindrom(int numb)
{
    int numb1 = numb / 10000;
    int numb2 = numb / 1000 % 10;
    int numb3 = numb / 100 % 10;
    int numb4 = numb / 10 % 10;
    int numb5 = numb % 10;
    Console.WriteLine( numb1 == numb5 || numb2 == numb4 ? "Да" : "Нет" );

}

