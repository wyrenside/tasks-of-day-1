using System.Globalization;

int num = int.Parse(Console.ReadLine());
if
    ((num / 10) > (num % 10))
{
    Console.WriteLine(num / 10);
}
else if
    ((num / 10) < (num % 10))
{
    Console.WriteLine(num % 10);
}
else
{
    Console.WriteLine("Digits are equal");
}