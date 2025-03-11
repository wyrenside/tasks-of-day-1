int[] numbers = new int[10];
int sum = 0;
for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = int.Parse(Console.ReadLine());
    sum = sum + numbers[i];
}
{
    Console.WriteLine(sum / numbers.Length);
}
