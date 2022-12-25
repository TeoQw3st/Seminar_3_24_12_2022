
Console.WriteLine("Задача №17, опеределяет по координатам в какой четверти находится объет");
Console.WriteLine("Введите координату Х ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y ");
int y = Convert.ToInt32(Console.ReadLine());
if (y>0 && x>0)
{
Console.WriteLine($"Точка находится в 1ой четвери");
}
else if (y>0 && x<0)
{
Console.WriteLine($"Точка находится в 2ой четвери");
}
else if (y<0 && x<0)
{
Console.WriteLine($"Точка находится в 3ей четвери");
}
else if (y<0 && x>0)
{
Console.WriteLine($"Точка находится в 4ой четвери");
}
else
{
    Console.WriteLine($"Неверные кооридинаты");
}