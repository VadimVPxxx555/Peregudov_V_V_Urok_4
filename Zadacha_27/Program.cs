//Задача 27
// Напишите программу, которая принимает на вход число
// и выдает сумму цифр в числе.

Console.Clear();
int DataVvod(string str)
{
    Console.Write(str);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int Schetnumb(int number)
{
  int numberbuffer = number;
  int numbersum = 0;
  int i = 0;
  for(i = 0; i < number; i++)
  {
    numbersum = numbersum + numberbuffer % 10;
    numberbuffer = numberbuffer / 10;
  }
  return numbersum;
}

int number = DataVvod("Введите число ");

int numbersum = Schetnumb(number);

Console.WriteLine(number + " -> " + numbersum);
