/*Запросить у пользователя 10 чисел, вывести среднее арифметическое*/
int i = 0;
int sum = 0;
while(i < 3)
{
    Console.WriteLine("введите число");
    int num = Convert.ToInt32(Console.ReadLine());
    
    sum +=num;
    i ++;
}
Console.WriteLine(sum / i);