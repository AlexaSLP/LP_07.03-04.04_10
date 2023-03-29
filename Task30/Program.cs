// Напишите программу, которая выводит массив из 
// 8 элементов, заполненный нулями и единицами
// в случайном порядке
// [1, 0, 1, 1, 0, 1, 0, 0]

//int[] array = new int[8];
//array[3] = 34;

//for (int i = 0; i < array.Lenght, i++);
//array[i] =
//Console.Write(array[i])

//int number = new Random().Next(0,2);

//int[] array = new int[8];
//FillArray(array);

// void FillArray(int[] collection);
// {
//  int length = collection.Lenght;

// int index = 0;
// while (index < length)
//  {
//  collection[index] = new Random().Next(0, 1);
//  index++;
//}
//}


int number = new Random().Next(0, 2);
int[] array = new int[8];

FillArray(array);
PrintArray(array);

void FillArray(int[] array)
{
  for (int i = 0; i < array.Length; i++)
  {
    array[i] = new Random().Next(0, 2);
  }
}
void PrintArray(int[] array)
{
  for (int i = 0; i < array.Length; i++)
  {
    Console.Write(array[i] + " ");
  }
}
