using TS.TechnicalTest;

namespace TS.UnitTests;

[TestClass]
public class LongestSentenceTests
{
    [TestMethod]
    public void Q1_BasicNominalTest()
    {
        var input = $"We test coders. Give us a try";
        var outcome = LongestSentenceAnswer.Solution(input);

        Assert.AreEqual(4, outcome);
    }
}
