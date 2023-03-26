int n = InputNumber("Введите минимальное число ", "Ошибка ввода данных!");
int m = InputNumber("Введите максимальное число ", "Ошибка ввода данных!");

if (n >= 4) Console.WriteLine("Error. Stack overflow.");

else Akkerman(n, m);
int result = Akkerman(n, m);

Console.WriteLine($"Результат вычисления А({n}; {m}) -> {result}");

static int Akkerman(int n, int m)
{
    
    if (n == 0) return m + 1;
    if (n != 0 && m == 0) return Akkerman(n - 1, 1);
    if (n > 0 && m > 0) return Akkerman(n - 1, Akkerman(n, m - 1));
    return Akkerman(n, m);
}

static int InputNumber(string message, string errormessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect)
            return userNumber;
        Console.WriteLine(errormessage);
    }
}