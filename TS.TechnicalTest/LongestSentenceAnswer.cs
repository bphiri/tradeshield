
namespace TS.TechnicalTest;

public static class LongestSentenceAnswer
{
    public static int Solution(string s)
    {
        if (string.IsNullOrWhiteSpace(s)) return 0;
        var questions = s.Split(['.' , '?', '!'], StringSplitOptions.RemoveEmptyEntries);
        var maximumWords = 0;
        
        foreach (var question in questions)
        {
            var words = question.Split([' '], StringSplitOptions.RemoveEmptyEntries).Where(word => word.Any(char.IsLetter));
            maximumWords = Math.Max(words.Count(), maximumWords);
        }
        return maximumWords;
        
        
    }
}
