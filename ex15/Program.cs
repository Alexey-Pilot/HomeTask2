Console.Clear();
Console.WriteLine("Введите номер дня");
int day = Convert.ToInt32(Console.ReadLine());
while (day > 7 || day < 1)
{
  Console.WriteLine("В неделе 7 дней");
  day = Convert.ToInt32(Console.ReadLine());
}


if (day < 6)
{
  Console.WriteLine("Нет!");
}
else{
  Console.WriteLine("Да!");
}