namespace HackerRankStuff.Code;

public static class InsertionSortAdvancedAnalysis
{
    private static int inversions;

    public static int Mergesort(List<int> list)
    {
        inversions = 0;
        mergesortrec(list, 0, list.Count - 1);
        return inversions;
    }

    private static void mergesortrec(List<int> list, int start, int end)
    {
        if (start > end) return;

        var len = end - start + 1;
        if (len > 1)
        {
            var mid = (len >> 1) - 1;
            mergesortrec(list, start, start + mid);
            mergesortrec(list, start + mid + 1, end);
            merge(list, start, start + mid, end);
        }
    }

    private static void merge(List<int> list, int start, int mid, int end)
    {
        var mergedlist = new List<int>(end - start + 1);
        var leftLen = mid - start + 1;
        var rightLen = end - mid;
        var leftIndex = start;
        var rightIndex = mid + 1;

        while (leftIndex <= mid && rightIndex <= end)
        {
            var leftElem = list[leftIndex];
            var rightElem = list[rightIndex];

            if (leftElem <= rightElem)
            {
                leftIndex++;
                mergedlist.Add(leftElem);
            }
            else
            {
                inversions += leftLen - (leftIndex - start);
                rightIndex++;
                mergedlist.Add(rightElem);
            }
        }

        for (var ii = leftIndex; ii <= mid; ii++) mergedlist.Add(list[ii]);

        for (var ii = rightIndex; ii <= end; ii++) mergedlist.Add(list[ii]);

        for (var ii = 0; ii < mergedlist.Count; ii++) list[start + ii] = mergedlist[ii];
    }
}