Console.WriteLine("Введите целое число ");
int a = Convert.ToInt32(Console.ReadLine());
int count = -a;
while(count <= a)
{
    Console.Write(count); //Console.Write(count + " "); добавит ковычки 
    count = count + 1; //counter ++ 
}
