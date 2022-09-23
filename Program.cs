int exNum = int.Parse(Console.ReadLine());

if (exNum == 25)
{   while (true)
    {Console.WriteLine("Введите число A");
    double a = double.Parse(Console.ReadLine());
    Console.WriteLine("Введите число B");
    double b = double.Parse(Console.ReadLine());
    Console.WriteLine($"{a} в степени {b} = {Math.Pow(a, b)}");
} }
if (exNum == 27)
{
    Console.WriteLine("Введите число");
    string str = Console.ReadLine();
    int summ = 0;
    for (int i = 0; i < str.Length; i++)
    {
        try
        {
            summ += int.Parse(str[i].ToString());
        }
        catch
        {
            continue;
        }
    }
    Console.WriteLine($"Сумма цифр в числе = {summ}");
}