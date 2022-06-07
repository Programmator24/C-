// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и
//возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:

void PrintArray( int[,] matr)
{
    for(int i = 0; i < matr.GetLength(0); i++)
    {
        for(int j = 0; j < matr.GetLength(1); j++)
        {
        Console.Write($"{matr[i, j]} " );
        }
        Console.WriteLine();
    }
}


void FillArray( int[,] matr)
{
    for(int i = 0; i < matr.GetLength(0); i++)
    {
        for(int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = new Random().Next(1,10);
        }
    }
}


void FindNumber( int[,] matr, int i, int j)
{
    if (i < matr.GetLength(1))
    {
        if (j < matr.GetLength(1))
        {
            Console.WriteLine($"NumberOnPosition[{i}, {j}] = {matr[i,j]}");
        }
        else
        {
            Console.WriteLine($"Element is not exist");
        }
    }
    else
    {
        Console.WriteLine($"Element is not exist");
    }
}



int[,] matrix = new int[5, 5]; // Размер матрицы

int i = 4; // Номер сторки элемета 
int j = 5; // Номер столбца элемента

FillArray(matrix);

PrintArray(matrix);

FindNumber(matrix, i, j);

