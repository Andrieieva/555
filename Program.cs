using System;
using System.Text;

public class StringGenerator
{
    public string Solution(int AA, int AB, int BB)
    {
        StringBuilder result = new StringBuilder();

        while (AA > 0 || BB > 0)
        {
            if (AA > BB)
            {
                if (AA >= 2)
                {
                    result.Append("AA");
                    AA -= 2;
                }
                else if (AA == 1)
                {
                    result.Append("AA");
                    AA--;
                }
                if (BB > 0)
                {
                    result.Append("BB");
                    BB--;
                }
            }
            else
            {
                if (BB >= 2)
                {
                    result.Append("BB");
                    BB -= 2;
                }
                else if (BB == 1)
                {
                    result.Append("BB");
                    BB--;
                }
                if (AA > 0)
                {
                    result.Append("AA");
                    AA--;
                }
            }
        }

        while (AB > 0)
        {
            result.Append("AB");
            AB--;
        }

        return result.ToString();
    }

    public static void Main()
    {
        StringGenerator generator = new StringGenerator();
        Console.WriteLine(generator.Solution(5, 0, 2)); // Example input
    }
}
