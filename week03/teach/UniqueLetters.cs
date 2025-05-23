using System.ComponentModel;

public static class UniqueLetters {
    public static void Run() {
        var test1 = "abcdefghjiklmnopqrstuvwxyz"; // Expect True because all letters unique
        Console.WriteLine(AreUniqueLetters(test1));

        var test2 = "abcdefghjiklanopqrstuvwxyz"; // Expect False because 'a' is repeated
        Console.WriteLine(AreUniqueLetters(test2));

        var test3 = "";
        Console.WriteLine(AreUniqueLetters(test3)); // Expect True because its an empty string
    }

    /// <summary>Determine if there are any duplicate letters in the text provided</summary>
    /// <param name="text">Text to check for duplicate letters</param>
    /// <returns>true if all letters are unique, otherwise false</returns>
    private static bool AreUniqueLetters(string text)
    {
        // var uniqueLetter = new HashSet<char>();

        // foreach (var letter in text)
        // {

        //     if (uniqueLetter.Contains(letter))
        //     {
        //         return false;
        //     }

        //     uniqueLetter.Add(letter);
        // }

        // return true;

        var letters = new HashSet<char>(text);

        if (letters.Count == text.Length)
        {
            return true;
        }

        return false;

    }
        
}