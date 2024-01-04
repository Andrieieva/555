using System;
using System.Text;

class StrWithout3A3B
{
    public string Solution(int AA, int AB, int BB)
    {
        StringBuilder sb = new StringBuilder();

        while (AA > 0 || BB > 0 || AB > 0)
        {
            if (AA >= BB && AA > 0 && CanAdd(sb, 'A'))
            {
                sb.Append("AA");
                AA--;
            }
            else if (BB > 0 && CanAdd(sb, 'B'))
            {
                sb.Append("BB");
                BB--;
            }
            else if (AB > 0 && CanAdd(sb, 'A'))
            {
                sb.Append("AB");
                AB--;
            }
            else
            {
                break;
            }
        }

        return sb.ToString();
    }

    private bool CanAdd(StringBuilder sb, char c)
    {
        int length = sb.Length;

        if (length >= 2 && sb[length - 1] == c && sb[length - 2] == c)
        {
            return false;
        }

        return true;
    }

    static void Main()
    {
        StrWithout3A3B solution = new StrWithout3A3B();
        Console.WriteLine(solution.Solution(0, 0, 2));
    }
}
