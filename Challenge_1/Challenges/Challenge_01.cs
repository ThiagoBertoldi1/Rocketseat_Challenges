using Challenge_1.Inputs;

namespace Challenge_1.Challenges;
public static class Challenge_01
{
    public static void Challenge()
    {
        var name = Input.Field("What's your name?");

        if (string.IsNullOrEmpty(name))
            Input.ShowText($"\nWhy didn't you tell me your name? :/", ConsoleColor.Yellow);
        else
            Input.ShowText($"\nHey {name}, welcome!!!", ConsoleColor.Yellow);
    }
}
