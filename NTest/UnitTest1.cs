using DisemvowelTrollsAgain;

namespace NTest;

public class Tests
{

    /*  Your task is to write a function that takes a string and return a new string with all vowels removed.

        For example, the string "This website is for losers LOL!" would become "Ths wbst s fr lsrs LL!".

        Note: for this kata y isn't considered a vowel.
     */

    [Theory]
    [TestCase("d")]
    [TestCase("qwrtp")]
    public void OnlyConsonants_IsReturnedAsIs(string input)
    {
        string result = Kata.Disemvowel(input);
        Assert.That(result, Is.EqualTo(input));
    }
    
    [Test]
    public void SingleVowels_ReturnsEmptyString()
    {
        string result = Kata.Disemvowel("a");
        Assert.That(result, Is.EqualTo(""));
    }
    
    [Test]
    public void OnlyVowels_ReturnsEmptyString()
    {
        string result = Kata.Disemvowel("uoiea");
        Assert.That(result, Is.EqualTo(""));
    }
}
