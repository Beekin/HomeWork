﻿// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9


int rows = GetNumberFromUser("Укажите количество строк массива: ", "Ошибка ввода!");
int columns = GetNumberFromUser("Укажите количество столбцов массива: ", "Ошибка ввода!");
double[,] array = GetArray(rows, columns, -5, 10, 2);
PrintArray(array);
//////////////////////////////////////////////////////////////////////////////////
// Описание методов
// Запрашивает у пользователя целое положительное число
int GetNumberFromUser(string message, string errorMessage)
{
    while(true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect && userNumber > 0)
        {
            return userNumber;
        }
        Console.WriteLine(errorMessage);
    }
}

double[,] GetArray(int m, int n, int minValue, int maxValue, int digits)
{
    double[,] result = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);

            result[i, j] = Math.Round(result[i, j], digits);
        }
        
    }
    return result;
}

void PrintArray(double[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}