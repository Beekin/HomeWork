// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76


int size = GetNumberUser("Введите размер массива: ", "Ошибка ввода!");
int maxValue = GetNumberUser("Введите миксимальное число в массиве: ", "Ошибка ввода!");
int minValue = GetNumberUser("Введите минимальное число в массиве: ", "Ошибка ввода!");

int[] array = GetArray(size, minValue, maxValue);
Console.WriteLine(String.Join(" ", array));


int diffMaxMin = GetSumNumbers(array);
Console.WriteLine($"Разница между максимальным и минимальным элементами массива = {diffMaxMin}");

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}



int GetNumberUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect)
            return userNumber;
        Console.WriteLine(errorMessage);
    }

}

int GetSumNumbers(int[] arr)
{

    int diff = 0;
    int minEl = arr[0];
    int maxEl = arr[0];

    for (int i = 0; i < size; i++)
    {
        if (arr[i] > maxEl) maxEl = arr[i];
    
    else if(arr[i] < minEl) minEl = arr[i];

    diff = maxEl - minEl;
    }

    return diff;


}