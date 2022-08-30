// // Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Введите число num1: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число num2: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2 )
{Console.WriteLine($"первое число больше второго");
}
else if (num2 > num1)
{Console.WriteLine($"второе число больше первого");
}