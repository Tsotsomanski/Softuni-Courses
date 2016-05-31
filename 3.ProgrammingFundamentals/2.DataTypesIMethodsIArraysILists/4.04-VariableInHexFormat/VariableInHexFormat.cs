using System;

namespace _4._04_VariableInHexFormat
{
    class VariableInHexFormat
    {
        static void Main()
        {
            string a = Console.ReadLine();
            int converted = Convert.ToInt32(a, 16);
            Console.WriteLine(converted);
        }
    }
}