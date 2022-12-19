﻿/*Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9
*/
/*
Console.WriteLine("Задайте двумерный массив размером mхn."); // условие задачи
        Console.WriteLine("Введите m:"); // создание кнопки для ввода переменной m
        int rowLength = Convert.ToInt32(Console.ReadLine()); // вычисление для значения m, которой соответствует кол-во строк
        Console.WriteLine("Введите n:"); // создание кнопки для вввода переменной n
        int columnLength = Convert.ToInt32(Console.ReadLine()); // вычисление для значения n, которой соответствует кол-во столбцов

        double[,] twoDimensionalArray = new double[rowLength, columnLength]; // создание двумерного массива
        RandomFillTwoDimensionalArray(twoDimensionalArray); // заполнение двумерного массива случайными числами
        PrintArray(twoDimensionalArray); // печать массива

        static void RandomFillTwoDimensionalArray(double[,] array) // метод заполнения двумерного массива случайными вещественными числами
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = new Random().NextDouble() * new Random().Next(-10, 10); // определение интервала заполнения массива случайными числами
                }
            }
        }

     static void PrintArray(double[,] incomingArray) // метод печати массива
        {
        for (int i = 0; i < incomingArray.GetLength(0); i++)
        {
        for (int j = 0; j < incomingArray.GetLength(1); j++)
        {
        Console.Write($"{Math.Round(incomingArray[i, j], 2)} ");
        }
        Console.WriteLine();
        }
       
        */

       
       
        /*Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

17 -> такого числа в массиве нет
*/
/*
Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

17 -> такого числа в массиве нет
*/
/*
 int[,] array = GenerateNewTwoDimensionalArray(); //ввод двумерного массива
            string index = ReadNumberFromConsole(array.GetLength(0), array.GetLength(1));// определение строки индекса массива
            PrintTwoDimensionalArray(array); // печать двумерного массива
            SearchAndWriteNumberFromArray(index, array); // поиск числа из двумерного масива



        static int[,] GenerateNewTwoDimensionalArray() // метод создания двумерного массива
        {
            int[,] array = new int[3, 4]; // внесение размерности массива в соответствии с примером задачи
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = new Random().Next(1, 10); // определение интервала заполнения заполнения массива случайными числами
                }
            }
            return array;
        }
        static string ReadNumberFromConsole(int index0=3, int index1=4) // метод чтения чисел в консоли
        {
            while (true)
            {
                             Console.WriteLine("В заданном массиве " + index0 + " строки " +
                "и " + index1 + " столбца.");
                Console.Write("Введите число от 1, где первая цифра будет номером строки, " +
                "а вторая номером столбца: ");
                string? inputNumber = Console.ReadLine();
                if (int.TryParse(inputNumber, out int number))
                {
                    return inputNumber;
                }
                Console.WriteLine("Вы ввели не число!");
            }
        }

        static void SearchAndWriteNumberFromArray(string index, int[,] array) // метод поска заданного числа
        {
            int[] digits = index.Select(c => (int)char.GetNumericValue(c)).ToArray(); // ввод целого числа, которому соответствует индекс заданного двумерного массива

            try //Блок, содержащий защищенный код, который может вызвать исключение
            {
                   Console.WriteLine(index + " -> " + array[(digits[0]) - 1, (digits[1]) - 1]);
            }
            catch (IndexOutOfRangeException) // оператор который обрабатывает исключение, при выходе из индексов заданного массива
            {
                Console.WriteLine(index + " -> такого числа в массиве нет (индекс " + index + " не существует)"); // ответ на пример задачи
            }
        }

         static void PrintTwoDimensionalArray(int[,] array) // метод печати массива
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


    */

   /* Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

int[,] Array2_D(int row, int column, int from, int to) //метод coздания двумерного массива
{
    int[,] array = new int[row, column];

    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
        array[i, j] = new Random().Next(from, to);
    return array;
}

void ArithmeticMean(int[,] array) //метод вычисления среднего арифметического в двумерном массиве
{
    int row = array.GetLength(0);
    int column = array.GetLength(1);
    double result;

    for (int i = 0; i < column; i++)
    {
        result = 0;
        for (int j = 0; j < row; j++) result += array[j, i];
        Console.Write($"{Math.Round(result / row, 2)}; ");

    }

}

Console.Write("Введите количество строк: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int column = int.Parse(Console.ReadLine());

int[,] array_1 = Array2_D(row, column, 1, 10);
Print(array_1);

ArithmeticMean(array_1);

void Print(int[,] array) //метод печати двумерного массива
{
    int row_size = array.GetLength(0);
    int column_size = array.GetLength(1);

    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)
            Console.Write($" {array[i, j]} ");
            Console.WriteLine();
    }
    Console.WriteLine();
}