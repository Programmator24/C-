//  Задайте массив вещественных чисел. Найдите
//разницу между максимальным и минимальным
//элементов массива.

Console.WriteLine("Enter massive sise");
int sise = int.Parse(Console.ReadLine());
Console.WriteLine();
double[] array = new double [sise];

double[] PrintArray(double[] array)
{
    for (int i = 0; i < sise; i++)
    {
        array[i] = new Random().NextDouble();
        Console.WriteLine(array[i]);
    }
    return array;
    
}

PrintArray(array);
Console.WriteLine();

double max = array[0];
double min = array[0];

for(int i = 0; i < sise; i++)
{
    if (array[i] > max)
    {
        max = array[i];
    }
    else if (array[i] < min)
    {
        min = array[i];
    }
}
Console.WriteLine();
Console.WriteLine($"max number = {max}");
Console.WriteLine();
Console.WriteLine($"min number = {min}");
Console.WriteLine();
Console.WriteLine($"max number - min number = {max-min}");
