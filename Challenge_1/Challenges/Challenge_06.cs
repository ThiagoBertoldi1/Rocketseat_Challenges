using Challenge_1.Inputs;
using System.Globalization;

namespace Challenge_1.Challenges;
public static class Challenge_06
{
    public static void Challenge()
    {
        Input.ShowText("1 - dddd dd/MM/yyyy HH:mm:ss ~ sexta-feira, 1 de março de 2024, 14:35:20");
        Input.ShowText("2 - dd/MM/yyyy ~ 01/03/2024");
        Input.ShowText("3 - HH:mm ~ 14:35");
        Input.ShowText("4 - dd de MM de yyyy ~ 1 de março de 2024\n");
        var format = Input.Field("Choose date format");

        if (!int.TryParse(format, out var validFormat))
        {
            Input.ShowText("Invalid date", ConsoleColor.Red);
            return;
        }

        Console.WriteLine();

        var date = DateTime.Now;

        switch (validFormat)
        {
            case 1:
                Input.ShowText(date.ToString("dddd, d 'de' MMMM 'de' yyyy, HH:mm:ss", new CultureInfo("pt-BR")), ConsoleColor.Yellow);
                break;
            case 2:
                Input.ShowText(date.ToString("dd/MM/yyyy", new CultureInfo("pt-BR")), ConsoleColor.Yellow);
                break;
            case 3:
                Input.ShowText(date.ToString("HH:mm", new CultureInfo("pt-BR")), ConsoleColor.Yellow);
                break;
            case 4:
                Input.ShowText(date.ToString("d 'de' MMMM 'de' yyyy", new CultureInfo("pt-BR")), ConsoleColor.Yellow);
                break;
            default:
                Input.ShowText("Invalid option", ConsoleColor.Red);
                break;
        }
    }
}
