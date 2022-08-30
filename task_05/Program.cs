// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// Напишите программу, которая на вход принимает
// одно число (N), а на выходе показывает все целые
// числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
// 2 -> " -2, -1, 0, 1, 2"

Console.WriteLine("Введите целое число num: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Вывод числа в промежутке от -N до N: ");
for (int i = -num; i<=num; i++)
{
  Console.Write(i + " ");
}