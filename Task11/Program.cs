// Напишите программу, котоая выводит случайное трехзначное число и удаляет вторую цифру этого числа
// 456 -> 46
// 782 -> 72
// 918 -> 98

int RemoveSecondDigit(int num)
{
  int firstDigit = num / 100;
  int thirdDigit = num % 10;
  int result = firstDigit * 10 + thirdDigit;
  return result;
}

int number = new Random().Next(100, 999);
int removeSecondDigit = RemoveSecondDigit(number);
Console.WriteLine($"Случайное число из отрезка 100 - 999 -> {number}");
Console.WriteLine($"После удаления второй цифры получим число: {removeSecondDigit}");
