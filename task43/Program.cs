/*Задача 43. Напишите программу, которая найдёт точку
пересечения двух прямых, заданных уравнениями y = k1 *
x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются
пользователем  b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

y = k1 * x + b1, y = k2 * x + b2
k1 * x + b1 = k2 * x + b2
(k1 - k2) * x = b2 - b1
x = (b2 - b1) / (k1 - k2)
y = k1 * x + b1
*/

Console.WriteLine("Введите b1");
float b1 = Convert.ToSingle(Console.ReadLine());
Console.WriteLine("Введите k1");
float k1 = Convert.ToSingle(Console.ReadLine());
Console.WriteLine("Введите b2");
float b2 = Convert.ToSingle(Console.ReadLine());
Console.WriteLine("Введите k2");
float k2 = Convert.ToSingle(Console.ReadLine());

float[] Equation(float b1, float k1, float b2, float k2)
{
    float[] arr = {0, 0};
    float x = (b2 - b1) / (k1 - k2);
    float y = k1 * x + b1;
    arr[0] = x;
    arr[1] = y;
    //Console.Write(x);
    //Console.Write(y);
    return arr;
}


Equation(b1,   k1,  b2,   k2);
float [] equation = Equation(b1, k1, b2,  k2);
Console.WriteLine($"Ответ: x = {equation[0]}, y = {equation[1]}");

