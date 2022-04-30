//Напишите программу, которая на вход
//принимает два числа и выдаёт, какое число большее, а
//какое меньшее.

Console.WriteLine("enter first number a");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("enter second number b");
int b = int.Parse(Console.ReadLine());
Console.Write("a= ");
Console.WriteLine(a);
Console.Write("b= ");
Console.WriteLine(b);
if (a == b)
{
    Console.WriteLine("a = b");
}
else if (a > b)
    {
        Console.WriteLine("a = max");
    }
else 
{
    Console.WriteLine("b = max");
}

