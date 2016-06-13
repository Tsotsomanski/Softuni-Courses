using System;

namespace _9._04_OccurrencesInString
{
    public class Program
    {
        public static void Main()
        {
            var text = Console.ReadLine().ToLower();
            var w = Console.ReadLine().ToLower();

            int startPos = 0;
            int count = 0;

            while (true)
            {
                var pos = text.IndexOf(w, startPos);

                if (pos == -1)
                {
                    break;
                }

                count++;
                startPos = pos + 1;
            }

            Console.WriteLine(count);
        }
    }
}