using System;
using BookStore.Interfaces;

namespace BookStore.UI
{
    class ConsoleRenderer: IRenderer
    {
        public void WriteLine(string message, params string[] parameters)
        {
            Console.WriteLine(message, parameters);
        }
    }
}
