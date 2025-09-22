class Task
{
    private Dictionary<char, List<char>> numbers;

    public Task()
    {
        this.numbers = new Dictionary<char, List<char>>()
        {
            { '2', new List<char> { 'a', 'b', 'c' }},
            { '3', new List<char> { 'd', 'e', 'f' }},
            { '4', new List<char> { 'g', 'h', 'i' }},
            { '5', new List<char> { 'j', 'k', 'l' }},
            { '6', new List<char> { 'm', 'n', 'o' }},
            { '7', new List<char> { 'p', 'q', 'r', 's'}},
            { '8', new List<char> { 't', 'u', 'v' }},
            { '9', new List<char> { 'w', 'x', 'y', 'z' }}
           };
    }

    public List<string> getLetters(string digits)
    {
        List<string> letters = new List<string>();
        if (digits.Length == 0)
        {
            return letters;
        }

        letters.Add("");

        for (int i = 0; i < digits.Length; ++i)
        {
            List<string> lettersTemp = new List<string>();
            foreach (string comb in letters)
            {
                foreach (char c in numbers[digits[i]])
                {
                    lettersTemp.Add(comb + c);
                }
            }

            letters = new List<string>(lettersTemp);
        }
        return letters;
    }
}