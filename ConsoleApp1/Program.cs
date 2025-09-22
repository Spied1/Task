class Program
{
    static void Main()
    {
        string numbers = "";
        List<string> letters = Task.GetLetters(numbers);

        foreach (string lettersTemp in letters)
        {
            Console.WriteLine(lettersTemp);
        }
    }
}