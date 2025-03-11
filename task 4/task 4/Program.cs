int Score = int.Parse(Console.ReadLine());
if
     ((Score > 100) && (Score < 0)) 
{
    Console.WriteLine("That ammount of score is not possible");
}
else if
    (Score >= 91)
{
    Console.WriteLine("A");
}
else if
    (Score >= 81)
{
    Console.WriteLine("B");
}
else if
    (Score >= 71)
{
    Console.WriteLine("C");
}
else if
    (Score >= 61)
{
    Console.WriteLine("D");
}
else if
    (Score >= 51)
{
    Console.WriteLine("E");
}
else if
    (Score < 51)
{
    Console.WriteLine("F");
}