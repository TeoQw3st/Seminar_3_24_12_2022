// See https://aka.ms/new-console-template for more information
Console.WriteLine("Мы будем пробовать решить задачу №19 через массив");
Console.WriteLine("Введите пятизначное число");
int number = Convert.ToInt32(Console.ReadLine());
string massivenumber = number.ToString();
Console.WriteLine($"перевели в массив {massivenumber}");
int size = massivenumber.Length;
Console.WriteLine($"рамзмер массива {size}");
int ferstindex = 0;
int secondindex = size-1;

if (massivenumber[ferstindex] == massivenumber[secondindex])
{
    // while (ferstindex < size/2)
    //{
    ferstindex = ferstindex +1;
    secondindex = secondindex - 1;
    //}
    Console.WriteLine($"Введеное число является палиндромом");
}
else
{
     Console.WriteLine($"Введеное число не является палиндромом");
}

