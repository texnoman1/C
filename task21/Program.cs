/* Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

Console.WriteLine("Введите координату x точки А"); // сочетания c + W
int ax = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату y точки А");
int ay = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату z точки А");
int az = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату x точки B");
int bx = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату y точки B");
int by = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату z точки B");
int bz = Convert.ToInt32(Console.ReadLine());

double LenghtLine(int ax, int ay, int az, int bx, int by, int bz)
{
    int temp = (ax - bx) * (ax - bx) + (ay - by) * (ay - by) + (az - bz) * (az - bz);
    return  Math.Sqrt(temp);    
}

double result = LenghtLine(ax, ay, az, bx, by, bz);
double resRound = Math.Round(result, 2, MidpointRounding.ToZero);

Console.WriteLine($"Расстояние между точками А и Б -> {resRound}");
