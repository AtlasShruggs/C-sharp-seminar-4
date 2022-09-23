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
else if (exNum == 29)
{
    Console.WriteLine("Введите размер массива");
    int size = int.Parse(Console.ReadLine());

    int[] massiveCreator(int colSize)
    {
        int[] collection = new int[size];
        return collection;
    }
    int[] massive = massiveCreator(size);

    for (int i = 0; i < size; i++)
    {
        try
        {   Console.WriteLine($"Введите {i+1}-й элемент массива");
            massive[i] = int.Parse(Console.ReadLine());
        }
        catch
        {Console.WriteLine("Данные введены неверно, попробуйте еще раз");
        i -= 1;
        }
    }
    Console.Write("[");
    for (int i = 0; i < size - 1; i++)
    {
        Console.Write(massive[i]);
        Console.Write(", ");
    }
    Console.Write($"{massive[^1]}]");
}