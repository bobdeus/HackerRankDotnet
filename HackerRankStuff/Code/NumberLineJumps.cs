namespace HackerRankStuff.Code;

public class NumberLineJumps
{
    public static string Kangaroo(int x1, int v1, int x2, int v2)
    {
        var firstHops = GetAllHops(x1, v1);
        var secondHops = GetAllHops(x2, v2);
        
        for (var i = 0; i < firstHops.Count; i++)
        {
            if (firstHops[i] == secondHops[i])
            {
                return "YES";
            }
        }
        
        return "NO";
    }

    private static List<int> GetAllHops(int start, int distance)
    {
        return Enumerable.Range(start, 10_000).Aggregate(new List<int>{start}, (accumulator, _) =>
        {
            accumulator.Add(accumulator.Last() + distance);
            return accumulator;
        });
    }
}