using System;

namespace _4._14_IntToHexAndBin
{
    class IntToHexAndBin
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());
            string inHexa = Convert.ToString(input, 16).ToUpper();
            Console.WriteLine(inHexa);
            string decim = Convert.ToString(input, 2);
            Console.WriteLine(decim);
        }
    }
}