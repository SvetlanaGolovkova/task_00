﻿//  Напишите программу, которая принимает на вход
// трёхзначное число и на выходе показывает последнюю цифру
// этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8

Console.WriteLine("Введите целое трехзначное число num: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"последняя цифра числа {num} = {num%10}");

// else if (num1 != square)
