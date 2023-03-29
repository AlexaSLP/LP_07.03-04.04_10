// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите целое число ");
int number = Convert.ToInt32(Console.ReadLine());
int sumDigitNumbers = SumDigitNumbers(number);

Console.WriteLine($"Сумма цифр числа {number} = {sumDigitNumbers}");

int SumDigitNumbers(int num)
{
  int sum = 0;
  while (num != 0)
  {
    sum = sum + num % 10;
    num /= 10;
    Console.WriteLine(num);
  }
  return sum;
}


