int size = GetNumberUser("Введите размер массива: ", "Ошибка ввода!");

int[] array = GetArray(size, 100, 999);
Console.WriteLine(String.Join(" ", array));

int evenNumbers = GetEvenNumbers(array);
Console.WriteLine($"Колличество четных чисел = {evenNumbers}");



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

int GetEvenNumbers(int[] arr)
{

    int count = 0;
    foreach (int el in arr)
    {
        if (el % 2 == 0) count++;
    }
    return count;


}