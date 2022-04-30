//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю
//цифру этого числа.

Console.WriteLine("Enter number");
int a = int.Parse(Console.ReadLine());
Console.WriteLine(a % 10);
