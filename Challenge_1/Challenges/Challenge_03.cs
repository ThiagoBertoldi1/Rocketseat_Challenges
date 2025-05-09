using Challenge_1.Inputs;

namespace Challenge_1.Challenges;
public static class Challenge_03
{
    public static void Challenge()
    {
        if (!decimal.TryParse(Input.Field("Enter a number"), out var value1))
        {
            Input.ShowText("\nInvalid number", ConsoleColor.Red);
            return;
        }

        if (!decimal.TryParse(Input.Field("Enter another number"), out var value2) || value2 == 0)
        {
            Input.ShowText("\nThe second value must be non-zero", ConsoleColor.Red);
            return;
        }

        Input.ShowText($"\nSum -> {Math.Round(value1 + value2, 2)}", ConsoleColor.Yellow);
        Input.ShowText($"Sub -> {Math.Round(value1 - value2, 2)}", ConsoleColor.Yellow);
        Input.ShowText($"Mul -> {Math.Round(value1 * value2, 2)}", ConsoleColor.Yellow);
        Input.ShowText($"Div -> {Math.Round(value1 / value2, 2)}", ConsoleColor.Yellow);
        Input.ShowText($"Avg -> {Math.Round((value1 + value2) / 2, 2)}", ConsoleColor.Yellow);
    }
}
