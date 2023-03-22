int rows = GetNumberFromUser("Укажите количество строк массива: ", "Ошибка ввода!");
int columns = GetNumberFromUser("Укажите количество столбцов массива: ", "Ошибка ввода!");
int[,] array = GetArray(rows, columns, 1, 13);
PrintArray(array);

double[] averege = GetAverege(array, 1);
Console.WriteLine($"Среднее арифметическое столбца: {String.Join("; ", averege)}.");


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

double[] GetAverege(int[,] array, int digits)
{
    double[] result = new double[array.GetLength(1)];
    
    
    
    for (int i = 0; i < array.GetLength(1); i++)
    {


        for (int j = 0; j < array.GetLength(0); j++)
        {

          result[i] += array[j,i];

          
        }
        
        
        result[i] =  Math.Round(result[i]/array.GetLength(0), digits);

    }
   


    return result;

}