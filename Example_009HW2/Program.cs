//Напишите программу, которая принимает на
//вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("enter first number a");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("enter second number b");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("enter third number c");
int c = int.Parse(Console.ReadLine());
Console.Write("a= ");
Console.WriteLine(a);
Console.Write("b= ");
Console.WriteLine(b);
Console.Write("c= ");
Console.WriteLine(c);
int max = 0;

if (a > max)
{
    max = a;
}
if (b > max)
{
    max = b;
}
if (c > max)
{
    max= c;
}
Console.WriteLine("max = " + max);