int x1 = InputNumber("Введите х1: ");
int y1 = InputNumber("Введите y1: ");
int x2 = InputNumber("Введите х2: ");
int y2 = InputNumber("Введите y2: ");
int x3 = InputNumber("Введите х3: ");
int y3 = InputNumber("Введите y3: ");

Console.WriteLine($"Расстояние между точками ({x1}, {y1}, {x3}) и ({x2}, {y2}, {y3}) ({CalculateDistance(x1, y1, x2, y2, x3, y3)})");

static int InputNumber(string message)
{

    try
        {
            Console.Write(message);
            return (int.Parse(Console.ReadLine() ?? ""));
        }

        catch (Exception exc)
        {

            Console.WriteLine($"Ошибка ввода! {exc.Message}");
            return 0;

        }


}  

static double CalculateDistance(int x1, int y1, int x2, int y2, int x3, int y3)
{
    return Math.Sqrt(Math.Pow(x2-x1,2) + (Math.Pow(y2-y1, 2) + (Math.Pow(y3-x3, 2))));
}