using System;

public class CustomConverter
{
    public void ConvertToInt(string input, out int result)
    {
        result = Convert.ToInt32(input);
    }

    public void ConvertToDouble(string input, out double result)
    {
        result = Convert.ToDouble(input);
    }

    public void ConvertToBool(string input, out bool result)
    {
        result = Convert.ToBoolean(input);
    }
}

// Пример использования
public class Program
{
    public static void Main()
    {
        CustomConverter converter = new CustomConverter();

        converter.ConvertToInt("123", out int intValue);
        Console.WriteLine($"Converted to int: {intValue}");

        converter.ConvertToDouble("123.45", out double doubleValue);
        Console.WriteLine($"Converted to double: {doubleValue}");

        converter.ConvertToBool("true", out bool boolValue);
        Console.WriteLine($"Converted to bool: {boolValue}");

    }
}
