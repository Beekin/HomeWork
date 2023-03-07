Console.Write("Введите целое число: ");

int userInput = int.Parse(Console.ReadLine() ?? "");



while (userInput >= 1)
{


    int x = (int)Math.Pow(userInput, 3);

    Console.WriteLine($"{userInput} -> {x} ");

    userInput--;

}
