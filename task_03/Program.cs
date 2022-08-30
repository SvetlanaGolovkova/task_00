using System.Security.AccessControl;

// 3. Напишите программу, которая будет выдавать
// название дня недели по заданному номеру.
// 3 -> Среда
// // 5 -> Пятница
Console.WriteLine("Введите число 0 < num < 7: ");
int num = Convert.ToInt32(Console.ReadLine());
// // if (0 < num < 7)
if (num == 1) System.Console.WriteLine("понедельник");
else if (num == 2 ) System.Console.WriteLine("вторник");
else if (num == 3 ) System.Console.WriteLine("среда");
else if (num == 4 ) System.Console.WriteLine($"четверг");
else if (num == 5 ) System.Console.WriteLine($"пятница");
else if (num == 6 ) System.Console.WriteLine($"суббота");
else if (num == 7 ) System.Console.WriteLine($"воскресенье");
else System.Console.WriteLine("число не входит в диапозон от 0 до 7");
