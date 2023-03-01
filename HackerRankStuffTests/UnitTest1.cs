using HackerRankStuff.Code;

namespace HackerRankStuffTests;

public class Tests
{
    [Test]
    public void Test1()
    {
        var arrayToTestCase1 = new List<int> {2, 1, 3, 1, 2};
        Assert.That(InsertionSortAdvancedAnalysis.Mergesort(arrayToTestCase1), Is.EqualTo(4));
        var arrayToTestCase2 = new List<int> {12, 15, 1, 5, 6, 14, 11};
        Assert.That(InsertionSortAdvancedAnalysis.Mergesort(arrayToTestCase2), Is.EqualTo(10));
    }
}