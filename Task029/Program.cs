int size = GetNumberUser("Введите размер массива: ", "Ошибка ввода!");


int[] array = new int[size];

FillArray(array);
PrintArray(array);

void FillArray(int[] array)
{
    for (int i = 0; i < size; i++)
    {


        array[i] = GetNumberUser($"Заполните массив. Введите число {i + 1}: ", "Ошибка ввода!");
    }


}

void PrintArray(int[] array)
{

    int length = array.Length;
    Console.Write("[");
    for (int i = 0; i < length; i++)
    {
        Console.Write($"{array[i]}");
        if (i < length - 1) Console.Write(", ");
    }
    Console.Write("]");

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
