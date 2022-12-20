// See https://aka.ms/new-console-template for more information  /* */
Console.WriteLine("Введите число 1");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите  число 2");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(IsSquare(number1, number2) ? "Да" : "Нет");



bool IsSquare(int num1, int num2)
{
    return num1 / num2 == num2 || num2 / num1 == num1; //   ||  если первое условие верное, второе не проверяется, | проверяет оба условия в любом случае
}                                                      //      тоже самое с && и &                                                                                                   