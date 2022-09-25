/*5. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
2 -> " -2, -1, 0, 1, 2"*/

Console.WriteLine("Введите значение:");
int userNumber = Convert.ToInt32(Console.ReadLine());

int count = userNumber * -1;
//Console.WriteLine(count);
string result = "";
while (count<=userNumber)
{
    result = result + Convert.ToString(count) +", ";
    count=count+1;
}
Console.WriteLine(result);
//Console.WriteLine(count);