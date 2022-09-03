// // Задача 54: Задайте двумерный массив. Напишите программу, 
// // которая упорядочит по убыванию элементы каждой строки двумерного массива.

// Console.Clear();

// Console.Write("Введите количество строк массива: ");
// int rows=int.Parse(Console.ReadLine());

// Console.Write("Введите количество столбцов массива: ");
// int columns=int.Parse(Console.ReadLine());

// int[,] array = GetArray(rows, columns, 0, 10);
// PrintArray(array);
// ReversArray(array);
// Console.WriteLine();
// PrintArray(array);

// int[,] GetArray(int m, int n, int minValue, int maxValue)
// {
//     int[,] result = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             result[i, j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return result;
// }

// void PrintArray(int[,] inArray)
// {
//     for (int i = 0; i < inArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < inArray.GetLength(1); j++)
//         {
//             Console.Write($"{inArray[i,j]} ");
//         }
//         Console.WriteLine();
//     }
// }
// void ReversArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = j+1; k < array.GetLength(1); k++)
//             {
//                 if (array[i,k] > array[i,j])
//                 {
//                     int temp = array[i,j];
//                     array[i,j] = array[i,k];
//                     array[i,k] = temp;
//                 }
//             }
//         }
//     }
// }



// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Console.Clear();
// Console.WriteLine("введите размер квадратного массива");
// int mass = Convert.ToInt32(Console.ReadLine());
// int[,] numbers = new int[mass, mass];
// RandomArray(numbers);
// PrintArray(numbers);
// int minsum = Int32.MaxValue;
// int row = 0;

// for (int i = 0; i < numbers.GetLength(0); i++)
// {
//     int sum = 0;
//     for (int j = 0; j < numbers.GetLength(1); j++)
//     {
//         sum = sum + numbers[i, j];   
//     }
//     if (sum < minsum)
//     {
//         minsum = sum;
//         row++;   
//     }
// }
// Console.WriteLine("Cтрока с наименьшей суммой елементов: " + (row));
// void RandomArray(int[,] array)
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
       


// // Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

// Console.Clear();
// int InputInt(string output)
// {
//     Console.Write(output);
//     return int.Parse(Console.ReadLine());
// }

// void RandomArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(1, 10);
//         }
//     }
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         Console.Write("[ ");
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.Write("]");
//         Console.WriteLine("");
//     }
// }

// int size = InputInt("размерность матриц: ");
// int[,] matrixA = new int[size, size];
// int[,] matrixB = new int[size, size];
// RandomArray(matrixA);
// RandomArray(matrixB);
// int[,] matrixC = new int[size, size];

// for (int i = 0; i < size; i++)
// {
//     for (int j = 0; j < size; j++)
//     {
//         for (int k = 0; k < size; k++)
//         {
//             matrixC[i, j] = matrixC[i, j] + (matrixA[i, k] * matrixB[k, j]);
//         }
//     }
// }
// Console.WriteLine("Матрица - А");
// PrintArray(matrixA);
// Console.WriteLine();
// Console.WriteLine("Матрица - В");
// PrintArray(matrixB);
// Console.WriteLine();
// Console.WriteLine("Произведение матриц А*В");
// PrintArray(matrixC);


// Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

// Console.Clear();
// int str = InputInt("Введите длинну строк: ");
// int row = InputInt("Введите колличество столбцов: ");
// int depth = InputInt("Введите глубину массива: ");
// int countNums = 89;

// if (str * row * depth > countNums)
// {
//     Console.Write("Массив слишком большой");
//     return;
// }

// int[,,] resultNums = CreateMassive(str, row, depth);

// for (int i = 0; i < resultNums.GetLength(0); i++)
// {
//     for (int j = 0; j < resultNums.GetLength(1); j++)
//     {
//         for (int k = 0; k < resultNums.GetLength(2); k++)
//         {
//             Console.WriteLine($"[{i},{j},{k}] - {resultNums[i, j, k]}");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// int[,,] CreateMassive(int size1, int size2, int size3)
// {
//     int[,,] array = new int[size1, size2, size3];
//     int[] values = new int[countNums];
//     int num
//      = 10;
//     for (int i = 0; i < values.Length; i++)
//         values[i] = num
//         ++;

//     for (int i = 0; i < values.Length; i++)
//     {
//         int randomInd = new Random().Next(0, values.Length);
//         int temp = values[i];
//         values[i] = values[randomInd];
//         values[randomInd] = temp;
//     }

//     int valueIndex = 0;

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(2); k++)
//             {
//                 array[i, j, k] = values[valueIndex++];
//             }
//         }
//     }
//     return array;
// }

// int InputInt(string output)
// {
//     Console.Write(output);
//     return int.Parse(Console.ReadLine());
// }


// Задача 62: Заполните спирально массив 4 на 4.

// Console.Clear();
// int n = 5;
// int[,] Matrix = new int[n, n];

// int temp = 1;
// int i = 0;
// int j = 0;

// while (temp <= Matrix.GetLength(0) * Matrix.GetLength(1))
// {
//   Matrix[i, j] = temp;
//   temp++;
//   if (i <= j + 1 && i + j < Matrix.GetLength(1) - 1)
//     j++;
//   else if (i < j && i + j >= Matrix.GetLength(0) - 1)
//     i++;
//   else if (i >= j && i + j > Matrix.GetLength(1) - 1)
//     j--;
//   else
//     i--;
// }

// WriteArray(Matrix);

// void WriteArray (int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       if (array[i,j] / 10 <= 0)
//       Console.Write($" {array[i,j]} ");

//       else Console.Write($"{array[i,j]} ");
//     }
//     Console.WriteLine();
//   }
// }
