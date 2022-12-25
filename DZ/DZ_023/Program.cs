Console.WriteLine("Решение задачи №23: Эта программа будет выдавать кубы чисел от 1 до числа N");
Console.WriteLine("Введите число N");
int number = Convert.ToInt32(Console.ReadLine());
int n = 1;
while (n<=number) 
{
    int scuare = Convert.ToInt32(Math.Pow(n, 3));
    Console.WriteLine($"Кубы числа от 1 до {number}: куб числа {n} равен {scuare};"); 

    n = n + 1; 
}