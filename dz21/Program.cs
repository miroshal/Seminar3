// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

Console.Write("Введите координаты точки A: ");
int x = Convert.ToInt32(Console.ReadLine());
int y = Convert.ToInt32(Console.ReadLine());
int z = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координаты точки B: ");
int x1 = Convert.ToInt32(Console.ReadLine());
int y1 = Convert.ToInt32(Console.ReadLine());
int z1 = Convert.ToInt32(Console.ReadLine());

double S = Math.Sqrt(Math.Pow((x1-x), 2) + Math.Pow((y1-y), 2) + Math.Pow((z1-z), 2));

Console.WriteLine(Math.Round(S, 2));