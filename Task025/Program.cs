int num1 = GetNumberUser("Введите целое число А: ", "Ошибка ввода!");
int num2 = GetNumberUser("Введите целое число B: ", "Ошибка ввода!");

int result = NumPow(num1, num2);


Console.WriteLine($"({num1}, {num2}) -> {result}");



int GetNumberUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect && userNumber >= 0)
            return userNumber;
        Console.WriteLine(errorMessage);
    }

}

int NumPow(int num1, int num2)
{
    int count = 0;
    int sum = 1;

    while (count < num2)
    {

        sum = sum * num1;

        count++;

    }

    return sum;


}