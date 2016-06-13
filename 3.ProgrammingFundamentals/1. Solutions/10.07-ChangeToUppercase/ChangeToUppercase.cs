using System;

namespace _10._07_ChangeToUppercase
{
    public class ChangeToUppercase
    {
        public static void Main()
        {
            string text = Console.ReadLine();

            int indexOfFirstOpen = text.IndexOf("<upcase>");
            int indexOfFirstClosed = text.IndexOf("</upcase>");
        }
    }
}