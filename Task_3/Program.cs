// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
using System;

class Program
{
    static void Main()
    {
        // Задаем размеры массива
        Console.Write("Введите количество строк: ");
        int rows = int.Parse(Console.ReadLine());

        Console.Write("Введите количество столбцов: ");
        int columns = int.Parse(Console.ReadLine());

        // Создаем двумерный массив
        int[,] array = new int[rows, columns];

        // Заполняем массив случайными числами
        Random random = new Random();
        Console.WriteLine("Исходный массив:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                array[i, j] = random.Next(1, 10);
                Console.Write(array[i, j] + "\t");
            }
            Console.WriteLine();
        }

        // Находим строку с наименьшей суммой элементов
        int minSum = int.MaxValue;
        int minSumRowIndex = -1;

        for (int i = 0; i < rows; i++)
        {
            int currentSum = 0;
            for (int j = 0; j < columns; j++)
            {
                currentSum += array[i, j];
            }

            if (currentSum < minSum)
            {
                minSum = currentSum;
                minSumRowIndex = i;
            }
        }

        // Выводим результат
        Console.WriteLine($"\nСтрока с наименьшей суммой элементов (индексация с нуля): {minSumRowIndex}, сумма: {minSum}");

        // Задержка перед закрытием консоли
        Console.ReadLine();
    }
}
