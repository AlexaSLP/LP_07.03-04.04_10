// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите положительное число больше 0: ");
int number = Convert.ToInt32(Console.ReadLine());
int i = 2;

while (i <= number - 2)
{
  Console.Write($"{i}, ");
  i += 2;
}
if (number % 2 == 0)
  Console.Write(number);
else
  Console.Write(number - 1);