int num = GetNumberUser("Введите целое число А: ", "Ошибка ввода!");

int result = GetSumOfNumber(num);

Console.WriteLine($"{num} -> {result}");


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

int GetSumOfNumber(int num)
{

    int sum = 0;

    while(num > 0)
    {
        int a1 = num % 10;
        
        sum = sum + a1;

        num /=10;
       
    }
    return sum;
}
