namespace Challenge_1.Inputs;
public static class Input
{
    public static string Field(string label)
    {
        Console.WriteLine(label);
        return Console.ReadLine() ?? string.Empty;
    }

    public static void Info(string challenge, ConsoleColor color = ConsoleColor.Green)
    {
        Console.ForegroundColor = color;
        Console.WriteLine($"\n\n\t CHALLENGE {challenge} \n\n");
        Console.ResetColor();
    }

    public static void ShowText(string text, ConsoleColor color = ConsoleColor.White)
    {
        Console.ForegroundColor = color;
        Console.WriteLine(text);
        Console.ResetColor();
    }
}