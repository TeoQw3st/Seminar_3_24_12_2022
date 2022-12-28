
string functionmassive (string massive)
{
    int size = massive.Length;
    int index = 0;
    while (index < size/2)
        {
            int temp = massive[index];
            massive[index] = massive[size-index-1];
            massive[size-index-1]=temp;
            index+=1;
        }
return massive;
}

Console.WriteLine("Мы будем пробовать решить задачу №19 через функцию переворота массива");
Console.WriteLine("Введите пятизначное число");
int number = Convert.ToInt32(Console.ReadLine());
string massivenumber = number.ToString();
Console.WriteLine($"перевели в массив {massivenumber}");
int size = massivenumber.Length;
Console.WriteLine($"рамзмер массива {size}");
//int ferstindex = 0;
//int secondindex = size-1;
string massivenumber1 = functionmassive(massivenumber);
Console.WriteLine (massivenumber1);
