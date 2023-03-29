// Напишите программу, которая принимает на вход число
// N выдает произведение чиссел от 1 до N
// 4 -> 24
// 5 -> 120


Console.WriteLine("Введите целое число ");
int number = Convert.ToInt32(Console.ReadLine());

int ptoductNumbers = ProductNumbers(number);
Console.WriteLine($"Произведение чисел от 1 до {number} = {ProductNumbers(number)}");

int ProductNumbers(int num)
{
  int prod = 1;
  for (int i = 2; i <= num; i++)
  {
    checked // проверка 
    {
      prod = prod * i;
    }
  }
  return prod;
}

