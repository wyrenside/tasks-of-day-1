 

int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());
int sum = 0;
if
    (a % 5 == 0)
{
    sum += a;
}
if 
    (b % 5 == 0)
{
    sum += b;
}
if
    (c % 5 == 0)
{
    sum += c;
}
Console.WriteLine(sum);