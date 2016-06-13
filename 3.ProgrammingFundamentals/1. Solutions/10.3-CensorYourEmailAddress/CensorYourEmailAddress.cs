using System;

namespace _10._3_CensorYourEmailAddress
{
    public class CensorYourEmailAddress
    {
        public static void Main()
        {
            string email = Console.ReadLine();
            string[] splitted = email.Split('@');
            string text = Console.ReadLine();
            string username = splitted[0];
            string domain = splitted[1];
            string replacedUserName = new string('*', username.Length);
            string replacement = replacedUserName + "@" + domain;

            if (text.Contains(email))
            {
                string replacedText = text.Replace(email, replacement);
                Console.WriteLine(replacedText);
            }
            else
            {
                Console.WriteLine(text);
            }
        }
    }
}