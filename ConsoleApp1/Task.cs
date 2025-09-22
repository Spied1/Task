using System.Text;

class Task
{
    private static readonly Dictionary<char, string> numbers = new()
        {
            { '2', "abc"},
            { '3', "def"},
            { '4', "ghi"},
            { '5', "jkl"},
            { '6', "mno"},
            { '7', "pqrs"},
            { '8', "tuv"},
            { '9', "wxyz"} };

    private static void Recursion(string digits, int index, StringBuilder current, List<string> result)
    {
        if (digits.Length == index)
        {
            result.Add(current.ToString());
            return;
        }

        foreach (char character in numbers[digits[index]])
        {
            current.Append(character);
            Recursion(digits, index + 1, current, result);
            current.Length--;
        }
    }

    public static List<string> GetLettersByRecursion(string digits)
    {
        List<string> result = [];
        if (digits.Length == 0)
        {
            return result;
        }

        Recursion(digits, 0, new StringBuilder(), result);

        return result;
    }

    public static List<string> GetLetters(string digits)
    {
        List<string> result = [];
        if (digits.Length == 0)
        {
            return result;
        }

        result.Add ("");

        for (int i = 0; i < digits.Length; i++) 
        {
            List<string> resultTemp = [];
            foreach(string combination in result)
            {
                foreach(char character in numbers[digits[i]])
                {
                    resultTemp.Add(combination + character);
                }

                result = new List<string>(resultTemp);
            }
        }

        return result;
    }
}