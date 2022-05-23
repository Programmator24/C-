//Напишите программу, которая принимает на
//вход пятизначное число и проверяет, является ли оно
//палиндромом.
int[] array = new int[5];

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next (1, 10);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

void Desision()
{
if (array[0] == array[4])
{
    if (array[1]  == array[3])
    {
        Console.WriteLine("Yes");
    }
}
else 
{
    Console.WriteLine("No");
}
}



FillArray(array); 
PrintArray(array);
Desision();
Console.WriteLine();


