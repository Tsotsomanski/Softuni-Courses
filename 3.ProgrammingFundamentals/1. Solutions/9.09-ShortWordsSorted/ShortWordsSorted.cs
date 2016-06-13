using System;
using System.Linq;

namespace _9._09_ShortWordsSorted
{
    public class Program
    {
        public static void Main()
        {
            char[] delimeters = ".,:;()[]\"'\\/!? ".ToCharArray();
            var words = Console.ReadLine().ToLower().Split(delimeters);
            var result = words.Where(w => w != "").Where(x => x.Length < 5).OrderBy(w => w).Distinct();

            Console.WriteLine(string.Join(", ", result));
        }
    }
}