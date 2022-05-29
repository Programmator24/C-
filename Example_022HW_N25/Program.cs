// Напишите цикл, который принимает на вход
// два числа (A и B) и возводит число A в натуральную
//степень B. Задачу решить без использования Math.Pow.


Console.WriteLine("enter first number a");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("enter second number b");
int b = int.Parse(Console.ReadLine());

int i = 0;
int x = 1;

while (i < b )
{
    x = x * a;
    i++;
} 

Console.WriteLine($"{a}^{b}={x}");