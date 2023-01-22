/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223-> 3     string str = "3,5,6,8,0,-34"; string[] strArr = str.Split(',');*/

long [] EnterMDigits(int m)
{
    //long [] str = {};
    long [] str = new long[m];
    
    for (int i = 0; i < m; i++)
    {

        Console.WriteLine($"Введите число {i+1}");
        long num = Convert.ToInt64 ( Console.ReadLine());

        str[i] =  num ;

    }
    //Console.WriteLine(str);
    //string[] strArr = str.Split(new char[] { ',' });
    //Console.WriteLine(strArr);
    return str;

}

long HowManyNaturalNum(long [] str )
{
     
    long result = 0;
    //long temp = 0;
   for (int i = 0; i < 3; i++)
   {
      //temp = Convert.ToInt32(str[i]);
      if (str[i] > 0)
      {
         result = result +1;
      }
      //Console.WriteLine(str[i]);
   }
   return result;
}

int m = 3;

long [] enterMDigits = EnterMDigits(m);
//EnterMDigits(m);

long howManyNaturalNum = HowManyNaturalNum(enterMDigits);
//HowManyNaturalNum(enterMDigits);

Console.WriteLine($"Пользователь ввёл {howManyNaturalNum} числа(о) больше 0.");


