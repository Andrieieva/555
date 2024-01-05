using System;

class Program
{
    static void Main()
    {
        int aa = 0, ab = 2, bb = 2;
        string longestString = GenerateLongestString(aa, ab, bb);
        Console.WriteLine(longestString);
    }

    static string GenerateLongestString(int aa, int ab, int bb)
    {
        string result = "";

        string aaString = GenerateString(aa, ab, bb, "AA");
        string abString = GenerateString(aa, ab, bb, "AB");
        string bbString = GenerateString(aa, ab, bb, "BB");

        result = GetLongestString(result, aaString);
        result = GetLongestString(result, abString);
        result = GetLongestString(result, bbString);

        return result;
    }

    static string GenerateString(int aa, int ab, int bb, string lastAdded)
    {
        if (aa == 0 && ab == 0 && bb == 0)
        {
            return "";
        }

        string result = "";

        if (lastAdded == "AA")
        {
            if (bb > 0)
            {
                result = "BB" + GenerateString(aa, ab, bb - 1, "BB");
            }
        }
        else if (lastAdded == "AB")
        {
            if (aa > 0)
            {
                result = "AA" + GenerateString(aa - 1, ab, bb, "AA");
            }
            if (ab > 0)
            {
                result = GetLongestString(result, "AB" + GenerateString(aa, ab - 1, bb, "AB"));
            }
        }
        else if (lastAdded == "BB")
        {
            if (aa > 0)
            {
                result = GetLongestString(result, "AA" + GenerateString(aa - 1, ab, bb, "AA"));
            }
            if (ab > 0)
            {
                result = GetLongestString(result, "AB" + GenerateString(aa, ab - 1, bb, "AB"));
            }
        }

        return result;
    }

    static string GetLongestString(string str1, string str2)
    {
        return str1.Length >= str2.Length ? str1 : str2;
    }
}
//hope you don't have another input data in order to find bugs in this code :)