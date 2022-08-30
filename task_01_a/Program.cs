// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
Console.WriteLine("Введите целое число num1: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите целое число num2: ");
int num2 = Convert.ToInt32(Console.ReadLine());
int square = num2 * num2;
if (num1 == square )
{Console.WriteLine($"первое число является квадратом второго");
}
else if (num1 != square)
{Console.WriteLine($"первое число не является квадратом второго");
}
