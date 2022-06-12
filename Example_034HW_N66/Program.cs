// Задайте значения M и N. Напишите программу, которая найдёт сумму
//натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.

Console.WriteLine("Enter number M");
int numberM = int.Parse(Console.ReadLine());

Console.WriteLine("Enter number N");
int numberN = int.Parse(Console.ReadLine());


int SumOfNumbers(int num1, int num2)
{
   int s = 0;
    if (num1 <= num2)
    s = num1 + SumOfNumbers(num1+1,num2);
     return s;
}
Console.WriteLine(SumOfNumbers(numberM, numberN));