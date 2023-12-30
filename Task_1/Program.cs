// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.

using System;

class Program
{
    static void Main()
    {
        // Исходный двумерный массив
        int[,] array = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

        // Получаем от пользователя индексы элемента
        Console.WriteLine("Введите индекс строки:");
        int rowIndex;
        while (!int.TryParse(Console.ReadLine(), out rowIndex) || rowIndex < 0 || rowIndex >= array.GetLength(0))
        {
            Console.WriteLine("Некорректный ввод. Пожалуйста, введите корректный индекс строки:");
        }

        Console.WriteLine("Введите индекс столбца:");
        int columnIndex;
        while (!int.TryParse(Console.ReadLine(), out columnIndex) || columnIndex < 0 || columnIndex >= array.GetLength(1))
        {
            Console.WriteLine("Некорректный ввод. Пожалуйста, введите корректный индекс столбца:");
        }

        // Проверяем, существует ли элемент с введенными индексами
        if (rowIndex < array.GetLength(0) && columnIndex < array.GetLength(1))
        {
            // Выводим значение элемента
            int element = array[rowIndex, columnIndex];
            Console.WriteLine($"Значение элемента по заданным индексам: {element}");
        }
        else
        {
            // Сообщаем, что элемента с такими индексами нет
            Console.WriteLine("Элемента с заданными индексами не существует.");
        }

        // Ждем, пока пользователь нажмет клавишу перед закрытием окна
        Console.ReadKey();
    }
}


 