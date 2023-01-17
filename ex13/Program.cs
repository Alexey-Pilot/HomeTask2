Console.Clear();
Console.Write("Insert the number ");
int num = Convert.ToInt32(Console.ReadLine());

if (num > 99)
{
  while (num > 999)
  {
    num = num / 10;
  }
  num = num % 10;
  Console.WriteLine($"The third digit {num}");
}
else
{
  Console.WriteLine("There is no 3rd digit");
}
