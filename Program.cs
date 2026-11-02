
using System;
using System.Text;
using System.Text.RegularExpressions;
class Program
{
    static void Main()
    {
        Console.WriteLine("Choose task (1-8):");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter text (write END on a new line to finish):");
        StringBuilder sb = new StringBuilder();
        string line;

        while ((line = Console.ReadLine()) != "END")
        {
            sb.AppendLine(line);
        }
        string text = sb.ToString();
        string result = "";

        switch (n)
        {
            case 1:
                result = Task1(text);
                break;
            case 2:
                result = Task2(text);
                break;
            case 3:
                result = Task3(text);
                break;
            case 4:
                result = Task4(text);
                break;
            case 5:
                result = Task5(text);
                break;
            case 6:
                result = Task6(text);
                break;
            case 7:
                result = Task7(text);
                break;
            case 8:
                result = Task8(text);
                break;
            default:
                Console.WriteLine("Wrong task number");
                return;
        }

        Console.WriteLine("\nResult:");
        Console.WriteLine(result);
    }

    static string Task1(string text)
    {
        return Regex.Replace(text, @"a+b{2,}c+", "QQQ");
    }

    static string Task2(string text)
    {
        return Regex.Replace(text, @"([a-z][A-Z])", "_?_$1_?_");
    }

    static string Task3(string text)
    {
        return Regex.Replace(text, @"\$v_([A-Za-z0-9])\$", "v[$1]");
    }

    static string Task4(string text)
    {
        return Regex.Replace(text, @"\$v_\{([a-zA-Z\d]*)\}\$", "v[$1]");
    }

    static string Task5(string text)
    {
        return Regex.Replace(text, @"\$v_\{([a-zA-Z\d]*)\}\$|\$v_([a-zA-Z0-9])\$", "v[$1$2]"); 
    }

    static string Task6(string text)
    {
        return Regex.Replace(text,
            @"\\texttt\{([A-Za-z]+|[0-9]+)\}", @"\begin{ttfamily}$1\end{ttfamily}");
    }

    static string Task7(string text)
    {
        return Regex.Replace(text,
            @"\b[A-Z][A-Za-z]*(?: +[A-Z][A-Za-z]*){2,}\b", "\"$0\"");
    }

    static string Task8(string text)
    {
        return Regex.Replace(text,
            @"\\circle\{\((\d+),(\d+)\)(,\d+)?\}", @"\circle{($2,$1)$3}");
    }
}
