﻿Console.WriteLine("Задача №21, опеределяет расстояние между двумя точками в системе координат");
Console.WriteLine("Введите для точки А координату Х ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите для точки А координату Y ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите для точки B координату Х ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите для точки B координату Y ");
int y2 = Convert.ToInt32(Console.ReadLine());

int ac = x1 - x2;
Console.WriteLine($"Расстояние АС равно {ac}");
int bc = y1 - y2;
Console.WriteLine($"Расстояние BC равно {bc}");

double sac = Convert.ToInt32(Math.Pow(ac, 2));
Console.WriteLine($"квадрат АС равен {sac}");
double sab = Convert.ToInt32(Math.Pow(bc, 2));
Console.WriteLine($"квадрат BC равен {sab}");
double ab = Math.Sqrt(sac + sab);
Console.WriteLine($"расстояние между точками A и B равно {ab:f3}");