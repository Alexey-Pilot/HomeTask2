Console.Clear();
Console.Write("Введите трехзначное число ");
int num = Convert.ToInt32(Console.ReadLine());
while (num < 100 || num > 999)
{
  Console.WriteLine("Введите трехзначное число!!!");
  num = Convert.ToInt32(Console.ReadLine());
}
int num2 = num % 100 / 10;
Console.WriteLine($"Вторая цифра чила {num} это {num2}");