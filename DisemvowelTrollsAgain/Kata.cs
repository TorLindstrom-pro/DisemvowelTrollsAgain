
namespace DisemvowelTrollsAgain;

public class Kata
{
    public static string Disemvowel(string input)
    {
        var vowels = "aeiou";
        return input.Any(vowels.Contains) ? "" : input;
    }
}