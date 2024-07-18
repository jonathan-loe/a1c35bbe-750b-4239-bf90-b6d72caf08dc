namespace Lis;

public class LisGenerator
{
    public const string Space = " ";

    public static string Generate(string text)
    {
        if (string.IsNullOrWhiteSpace(text))
            return string.Empty;

        var integers = text.Trim().Split(Space);
        if (integers.Length == 1)
            return integers[0];

        var listOfLongestIncreasingSubsequence = new List<string[]>();

        var previousInteger = integers[0];
        var longestIncreasingSubsequence = new List<string> { previousInteger };
        for (var i = 1; i < integers.Length; i++)
        {
            var currentInteger = integers[i];
            if (IsIncreasingSequence(previousInteger, currentInteger))
            {
                longestIncreasingSubsequence.Add(currentInteger);
            }
            else
            {
                listOfLongestIncreasingSubsequence.Add([.. longestIncreasingSubsequence]);
                longestIncreasingSubsequence = new List<string> { currentInteger };
            }
            previousInteger = currentInteger;
        }

        var longestLisExists = longestIncreasingSubsequence.Count > 0;
        if (longestLisExists)
        {
            listOfLongestIncreasingSubsequence.Add([.. longestIncreasingSubsequence]);
        }

        var longestLength = GetLongestSequence(listOfLongestIncreasingSubsequence);
        foreach (var lis in listOfLongestIncreasingSubsequence)
        {
            if (lis.Length == longestLength)
            {
                return string.Join(Space, lis);
            }
        }

        throw new Exception("Uh oh! Something's not right :(");
    }

    static bool IsIncreasingSequence(string previousInteger, string currentInteger)
    {
        return int.Parse(previousInteger) < int.Parse(currentInteger);
    }

    static int GetLongestSequence(IEnumerable<string[]> listOfLongestIncreasingSubsequence)
    {
        var longestLength = 0;
        foreach (var sequence in listOfLongestIncreasingSubsequence)
        {
            if (sequence.Length > longestLength)
            {
                longestLength = sequence.Length;
            }
        }
        return longestLength;
    }
}
