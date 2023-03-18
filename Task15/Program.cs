// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет


Console.WriteLine("Введите номер дня недели: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

  if (dayNumber >=6 && dayNumber <=8) 
  {
    Console.WriteLine("Это выходной день");
  }
  else if (dayNumber >= 1 && dayNumber < 7) 
  {
    Console.WriteLine("Это не выходной день, а рабочий");
  }
 else Console.WriteLine("Это число не соответствует дню недели");