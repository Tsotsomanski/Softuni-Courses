using System.Net;
using BookStore.Interfaces;

namespace BookStore.UI
{
    using System;

    public class ConsoleInputHandler : IInputHandler
    {
        public string ReadLine()
        {
            return Console.ReadLine();
        }
    }
}
