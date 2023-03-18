//  Напишите программу, котоая принимает на вход трехзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int FindSecondDigit(int num)
{
  num =num / 10;
  num = num % 10;
  return num;
}

Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 0) number *= -1;
if (number > 99 && number < 1000)
Console.WriteLine($"Вторая цифра числа -> {FindSecondDigit(number)}");

else Console.WriteLine($"Ошибка. Введите трехзначное число");

