/* Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22 */
Console.WriteLine("Введите число A:");
int userNumberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B:");
int userNumberB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число C:");
int userNumberC = Convert.ToInt32(Console.ReadLine());
int max = userNumberA;
if (max < userNumberB) max = userNumberB;
if (max < userNumberC) max = userNumberC;
Console.WriteLine(max);