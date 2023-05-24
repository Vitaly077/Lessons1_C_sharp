// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Введите первое число");

int n1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число");

int n2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье число");

int n3 = Convert.ToInt32(Console.ReadLine());

if (n1 > n2 & n1 > n3)
{
Console.WriteLine($"max = {n1}");
}
else if (n2 > n1 & n2 > n3)
{
Console.WriteLine($"max = {n2}");
}

else if (n3 > n1 & n3 > n2)
{
Console.WriteLine($"max = {n3}");
}
else
{
Console.WriteLine("Числа равны между собой");
}

