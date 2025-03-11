int num1 = 1;
int num2 = 1;
for
    (int i = 0; i < 10; i++)
{
    Console.WriteLine(num1);
    num2 += num1;
    num1 = num2 - num1;
}
