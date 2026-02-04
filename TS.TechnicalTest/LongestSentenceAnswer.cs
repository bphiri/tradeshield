
namespace TS.TechnicalTest;

public static class LongestSentenceAnswer
{
    public static int Solution(string s)
    {
        if (string.IsNullOrWhiteSpace(s)) return 0;
        var questions = s.Split( new char[] { '.' , '?', '!' , }, StringSplitOptions.RemoveEmptyEntries);
        
        
    }
}
