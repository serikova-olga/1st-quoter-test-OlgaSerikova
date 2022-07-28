string[] array = { "Hi", "my", "pretty", "o", "love", "u", "ok" };

string Print(string[] array)
{
    string res = string.Empty;
    Console.WriteLine("заданный массив: ");
    for (int i = 0; i < array.Length; i++)
    {
        res += $"{array[i]} ";
    }
    return res;
}

string[] Result(string[] array)
{
    string[] result = new string[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            result[i] = array[i];
            Console.Write(result[i] + " ");
        }
    }
    Console.WriteLine();
    return result;
}

Console.WriteLine(Print(array));
Console.WriteLine();

Console.WriteLine("новый массив: ");
Result(array);
Console.WriteLine();