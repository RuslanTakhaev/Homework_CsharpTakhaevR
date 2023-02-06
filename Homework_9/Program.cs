// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// Console.WriteLine("enter an integer");
// int N = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(AllNumber (N));

// string AllNumber(int N)                
// {
//     if (N == 1) return $"1";
//     return $"{N} " + AllNumber(N - 1);        
                                        
// }


// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// Console.WriteLine("enter an integer M");
// int M = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("enter an integer N");
// int N = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(SummaRec(M,N));

// int SummaRec(int M, int N)                
// {
//     if (N == M) return N;
//     return N + SummaRec(M,N - 1);         
// }

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("enter an integer m");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter an integer n");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"A({m}, {n}) = {Akkerman(m, n)}");

int Akkerman(int m, int n)
{
    if (m == 0)
        return n + 1;
    if (m > 0 && n == 0)
        return Akkerman(m - 1, 1);
    else
        return Akkerman(m - 1, Akkerman(m, n - 1));
}