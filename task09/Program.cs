// программа должна выводить случайное число из отрезка [0, 99] и показывает наибольшую цифру этого числа
int number = new Random().Next(10, 100); //последнее число не входит в диапазон, поэтому не 99, 100. new выделяет место в оперативной памяти
Console.WriteLine($" Случайное число из отрезка {number}");
int firstDigit = number / 10;
int secondDigit = number % 10;

//if (firstDigit > secondDigit) Console.WriteLine($"Наибольшая цифра числа = {firstDigit}");  //решение1
//else Console.WriteLine($"Наибольшая цифра числа = {secondDigit}");

//Console.Write($"Наибольшая цифра числа = "); //решение2 через тернарный оператор
//Console.WriteLine(firstDigit > secondDigit ? firstDigit : secondDigit);  //решение2 через тернарный оператор

// метод, который не возвращает никакого значения - процедура

int maxDigit = MaxDigit(number);  //вызов метода, первый вызов функции
Console.WriteLine($"Наибольшая цифра числа = {maxDigit}"); //вывод результата


int maxDigit1 = MaxDigit(19);  //вызов метода, второй вызов
Console.WriteLine($"Наибольшая цифра числа = {maxDigit1}"); //вывод результата 1



int MaxDigit(int num) //num = number
{                                                                                           //тело метода
    int firstDigit = num / 10;
    int secondDigit = num % 10;
    int result = firstDigit > secondDigit ? firstDigit : secondDigit;
    return result;
}

