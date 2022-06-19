// Сформируйте трёхмерный массив из неповторяющихся
//двузначных чисел. Напишите программу, которая будет построчно выводить
//массив, добавляя индексы каждого элемента.

void FillArray(int[,,] matr)
{ 
    int x = 10;
    for(int i = 0; i < matr.GetLength(0); i++)
    {
        for(int j = 0; j < matr.GetLength(1); j++)
        {
            for(int k = 0; k < matr.GetLength(2); k++)
            {
                matr[i,j,k] = x++;
            }
        }
    }
}


void PrintArray(int[,,] matr)
{
    for(int i = 0; i < matr.GetLength(0); i++)
    {
        for(int j = 0; j < matr.GetLength(1); j++)
        {
            for(int k = 0; k < matr.GetLength(2); k++)
            {
                Console.Write($"{matr[i,j,k]} ");
            }
        }
        Console.WriteLine();
    }
}

void OutputArray(int[,,] matr)
{
    for(int i = 0; i < matr.GetLength(0); i++)
    {
        for(int j = 0; j < matr.GetLength(1); j++)
        {
            for(int k = 0; k < matr.GetLength(2); k++)
            {
                Console.WriteLine($"[{i},{j},{k}]={matr[i,j,k]} ");
            }
        }
    }
}

int[,,] matrix = new int[2,2,2];

FillArray(matrix);
PrintArray(matrix);
OutputArray(matrix);