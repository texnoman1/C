// квадрат числа
//string str = Console.ReadLine();
//int number = Convert.ToInt32(str) расписана строка 5
//int.number = int/parse ( Console.ReadLine()) конвертирует только строку
Console.WriteLine("Введите целое число");
int number = Convert.ToInt32(Console.ReadLine());
int square = number * number;
Console.WriteLine($"Квадрат числа {number} = {square}");
