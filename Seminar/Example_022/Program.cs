Console.WriteLine("Эта программа будет выдавать квадраты чисел от 1 до числа N");
Console.WriteLine("Введите число N");
int number = Convert.ToInt32(Console.ReadLine());
int n = 1;
int scuare = 0;
while (n<=number) 
{
    scuare = Convert.ToInt32(Math.Pow(n, 2));
    Console.WriteLine($"Квадратные числа от 1 до {number}: квадрат числа {n} равен {scuare};"); 

    n = n + 1; 
}