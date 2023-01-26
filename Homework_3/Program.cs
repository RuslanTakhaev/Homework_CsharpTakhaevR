// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. 
// Через строку решать нельзя.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Console.WriteLine("enter an integer");
// string? number = Console.ReadLine();

// void CheckingNumber(string number)
// {
//     if (number[0] == number[4] || number[1] == number[3])
//     {
//         Console.WriteLine($"{number} - Yes.");
//     }
//     else Console.WriteLine($"{number} -No.");
// }

// if (number!.Length == 5)
// {
//     CheckingNumber(number);
// }
// else Console.WriteLine($"Invalid number entered");

// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// Console.WriteLine("enter an integer x1");
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("enter an integer y1");
// int y1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("enter an integer z1");
// int z1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("enter an integer x2");
// int x2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("enter an integer y2");
// int y2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("enter an integer z2");
// int z2 = Convert.ToInt32(Console.ReadLine());

// double Dist = Math.Sqrt (Math.Pow ((x2-x1),2) + Math.Pow ((y2-y1),2) + Math.Pow(z2 - z1, 2));
// Console.WriteLine($"The distance is {Dist}");

// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


Console.WriteLine("enter number");
int n = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= n; i++)
{
   Console.Write ($"{i*i*i}");
        Console.WriteLine (" ");
}