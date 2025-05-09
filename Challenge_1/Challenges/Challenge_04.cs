using Challenge_1.Inputs;

namespace Challenge_1.Challenges;
public static class Challenge_04
{
    public static void Challenge()
    {
        var sentence = Input.Field("Write a sentence");

        if (string.IsNullOrEmpty(sentence))
        {
            Input.ShowText("You didn't type anything", ConsoleColor.Red);
            return;
        }

        var wordsCount = sentence.Split(' ');

        Input.ShowText($"\n{wordsCount.Length} words", ConsoleColor.Yellow);

        foreach (var word in wordsCount)
            Input.ShowText($"word \"{word}\" - {word.Length} caracters", ConsoleColor.Yellow);
    }
}
