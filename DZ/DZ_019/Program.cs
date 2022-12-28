// See https://aka.ms/new-console-template for more information
Console.WriteLine("Мы будем пробовать решить задачу №19 через массив");
Console.WriteLine("Введите любое число");
long number = Convert.ToInt64(Console.ReadLine());
string massivenumber = number.ToString();
Console.WriteLine($"перевели в массив {massivenumber}");
int size = massivenumber.Length;
Console.WriteLine($"рамзмер массива {size}");
int ferstindex = 0;
int secondindex = size-1;
int count = 0;
int count2 = 0;
while (ferstindex < size/2)
    {
        if (massivenumber[ferstindex] == massivenumber[secondindex])
        {
            ferstindex = ferstindex +1;
            secondindex = secondindex - 1;
            count = count +1;
            //if (massivenumber[ferstindex] == massivenumber[secondindex])
            //{
                //Console.WriteLine($"Введеное число является палиндромом");
            //}
            //else
            //{
                //Console.WriteLine($"Введеное число не является палиндромом");
            //}
        }
        else
        {
            //Console.WriteLine($"Введеное число не является палиндромом");
        
            ferstindex = ferstindex +1;
            secondindex = secondindex - 1;
            count2 = count2+1;
        }
            
            
    }
if (count == size/2)
{
    Console.WriteLine($"Количество успешных проверок равно {count}");
    Console.WriteLine($"Введеное число {number} является полидромом");
}
else
{
    Console.WriteLine($"Количество не успешных проверок равно {count2}");
    Console.WriteLine($"Введеное число {number} не является полидромом");
}