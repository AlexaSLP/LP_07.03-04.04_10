// Задача 64: Задайте значение N. Напишите программу, 
//которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

bool CheckNaturalNumber(int num)
{
    return num >= 1;
}

int SumNumbers(int num1, int num2)
{
    if(num1 == num2) return num2;
    {
        if(num1 < num2)
        return num1 + SumNumbers(num1 + 1, num2);
        else
        return num1 + SumNumbers(num1 - 1, num2);
    }
}

Console.WriteLine("Введите натуральное значение M");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите натуральное значение N");
int number2 = Convert.ToInt32(Console.ReadLine());

int sumNumbers = SumNumbers(number1, number2);

if(CheckNaturalNumber(number1) && CheckNaturalNumber(number2))
{
    Console.WriteLine($"M = {number1}; N = {number2} -> {sumNumbers}");
}
else 
{
    Console.WriteLine("Введенные вами числа - не натуральные");
}