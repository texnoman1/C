/* Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.
[3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2 */

double [] CreateArrayRndDouble(int size, int min, int max)
{
    double[] array = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        //double result = LenghtLine(ax, ay,  bx, by);
        //double resRound = Math.Round(result, 2, douMidpointRounding.ToZero);

        array[i] = rnd.NextDouble() * ( max - min) + min;
        array[i] = Math.Round(array[i], 1, MidpointRounding.ToZero );        
    }
    return array;
}

void PrintArray(double[] array)
{
    Console.Write("Сумма элементов, стоящих на нечётных позициях: [");
    for (int i = 0; i < array.Length; i++)
    {
        
        if(i < array.Length - 1) Console.Write (array[i] + ", ");
        else  Console.Write (array[i] );    
    }
    Console.Write("] = ");
}

double FaindMaxInArray(double[] array)
{
    double max = 0;
    for (int i = 0; i < array.Length; i++)
    {

        if (array[i] > max)
        {
            max = array[i];

        }

    }
    Console.Write($" максимум = {max}");
    return max;
}  

double FaindMinInArray(double[] array)
{
    double min = 0;
    for (int i = 0; i < array.Length; i++)
    {

        if (array[i] < min)
        {
            min = array[i];

        }

    }
    Console.Write($" минимум = {min}");
    return min;
}

void DifferenceMinMax (double max, double min )
{
    double result = max - min; 
    Console.WriteLine($" Разница между максимальным и минимальным элементами массива = {result}");

}

double [] arr = CreateArrayRndDouble(4, -10, 10);
PrintArray(arr);

double max = FaindMaxInArray(arr);
double min = FaindMinInArray(arr);
DifferenceMinMax(max, min);
