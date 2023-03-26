int m = InputNumber("Введите минимальное число ", "Ошибка ввода данных!");
int n = InputNumber("Введите максимальное число ", "Ошибка ввода данных!");
int result = GetSumOfNum(m, n);

if (m >= n) Console.WriteLine("Неверное значение");
else GetSumOfNum(n, m);

Console.WriteLine($"Сумма чисел от {m} до {n} = {result}");

int GetSumOfNum(int m, int n)
{
    if (m > n) return 0;

    return m + GetSumOfNum(m + 1, n);
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