Console.Clear();
Console.WriteLine("Вводите числа, чтобы прекратить нажмите 0");
int i = Convert.ToInt32(Console.ReadLine());
int max1 = i;
int max2 = i;
while (i != 0)
{
  i = Convert.ToInt32(Console.ReadLine());
  if (i > max1)
  {
    max2 = max1;
    max1 = i;  
  }
  else if (i > max2 && i < max1)  // на случай, если встречаются одинаковые числа
  max2 = i;

}
Console.WriteLine($"Второе по величине число {max2}");