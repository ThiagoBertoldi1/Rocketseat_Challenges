using Challenge_1.Inputs;

namespace Challenge_1.Challenges;
public static class Challenge_02
{
    public static void Challenge()
    {
        var firstName = Input.Field("What's your first name?");
        var lastName = Input.Field("What's your last name?");

        if (string.IsNullOrEmpty(firstName) && string.IsNullOrEmpty(lastName))
            Input.ShowText("\n Don't you have a name? :[", ConsoleColor.Yellow);
        else
            Input.ShowText($"\nHey, {firstName} {lastName}", ConsoleColor.Yellow);
    }
}
