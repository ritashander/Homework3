// Напишите программу, которая принимает на вход координаты двух точек и находит
// расстояние между ними в 3D пространстве.

int x1 = new Random().Next(-10, 10);
int y1 = new Random().Next(-10, 10);
int z1 = new Random().Next(-10, 10);
int x2 = new Random().Next(-10, 10);
int y2 = new Random().Next(-10, 10);
int z2 = new Random().Next(-10, 10);

System.Console.WriteLine($"x1 = {x1}, y1 = {y1}, z1 = {z1}, y2 = {y2}, x2 = {x2}, z2 = {z2}");

double result = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));
System.Console.WriteLine(result);