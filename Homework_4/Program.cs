// Задача 25: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// Console.WriteLine("enter number a");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("enter number b");
// int b = Convert.ToInt32(Console.ReadLine());

// int step = a;

// for (int i = 1; i < b; i++)
// {
// step = step * a;
// }
// Console.WriteLine (step);


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. Через строку решать нельзя.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

//  Console.WriteLine("enter number");
//  int n = Convert.ToInt32(Console.ReadLine());
// int sum = 0;

// while (n > 0)
// {
// int num = n % 10;
// n = n / 10;
// sum = sum + num;
// }
// Console.WriteLine(sum);


//  Задача 29. Напишите программу, которая задаёт массив из 8 целых чисел с клавиатуры и далее выводит массив на экран в одну строку.

int[] array = { 6, 5, 4, 3, 2, 1, 7, 8 };
string[] stringarray = new string[1];
void PrintArray(int[] array)
{
   
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

PrintArray(array);