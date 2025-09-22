class Program
{
    static void Main()
    {
        Task t = new Task();
        string numbers = "885553535";
        List<string> letters = t.getLetters(numbers);
        
        foreach (string lettersTemp in letters)
        {
            Console.WriteLine(lettersTemp);
        }
    }
}