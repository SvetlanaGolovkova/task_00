//  Напишите программу, которая принимает на вход
// трёхзначное число и на выходе показывает последнюю цифру
// этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8

Console.WriteLine("Введите трехзначное число num: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num < 0)
{
  Console.WriteLine($"последняя цифра числа {num * -1 % 10}");
}
else
{
  {Console.WriteLine($"последняя цифра числа {num%10}");}
}


// else if (num1 != square)
