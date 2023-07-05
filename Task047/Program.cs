// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

using System;
class Program
{
    static void Main()
    {
        int m = 3;// Задаем кол-во строк
        int n = 4; // Задаем кол-во столбцов

          // Задаем двухьерный массив
          double[, ] array = new double [m , n];

          // Создаем генератор чисел
          Random random = new Random();

          // Заполняем массив случайными числами 

          for (int i = 0; i < m; i++)
          {
            for (int j = 0; j < n; j++)
            {
                array[i, j] = random.NextDouble();
            }
          } 
          // Выводим массив на экран
          for (int i = 0; i < m; i++)
          {
            for (int j = 0; j < n; j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
          }
    }
}