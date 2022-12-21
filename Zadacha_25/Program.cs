//Задача 25
// Напищите цикл, который принимает на вход два числа (А и В)
// и возводит число А в натуральную степень В.

Console.Clear();

int DataVvod(string str)
{
    Console.Write(str);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int numberSchet1 = DataVvod("Введите число ");
int numberSchet2 = DataVvod("Введите степень числа ");

int i = 1;
int newnumber = numberSchet1;
for(i = 1; i < numberSchet2; i++)
{
  numberSchet1 = numberSchet1 * newnumber;
} 

Console.WriteLine(numberSchet1);
