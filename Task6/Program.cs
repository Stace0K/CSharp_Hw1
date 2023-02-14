// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Random rnd = new Random();
int a = rnd.Next();
Console.WriteLine(a);
if (a % 2 == 0)
{
    Console.WriteLine("чётное");
}
else
{
    Console.WriteLine("нечётное");
}
