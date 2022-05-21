// Задача 13: Напишите программу, которая выводит
//третью цифру заданного числа или сообщает, что третьей
//цифры нет.

Console.WriteLine("Введите число");
string text = (Console.ReadLine());
Array.ConvertAll(text.Split(),int.Parse);
int length = text.Length; 
if (length < 3)
{
   Console.WriteLine("no third number"); 
}
else 
{
    Console.WriteLine(text[2]); 
}

