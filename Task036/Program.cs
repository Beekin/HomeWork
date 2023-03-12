int size = GetNumberUser("Введите размер массива: ", "Ошибка ввода!");
int maxValue = GetNumberUser("Введите миксимальное число в массиве: ", "Ошибка ввода!");
int minValue = GetNumberUser("Введите минимальное число в массиве: ", "Ошибка ввода!");

int[] array = GetArray(size, minValue, maxValue);
Console.WriteLine(String.Join(" ", array));

int sum = GetSumNumbers(array);
Console.WriteLine($"Сумма чисел на нечетных позициях = {sum}");



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

    int sum2 = 0;
    for (int i = 0; i < size; i++)
    {
        if (i % 2 != 0) sum2 = sum2 + arr[i];
    }
    return sum2;


}