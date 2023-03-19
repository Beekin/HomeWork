// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 1,7 -> такого числа в массиве нет

int rows = GetNumberFromUser("Укажите количество строк массива: ", "Ошибка ввода!");
int columns = GetNumberFromUser("Укажите количество столбцов массива: ", "Ошибка ввода!");
int[,] array = GetArray(rows, columns, -10, 10);
PrintArray(array);

int userRows = GetNumberArrFromUser("Укажите искомую строку массива: ", "Ошибка ввода!");
int userColumns = GetNumberArrFromUser("Укажите искомый столбец массива: ", "Ошибка ввода!");

int findEl = GetFindElement(array);
Console.Write($"({userRows}, {userColumns}) -> {findEl}");


//////////////////////////////////////////////////////////////////////////////////
// Описание методов
// Запрашивает у пользователя целое положительное число
int GetNumberFromUser(string message, string errorMessage)
{
    while (true)
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

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
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

int GetFindElement(int[,] array)
{
    int x = 0;


    for (int i = 0; i < array.GetLength(0); i++)

    {
        for (int j = 0; j < array.GetLength(1); j++)

        {
            

            if (userRows >= 0 && userRows <= rows && userColumns >= 0 && userColumns <= columns)
            {
                x = array[userRows, userColumns];

            }
            else 
            {
                Console.WriteLine($"({userRows}, {userColumns}) Введеные числа больше размерности массива ");

           
            }

           
        }
        
    }
    return x;
}

int GetNumberArrFromUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect && userNumber >= 0)
        {
            return userNumber;
        }
        Console.WriteLine(errorMessage);
    }
}