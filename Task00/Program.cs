//Напишите программу, которая на вход принимает число и выдает его в квадрат.
//1. На вход принимает число
//2. Выдает его в квадрат (число умноженное на само себя).
Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
int square = number * number;

Console.WriteLine($"Квадрат числа {number} = {square}");


