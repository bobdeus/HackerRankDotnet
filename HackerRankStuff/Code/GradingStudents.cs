namespace HackerRankStuff.Code;

public class GradingStudents
{
    public static List<int> GradeStudents(List<int> studentGrades)
    {
        return studentGrades.Select(ComputeGrade).ToList();
    }

    private static int ComputeGrade(int grade)
    {
        if (grade % 5 == 0)
        {
            return grade;
        }

        var nextNumberHigher = GetNextHigherNumber(grade);
        var diff = nextNumberHigher - grade;
        if (diff >= 3)
        {
            return grade;
        }

        if (grade + diff >= 40)
            return grade + diff;
        return grade;
    }

    private static int GetNextHigherNumber(int grade)
    {
        var theNumber = grade;
        while (theNumber % 5 != 0)
        {
            theNumber++;
        }

        return theNumber;
    }
}