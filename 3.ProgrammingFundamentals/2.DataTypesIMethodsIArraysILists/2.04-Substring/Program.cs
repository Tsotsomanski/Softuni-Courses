using System;

public class Substring_broken
{
    public static void Main()
    {
        string text = Console.ReadLine();
        int jump = int.Parse(Console.ReadLine());

        const char Search = 'p';
        bool hasMatch = false;

        for (int i = 0; i < text.Length - 1; i++)
        {
            char currentChar = text[i];

            if (currentChar == Search)
            {
                hasMatch = true;

                string matchedString;
                int endIndex = jump;

                if ((i + endIndex + 1) <= text.Length)
                {
                    matchedString = text.Substring(i, endIndex + 1);
                    
                }
                else
                {
                    matchedString = text.Substring(i);
                }

                Console.WriteLine(matchedString);

                i += jump;
            }
        }

        if (!hasMatch)
        {
            Console.WriteLine("no");
        }
    }
}