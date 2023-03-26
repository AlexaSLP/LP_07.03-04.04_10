// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 10000 || number > 99999)
{
  Console.WriteLine("Введите пятизначное число");
}
else
{
  bool palindrome = Palindrome(number);
  Console.WriteLine(palindrome ? "Да" : "Нет");
}
bool Palindrome(int num)
{
  if (num < 10)
    return false;
  int digitNum = num;
  int reverseNum = 0;
  while (num > 0)
  {
    reverseNum = reverseNum * 10 + num % 10;
    num /= 10;
  }
  return digitNum == reverseNum;
}