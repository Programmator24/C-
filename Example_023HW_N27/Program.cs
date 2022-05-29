// Напишите программу, которая принимает на
//вход число и выдаёт сумму цифр в числе. Задачу решить без использования строк (string).

Console.WriteLine("enter number a");
int a = int.Parse(Console.ReadLine());
int b = 1;
int sum = 0;
while (a > 0)
{
    b = a % 10;
    sum = sum + b;
    a = a / 10;
}
Console.WriteLine(sum);
