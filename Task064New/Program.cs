int n = InputNumber("Введите число ", "Ошибка ввода данных!");
int m = 1;
if (m >= n) Console.WriteLine("Неверное значение");
else PrintNumber(n, m);

void PrintNumber(int n, int m)
{
    if (m > n) return;
    Console.Write(n + ", ");
    PrintNumber(n - 1, m);

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