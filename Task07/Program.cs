// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.

Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number >= 100 && number <= 999)
{
  int lastNumber = number % 10;
  Console.WriteLine($"Последняя цифра {number} = {lastNumber}");
}
else
{
  Console.WriteLine("Введите трехзначное число: ");
}


