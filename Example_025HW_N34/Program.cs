// Задайте массив заполненный случайными
//положительными трёхзначными числами. Напишите
//программу, которая покажет количество чётных чисел в
//массиве.

Console.WriteLine("Enter massive sise");
int sise = int.Parse(Console.ReadLine());
Console.WriteLine();
int[] array = new int [sise];

int[] PrintArray(int[] array)
{
    for (int i = 0; i < sise; i++)
    {
        array[i] = new Random().Next(100,999);
        Console.Write(array[i]);
        Console.Write(" ");
    }
    return array;
    
}

PrintArray(array);
Console.WriteLine();

int number2 = 0;

for (int i  = 0;i < sise; i++)
{
    if (array[i] % 2 == 0)
    {
        number2++;
    }
}

Console.WriteLine(number2);

