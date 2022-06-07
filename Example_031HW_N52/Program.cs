// Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.


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

void FindAvarage( int[,] matr)
{
    double sum = 0; // Сумма элементов столбика
    double num = 0; // колличество элементов столбика

    for(int i = 0; i < matr.GetLength(1); i++)
    {
        for(int j = 0; j < matr.GetLength(0); j++)
        {
           sum = sum + matr[i,j]; 
           num = num + 1; 
        }
        Console.WriteLine($"  среднне арифметическое столбца {i+1} = {sum/a}");
        sum = 0;
        a = 0;
    }
}



int[,] matrix = new int[5, 5];

FillArray(matrix);

PrintArray(matrix);

FindAvarage(matrix);
