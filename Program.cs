using System;

public class CalculatePlusMinus
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Введите арифметическое выражение (с операциями + и -):");
        string expression = Console.ReadLine();

        try
        {
            int result = Calculate(expression);
            Console.WriteLine($"Результат: {result}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
    }

    public static int Calculate(string expression)
    {
        string[] parts = expression.Split(new char[] { '+', '-' }, StringSplitOptions.RemoveEmptyEntries);
        int result = int.Parse(parts[0]);

        for (int i = 1; i < parts.Length; i++)
        {
            char operation = expression[expression.IndexOf(parts[i - 1]) + parts[i - 1].Length];
            int operand = int.Parse(parts[i]);

            if (operation == '+')
            {
                result += operand;
            }
            else if (operation == '-')
            {
                result -= operand;
            }
        }

        return result;
    }
}