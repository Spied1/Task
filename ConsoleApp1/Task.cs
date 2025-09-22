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

    private static void Reqursion(string digits, int index, string current, List<string> result)
    {
        if (digits.Length == index)
        {
            result.Add(current);
            return;
        }

        foreach (char character in numbers[digits[index]])
        {
            Reqursion(digits, index + 1, current + character, result);
        }
    }

    public static List<string> GetLetters(string digits)
    {
        List<string> result = [];
        if (digits.Length == 0)
        {
            return result;
        }

        Reqursion(digits, 0, "", result);

        return result;
    }
}