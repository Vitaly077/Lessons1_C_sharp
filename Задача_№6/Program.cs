﻿// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Ведите число");

int num = Convert.ToInt32(Console.ReadLine());

if (num % 2 == 0)
{
Console.WriteLine("Чётное число");
}
else
{
Console.WriteLine("Нечётное число");
}