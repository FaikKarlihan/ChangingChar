public static class Methods
{
    public static string GetSTR()
    {
        Console.Clear();
        string str;
        Console.WriteLine("Enter a sentence or word");
        while (true)
        {
            Console.Write("Text: ");str = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(str))
            {
                return str;
            }
            else
            {
                Console.WriteLine("Please enter a valid text!");
            }            
        }
    } 
}