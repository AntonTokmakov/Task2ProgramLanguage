﻿Console.WriteLine("Программа для расчета растояния между двух точек");
Console.WriteLine("Введите координаты точки A:");
Console.Write("x: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("y: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("z: ");
double z1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координаты точки B:");
Console.Write("x: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("y: ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("z: ");
double z2 = Convert.ToDouble(Console.ReadLine());

double rast = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));

Console.WriteLine($"Расстояние между точками равно {rast}");

Console.ReadLine();