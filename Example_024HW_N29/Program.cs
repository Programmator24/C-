// Напишите программу, которая задаёт массив целых чисел и выводит их на экран.
// Размер массива определяется пользователем.
Console.WriteLine("Enter massive sise");
int sise = int.Parse(Console.ReadLine());
Console.WriteLine();
int[] array = new int [sise];

int[] PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        array[i] = new Random().Next(0,9);
        Console.Write(array[i]);
        Console.Write(" ");
    }
    return array;
    
}

PrintArray(array);

Console.WriteLine();
