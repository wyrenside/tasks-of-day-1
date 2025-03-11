using System.ComponentModel.Design;

int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
if
    ((a % 2 == 0) && (b % 2 ==0))
{
    Console.WriteLine(a + b);
}
else if
    ((a % 2 != 2) || (b % 2 != 0)) 
{
    Console.WriteLine("Insert even numbers");
}