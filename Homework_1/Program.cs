﻿// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

// Console.WriteLine("enter an integer 1");
// int a = Convert.ToInt32(Console.ReadLine ());
// Console.WriteLine("enter an integer 2");
// int b = Convert.ToInt32(Console.ReadLine ());
// if (a>b)
// {
//   Console.WriteLine($" max {a} min {b}");                      
// }
// else if (a<b)
// {
//   Console.WriteLine($" max {b} min {a}");
// }

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

// Console.WriteLine("enter an integer 1");
// int a = Convert.ToInt32(Console.ReadLine ());
// Console.WriteLine("enter an integer 2");
// int b = Convert.ToInt32(Console.ReadLine ());
// Console.WriteLine("enter an integer 3");
// int c = Convert.ToInt32(Console.ReadLine ());
// if (a>b && a>c)
// {
//     Console.WriteLine ("max" + a);
// }
// else if (a<b && b>c)
// {
//      Console.WriteLine ("max" + b);
// }
// else if (a<c && c>b)
// {
//      Console.WriteLine ("max" + c);
// }

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

//  Console.WriteLine("enter an integer");
//  int x = Convert.ToInt32(Console.ReadLine ());
//  int remains = x % 2;
//  if (remains ==0)
//  {
// Console.WriteLine("Yes");
// }
// else 
// {
//  Console.WriteLine("No");   
// }

// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("enter number");
int n = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= n; i++)
    if (i % 2 == 0)
        Console.WriteLine(i);

