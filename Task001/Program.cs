/* 1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
a = 25, b = 5 -> да
a = 2, b = 10 -> нет
a = 9, b = -3 -> да
a = -3 b = 9 -> нет */

Console.WriteLine("Введите число A:");
int userNumberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B:");
int userNumberB = Convert.ToInt32(Console.ReadLine());
string result = "";

if (userNumberA == userNumberB * userNumberB)
{
    result = "является";
}
else
{
    result = "не является";
}

Console.WriteLine($"Число {userNumberA} {result} квадратом числа {userNumberB}");