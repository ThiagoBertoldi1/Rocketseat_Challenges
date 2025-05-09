using Challenge_1.Inputs;

namespace Challenge_1.Challenges;
public static class Challenge_05
{
    public static void Challenge()
    {
        var plate = Input.Field("Enter a plate");

        if (PlateValidator(plate))
        {
            Input.ShowText("\nVALID", ConsoleColor.Green);
            return;
        }

        Input.ShowText("\nINVALID", ConsoleColor.Red);
    }

    static bool PlateValidator(string plate)
    {
        if (plate.Length != 7) return false;

        if (CaractersValidator(plate[0..2]) &&
            NumbersValidator(plate[3..6]))
        {
            return true;
        }

        return false;
    }

    static bool CaractersValidator(string text)
    {
        foreach (var c in text)
            if (!char.IsLetter(c)) return false;

        return true;
    }

    static bool NumbersValidator(string text)
    {
        foreach (var c in text)
            if (!char.IsNumber(c)) return false;

        return true;
    }
}
