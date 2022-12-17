Console.WriteLine("Введите целое число");
int a = Convert.ToInt32(Console.ReadLine());
if (a >= 100 && a <= 999)
{
   Console.WriteLine(a % 10); //($ "Число {a % 10}}"); 
}

else
{
   Console.WriteLine("Вы ввели неверное число"); 
}
