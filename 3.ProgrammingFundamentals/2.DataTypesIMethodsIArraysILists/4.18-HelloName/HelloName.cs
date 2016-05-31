using System;

namespace _4._18_HelloName
{
    class HelloName
    {
        static void Main()
        {
            string name = Console.ReadLine();

            SayHello(name);
            
        }

        static void SayHello(string name)
        {
            Console.WriteLine("Hello, {0}!", name);
        }
    }
}
