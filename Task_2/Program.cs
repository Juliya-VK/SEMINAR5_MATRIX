//  Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
using System;

class Program
{
    static void Main()
    {
        // Задаем двумерный массив
        int[,] array = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

        Console.WriteLine("Исходный массив:");
        PrintArray(array);

        // Меняем местами первую и последнюю строку
        SwapFirstAndLastRows(array);

        Console.WriteLine("\nМассив после замены:");
        PrintArray(array);
    }

    static void SwapFirstAndLastRows(int[,] array)
    {
        // Получаем количество строк и столбцов в массиве
        int rows = array.GetLength(0);
        int cols = array.GetLength(1);

        // Проверка, что в массиве есть хотя бы две строки
        if (rows >= 2)
        {
            // Создаем временный массив для хранения первой строки
            int[] tempRow = new int[cols];
            for (int j = 0; j < cols; j++)
            {
                tempRow[j] = array[0, j];
            }

            // Копируем последнюю строку в первую
            for (int j = 0; j < cols; j++)
            {
                array[0, j] = array[rows - 1, j];
            }

            // Копируем временный массив (первую строку) в последнюю строку
            for (int j = 0; j < cols; j++)
            {
                array[rows - 1, j] = tempRow[j];
            }
        }
        else
        {
            Console.WriteLine("Массив должен содержать хотя бы две строки для обмена.");
        }
    }

    static void PrintArray(int[,] array)
    {
        int rows = array.GetLength(0);
        int cols = array.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}

