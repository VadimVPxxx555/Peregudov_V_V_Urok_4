//Задача 29
// Напишите программу, которая задает массив из 8 
// элементов и выводит их на экран.

Console.Clear();
// int DataVvod(string str)      // метод позволяющий задавать длинну массива
// {
//     Console.Write(str);
//     int number = int.Parse(Console.ReadLine());
//     return number;
// }

int[] ArrayData(int number)
{
   int[] array = new int[number];
   int i = 0;
  for(i = 0; i < array.Length; i++)
  {
    array[i] = new Random().Next(0, 100);
  } 
  return array;
}

void PrintArray(int[] arrayPrint)
{
    for(int i = 0; i < arrayPrint.Length; i++)
    {
        Console.Write($"{arrayPrint[i]} ");
    }
}

int numberSchet = 8;   // int numberSchet = DataVvod("Задайте длинну массива")
int[] array = ArrayData(numberSchet);
PrintArray(array);
