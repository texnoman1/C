/* 22 Напишите программу, которая на вход принимает число N и выдает таблицу квадратов чисел от 1 до N
5 -> 1, 4, 9, 16, 25;
2 -> 1, 4 */

Console.WriteLine("Введите число N"); // сочетания c + W
int n = Convert.ToInt32(Console.ReadLine());

void TableOfSquare(int n1)
{
    int count = 1;                                   // int count = 1;
    int sq1 = 1;                                     //  while(count <= n1)
    while (count <= n1)                              // {
    {                                                //   Console.WriteLine($"{count}, {count * count}");
    sq1 = count * count;                             //   Count ++
    Console.WriteLine($"{count}, {sq1}");            //  }
    count ++;
    sq1 = 1;
    }
}

  TableOfSquare(n);
