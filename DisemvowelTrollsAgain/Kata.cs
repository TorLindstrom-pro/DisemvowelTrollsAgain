
namespace DisemvowelTrollsAgain;

public class Kata
{
    public static string Disemvowel(string v)
    {
        var vowels = "aeiou";
        return vowels.Contains(v) ? "" : v;
    }
}