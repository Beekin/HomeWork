int num = InputNumber("Введите 5-ти значное число ");

PrintResult(num);

static void PrintResult(int num)
{

    if (num >= 10000 && num < 100000)
    {
        while (num >= 10000 && num < 100000)
        {
            int a1 = num / 10000;
            int b1 = num % 10;
            int a2 = num % 10000;
            int b2 = a2 / 1000;
            int b3 = num % 100;
            int b4 = b3 / 10;

            if (a1 == b1 && b2 == b4)
            {

                Console.WriteLine($"Да! -> палиндром");
            }

            else { Console.WriteLine($"Нет! -> не палиндром"); }

            break;
        }

    }
    else
    {

        Console.WriteLine("Ошибка ввода! Число меньше 5 знаков");

    }

}

static int InputNumber(string message)
{
    int n = 0;

    while (true)
    {

        try
        {
            Console.Write(message);
            n = int.Parse(Console.ReadLine() ?? "");

            break;
        }
        catch (Exception exc)
        {

            Console.WriteLine("Ошибка ввода");

        }

    }
    return n;


}
