// See https://aka.ms/new-console-template for more information
Console.WriteLine("эксперимент'");
int n = Convert.ToInt32(Console.ReadLine());
int sn = n % 10;
//int pn = sn/10;
Console.WriteLine(n);
Console.WriteLine(sn);
//Console.WriteLine(pn);

int number1 = Convert.ToInt32(Console.ReadLine());
string massivenumber1 = number1.ToString();
int number2 = Convert.ToInt32(Console.ReadLine());
string massivenumber2 = number2.ToString();
if (massivenumber1==massivenumber2)
{
    Console.WriteLine("массивы равны");

}
else
{
    Console.WriteLine("массивы не равны");
}