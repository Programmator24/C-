//  Задайте значение N. Напишите программу, которая выведет все
// натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
 
Console.WriteLine("Enter number");
int number = int.Parse(Console.ReadLine());

void NaturalNumber(int num)
{
    if(num > 0)
    {
        Console.Write($"{num} ");
        num--;
        NaturalNumber(num);
        
    }

}
NaturalNumber(number);