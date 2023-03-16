using HackerRankStuff.Code;

namespace HackerRankStuffTests;

public class NumberLineJumpsTests
{
    [Test]
    public void TestKangaroo()
    {
        Assert.That(NumberLineJumps.Kangaroo(0, 3, 4, 2), Is.EqualTo("YES"));
        Assert.That(NumberLineJumps.Kangaroo(0, 2, 5, 3), Is.EqualTo("NO"));
        Assert.That(NumberLineJumps.Kangaroo(0, 6, 18, 3), Is.EqualTo("YES"));
        Assert.That(NumberLineJumps.Kangaroo(0, 2, 1, 1), Is.EqualTo("YES"));
    }
}

