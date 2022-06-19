// Задайте две матрицы. Напишите программу, которая будет
// находить произведение двух матриц.

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

void MultiplyMatr(int[,] matr,int[,] matr1)
{
    int[,] matr2 = new int[matr.GetLength(0), matr1.GetLength(1)];
          matr2[0, 0] = matr[0,0] * matr1[0,0] + matr[0,1] * matr1[1,0];
          matr2[0, 1] = matr[0,0] * matr1[0,1] + matr[0,1] * matr1[1,1];
          matr2[1, 0]  = matr[0,1] * matr1[0,0] + matr[1,1] * matr1[1,0];
          matr2[1,1]  = matr[0,1] * matr1[0,1] + matr[1,1] * matr1[1,1];
        
    
    PrintArray(matr2);
}

int[,] matrix = new int[2,2];
int[,] matrix1 = new int[2,2];

FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
FillArray(matrix1);
PrintArray(matrix1);
Console.WriteLine();
MultiplyMatr(matrix, matrix1);

