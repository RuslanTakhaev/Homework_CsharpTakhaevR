// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// Console.WriteLine("enter an integer rows");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("enter an integer cols");
// int cols = Convert.ToInt32(Console.ReadLine());
// int[,] array = new int[rows, cols];

// FillArray(array);
// Console.WriteLine();
// PrintArray(array);

// void FillArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(0, 10);
//         }
//     }
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine("");
//     }
// }

// void FindArray(int[,] array)
// {
// for (int i = 0; i < array.GetLength(0); i++)
//     for (int j = 0; j < array.GetLength(1) - 1; j++)
//         for (int b = 0; b < array.GetLength(1) - 1; b++)
//         {
//             if (array[i, b] < array[i, b + 1]) 
//             {
//                 int temp = 0;
//                 temp = array[i, b];
//                 array[i, b] = array[i, b + 1];
//                 array[i, b + 1] = temp;
//             }
//         }

// }
// FindArray (array);
// Console.WriteLine();
// PrintArray(array);


// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// Console.WriteLine("enter an integer rows");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("enter an integer cols");
// int cols = Convert.ToInt32(Console.ReadLine());
// int[,] array = new int[rows, cols];
// FillArray(array);
// PrintArray(array);
// int min = int.MaxValue;
// int indexLine = 0;
// FindArray(array);


// void FillArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(0, 10);
//         }
//     }
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine("");
//     }
// }

// void FindArray(int[,] array)
// {
// for (int i = 0; i < array.GetLength(0); i++)
// {
//     int sum = 0;
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         sum = sum + array[i, j];        
//     }
//     if (sum < min)
//     {
//         min = sum;
//         indexLine++;
//     }
// }
// }

// Console.WriteLine("Line" + (indexLine) + ",sum " + (min));


// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 5);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine("");
    }
}

int size = InputInt("matrix dimension: ");
int[,] matrixA = new int[size, size];
int[,] matrixB = new int[size, size];
FillArray(matrixA);
FillArray(matrixB);
int[,] matrixC = new int[size, size];

for (int i = 0; i < size; i++)
{
    for (int j = 0; j < size; j++)
    {
        for (int k = 0; k < size; k++)
        {
            matrixC[i, j] = matrixC[i, j] + (matrixA[i, k] * matrixB[k, j]);
        }
    }
}

Console.WriteLine("matrix - A");
PrintArray(matrixA);
Console.WriteLine();
Console.WriteLine("matrix - B");
PrintArray(matrixB);
Console.WriteLine();
Console.WriteLine("Product of matrices A*B");
PrintArray(matrixC);
