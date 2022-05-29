// задайте одномерный массив, заполненный
//случайными числами. Найдите сумму элементов, стоящих
//на нечётных позициях.

Console.WriteLine("Enter massive sise");
int sise = int.Parse(Console.ReadLine());
Console.WriteLine();
int[] array = new int [sise];

int[] PrintArray(int[] array)
{
    for (int i = 0; i < sise; i++)
    {
        array[i] = new Random().Next(-99,99);
        Console.Write(array[i]);
        Console.Write(" ");
    }
    return array;
    
}

PrintArray(array);
Console.WriteLine();

int sum = 0;

for (int i  = 0;i < sise; i++)
{
    if (i % 2 == 0)
    {
        sum = sum + array[i];
    }
}

Console.WriteLine(sum);

