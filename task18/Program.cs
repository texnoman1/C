// Напишите программу, которая по заданному номеру четверти показывает диапазон возможных координат Х и У

Console.WriteLine("Введите номер четверти"); // сочетания c + W
int numberOfquarter = Convert.ToInt32(Console.ReadLine());

string Range(int numberOfq)
{
   if(numberOfq == 1) return "x > 0, y > 0";
   if(numberOfq == 2) return "x < 0, y > 0";
   if(numberOfq == 3) return "x < 0, y < 0";
   if(numberOfq == 4) return "x > 0, y < 0"; 
   return "нет такой четверти";                          // Проверка равенство 0 , если ни одно условие не выполниться.
}

string range =  Range(numberOfquarter);

Console.WriteLine(range);

