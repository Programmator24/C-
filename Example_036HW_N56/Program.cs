// Задайте прямоугольный двумерный массив. Напишите
// программу, которая будет находить строку с наименьшей суммой элементов.


void FillArray(int[,] matr)
{
    for(int i = 0; i < matr.GetLength(0); i++)
    {
        for(int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = new Random().Next(1,10);
        }
    }
}


void PrintArray(int[,] matr)
{
    for(int i = 0; i < matr.GetLength(0); i++)
    {
        for(int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i,j]} ");
        }
        Console.WriteLine();
    }
}

void FindMaxSumOfString(int[,] matr)
{
    int sum = 0;
    int[] array = new int[matr.GetLength(0)];
    for(int i = 0; i < matr.GetLength(0); i++)
    {
           for(int j = 0; j < matr.GetLength(1); j++)
           {
              sum = sum + matr[i,j];
           }
           array[i] = sum;
           sum = 0;
           Console.WriteLine($"sum of string {i+1} = {array[i]}");
    }
    Console.WriteLine();
    int min = 1;
    for (int x = 0; x < matr.GetLength(0)-1; x++)
    {
        if(array[x] > array[x+1])
        {
            min = x+1;
        }

    }
    Console.WriteLine($"minimal string = {min}");

}
Console.WriteLine();
int[,] matrix = new int [3,3];
FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
FindMaxSumOfString(matrix);
Console.WriteLine();

