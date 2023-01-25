// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. Обращаться к числу как к строке нельзя.
// 456 -> 5
// 782 -> 8
// 918 -> 1

// Console.WriteLine("Enter a three digit number");
// int N = Convert.ToInt32(Console.ReadLine ());
// while (N >100)
// {
//     N=N/10;
// }
// int result = N % 10;
// Console.WriteLine($"{result}");


// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. Обращаться к числу как к строке нельзя.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// Console.WriteLine("enter an integer");
// int N = Convert.ToInt32(Console.ReadLine());
// if (N<=99)
// {
//    Console.WriteLine("no"); 
// }
// while (N>999)
// {
//     N=N/10;
// }
// int result = N % 10;
// Console.WriteLine($"{result}");


// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Enter the number of the day of the week");
int dayNumder = Convert.ToInt32(Console.ReadLine ());

if (dayNumder ==6 || dayNumder ==7) 
{
Console.WriteLine("Yes");
}
else if (dayNumder <1 || dayNumder > 7)
{
    Console.WriteLine("Not a day of the week");
}
else 
{
Console.WriteLine("No");
}