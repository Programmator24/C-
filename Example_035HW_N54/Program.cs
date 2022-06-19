// Задайте двумерный массив. Напишите программу, которая
// упорядочит по убыванию элементы каждой строки двумерного массива.


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

void StreamLineArray(int[,] matr)
{
    
    for(int i = 0; i < matr.GetLength(0); i++)
    {
        for (int x = 0; x < matr.GetLength(1); x++)
        {
           for(int j = 0; j < matr.GetLength(1)-1; j++)
           {
              if(matr[i,j] < matr[i,j+1])
              {
                  int z = matr[i,j];
                  matr[i,j] = matr[i,j+1];
                  matr[i,j+1] = z;

              }
           }
        }
    }
}

int[,] matrix = new int [2,7];
FillArray(matrix);
PrintArray(matrix);
StreamLineArray(matrix);
Console.WriteLine();
PrintArray(matrix);


