using System;

// Console.Write("Введите первое целое число: ");
// int num1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите второе целое число: ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// int sum = num1 + num2;
// int diff = num1 - num2;
// int prod = num1 * num2;
// double quot = (double)num1 / num2;

// Console.WriteLine(sum);
// Console.WriteLine(diff);
// Console.WriteLine(prod);
// Console.WriteLine(quot);

//2 задание

Console.Write("Введите имя: ");
string name = Console.ReadLine();

Console.Write("Введите возраст: ");
int age = int.Parse(Console.ReadLine());

Console.Write("Введите любимый язык программирования: ");
string language = Console.ReadLine();

Console.WriteLine($"Привет, {name}!");
Console.WriteLine($"Тебе {age} лет.");
Console.WriteLine($"Твой любимый язык программирования — {language}");