/* Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2Д пространстве.
А(3,6); B(2,1)  -> 5,09
A(7,-5); B(1, -1) -> 7,21
*/
Console.WriteLine("Введите координату 1 точки А"); // сочетания c + W
int ax = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату 2 точки А");
int ay = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату 1 точки B");
int bx = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату 2 точки B");
int by = Convert.ToInt32(Console.ReadLine());


double LenghtLine(int ax, int ay, int bx, int by)
{
    int temp = (ax - bx) * (ax - bx) + (ay - by) * (ay - by);
    return  Math.Sqrt(temp);
    
}

double result = LenghtLine(ax, ay,  bx, by);
double resRound = Math.Round(result, 2, MidpointRounding.ToZero);

Console.WriteLine($"Расстояние между точками А и Б -> {resRound}");

