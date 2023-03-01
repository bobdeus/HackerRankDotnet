using HackerRankStuff.Code;

namespace HackerRankStuffTests;

public class GradingStudentsTests
{
    [Test]
    public void Test()
    {
        var testCase1 = new List<int> {73, 67,38, 33 };
        var expectedCase1 = new List<int> {75, 67, 40, 33};
        Assert.That(GradingStudents.GradeStudents(testCase1), Is.EqualTo(expectedCase1));
        
    }
}