Console.WriteLine("Введите значения для x, y");
int x = Convert.ToInt32(Console.ReadLine());
int y = Convert.ToInt32((Console.ReadLine()));
try
{
    int z = x / y;
}
catch (DivideByZeroException)
{
    Console.WriteLine("Исключение");
}
try
{
    int z = x / y;
    if (x == 0)
    {
        throw new Exception("x=0");
    }
    else
    {
        Console.WriteLine($"Ответ{z}");
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}