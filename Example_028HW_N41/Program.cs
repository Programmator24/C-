// Пользователь вводит с клавиатуры M чисел.
//Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2

Console.WriteLine("Введитие массив чисел через пробел");
int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
Console.WriteLine(String.Join(" ", array));

int sise = array.Length;
int count = 0;
for (int n = 0; n < sise; n++)
{
    if (array[n] > 0)
    {
        count = count + 1;
    }
}

Console.WriteLine(count);



