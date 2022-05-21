// Задача 15: Напишите программу, которая принимает на
// вход цифру, обозначающую день недели, и проверяет,
//является ли этот день выходным.

Console.WriteLine(" enter day of week, number should be from 1 to 7");
int day = int.Parse(Console.ReadLine());
if (day < 6)
{
    Console.WriteLine("tooday is work day");
}
else if (day < 8)
{
    Console.WriteLine("tooday is weekend");
}
else 
Console.WriteLine("incorrect day, number should be from 1 to 7");