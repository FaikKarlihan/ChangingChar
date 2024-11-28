class Changing:GetString
{
    public void Change()
    {
        GetTheString();
        Console.Clear();
        str.Trim();
        string[] SplitedText = str.Split(" ");
        string ModifiedText = "";
               
        foreach (string word in SplitedText)
        {
            char[] CharArray = word.ToCharArray();

            char first = CharArray[0];
            CharArray[0] = CharArray[CharArray.Length-1];
            CharArray[CharArray.Length-1] = first;

            ModifiedText += new string(CharArray) +  " ";
        }
        Console.WriteLine("Modified Text: " + ModifiedText.Trim());
    }
}