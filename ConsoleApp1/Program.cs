class Program
{
    static void Main()
    {
        string numbers = "448537";
        //List<string> lettersByCicle = Task.GetLetters(numbers);
        List<string> lettersByRecursion = Task.GetLettersByRecursion(numbers);

        for (int i = 0; i < lettersByRecursion.Count; i++)
        {
            Console.WriteLine(lettersByRecursion[i]);
        }
    }
}