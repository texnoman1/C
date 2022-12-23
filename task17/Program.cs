/* 17. Напишите программу, которая:
1. На вход принимает координаты точки (Х и У),
2. Х не равно 0 и У не равно нулю.
3. Выдаёт номер четверти плоскости, где находится эта точка.*/

Console.WriteLine("Введите координаты точек"); // сочетания c + W
Console.WriteLine("X: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Y: ");
int y = Convert.ToInt32(Console.ReadLine());

int Quarter(int xc, int yc)
{
   if(xc > 0 && yc > 0) return 1;
   if(xc < 0 && yc > 0) return 2;
   if(xc < 0 && yc < 0) return 3;
   if(xc > 0 && yc < 0) return 4; 
   return 0;                          // Проверка равенство 0 , если ни одно условие не выполниться.
}

int quarter = Quarter(x, y);
string result = quarter > 0 ? $"Number of quarter -> {quarter}" : "Введены некоректные координаты";
Console.WriteLine(result);
