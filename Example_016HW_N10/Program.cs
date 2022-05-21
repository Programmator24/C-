// Задача 10: Напишите программу, которая принимает на
//вход трёхзначное число и на выходе показывает вторую
//цифру этого числа.
Console.WriteLine("Введите трехзначное число");
int number = int.Parse(Console.ReadLine());
number = number % 100; // find 2 last numbers
Console.WriteLine(number / 10);


