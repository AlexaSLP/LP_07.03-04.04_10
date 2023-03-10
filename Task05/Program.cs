//Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые чила в промежутке от N до  -N

Console.WriteLine("Введите целое положительное число");
int number = Convert.ToInt32(Console.ReadLine());
int count = -number;
while(count <= number)
{
  Console.Write($"{count} ");
  count++;
}


