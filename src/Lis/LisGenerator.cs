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

        var listOfLongestLis = new List<string[]>();
        var longestLis = new List<string> { integers[0] };

        var previousInteger = int.Parse(integers[0]);
        for (var i = 1; i < integers.Length; i++)
        {
            var currentInteger = int.Parse(integers[i]);
            if (currentInteger > previousInteger)
            {
                longestLis.Add(integers[i]);
            }
            else
            {
                listOfLongestLis.Add([.. longestLis]);
                longestLis = new List<string> { integers[i] };
            }
            previousInteger = currentInteger;
        }
        if (longestLis.Count > 0)
        {
            listOfLongestLis.Add([.. longestLis]);
        }

        var longestLength = 0;
        foreach (var lis in listOfLongestLis)
        {
            if (lis.Length > longestLength)
            {
                longestLength = lis.Length;
            }
        }

        foreach (var lis in listOfLongestLis)
        {
            if (lis.Length == longestLength)
            {
                return string.Join(Space, lis);
            }
        }

        return string.Empty;
    }
}
