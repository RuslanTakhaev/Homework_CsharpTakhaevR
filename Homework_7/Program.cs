// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// Console.WriteLine("enter an integer rows");                     
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("enter an integer cols");                  
// int cols = Convert.ToInt32(Console.ReadLine());
// double [,] array = new double [rows,cols];
// FillArray(array);
// PrintArray(array);


//  void FillArray(double[,] array)
//  {
//     for (int i = 0; i < array.GetLength (0); i++)
//          for (int j = 0; j < array.GetLength (1); j++)
//          array[i,j] = Convert.ToDouble(new Random().Next(-100, 100))/10;
//  }


//  void PrintArray(double[,] array)
//  {
//     for (int i = 0; i < array.GetLength (0); i++)
//     {
//          for (int j = 0; j < array.GetLength (1); j++)
//          Console.Write($"{array [i,j]}3 \t");
//          Console.WriteLine();
//     }
//  }


// Задача 50. Напишите программу, которая на вход принимает значение элемента в двумерном массиве, и возвращает позицию этого элемента 
// или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

// Console.WriteLine("enter an integer");
// int N = Convert.ToInt32(Console.ReadLine ());
// int [,] array = new int [3,4];
// FillArray(array);
// PrintArray(array);
// Search(array);

//  void FillArray(int[,] array)
//  {
//     for (int i = 0; i < array.GetLength (0); i++)
//          for (int j = 0; j < array.GetLength (1); j++)
//          array[i,j] = new Random().Next(-10, 11);
//  }


//  void PrintArray(int[,] array)
//  {
//     for (int i = 0; i < array.GetLength (0); i++)
//     {
//          for (int j = 0; j < array.GetLength (1); j++)
//          Console.Write($"{array [i,j]} \t");  
//          Console.WriteLine();
//     }
//  }


//  void Search (int[,] array)
//  { bool find = false;
//     for (int i = 0; i < array.GetLength (0); i++)
//          for (int j = 0; j < array.GetLength (1); j++)
//     {
//         if (N == array [i,j])
//         {
//         find = true;
//         break;
//         }
//     }
//     Console.WriteLine($"{N} {find}");
//  }


// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.WriteLine("enter an integer rows");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter an integer cols");
int cols = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[rows, cols];
FillArray(array);
PrintArray(array);
AverageArray(array);


void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(0, 10);
}


void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j]} \t");
        Console.WriteLine();
    }
}

void AverageArray(int[,] array)
{
for (int j = 0; j < array.GetLength(1); j++)
{
 double average = 0;

    for (int i = 0; i < array.GetLength(0); i++)
        
        {
            average=(average + array[i, j]);
        }
    average = average /rows;

    Console.Write(average + ";");
}
}