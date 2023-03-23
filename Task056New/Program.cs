int rows = GetNumberFromUser("Укажите количество строк массива: ", "Ошибка ввода!");
int columns = GetNumberFromUser("Укажите количество столбцов массива: ", "Ошибка ввода!");
int[,] array = GetArray(rows, columns, 1, 13);
PrintArray(array);

 Console.WriteLine();

int[] sum = GetSumArr(array);
Console.WriteLine($"{String.Join("; ", sum)}.");

int minRowSum = GetMinRow(sum);
Console.WriteLine($"Строка с наименьшей суммой элементов: {minRowSum + 1}");


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

// Создание массива с суммами строк

int[] GetSumArr(int[,] array)
{
    int[] result = new int[array.GetLength(0)];


    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {

            result[i] += array[i, j];

        }

    }
    return result;
}

// Поиск индекса минимального

int GetMinRow(int[] sum)
{
    int k = 0;
    int minValue = sum[0];

    for (int i = 0; i < sum.Length; i++)
    {
        if (sum[i] < minValue)
        {

            sum[i] = minValue;
            k = i;
        }
    }


    return k;

}