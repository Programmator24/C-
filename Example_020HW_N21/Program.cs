//Напишите программу, которая принимает на
//вход координаты двух точек и находит расстояние между
//ними в 3D пространстве.

int x1 = 4;
int y1 = 4;
int z1 = 8;

int x2 = 4;
int y2 = -3;
int z2 = 6;

int AB = x1-x2;
int BC = y1-y2;
int AC = z1-z2;

double distance = Math.Sqrt( AB*AB + BC*BC + AC*AC); 

Console.WriteLine(distance);