using System.Runtime.CompilerServices;
using System.Xml;
using BookStore.Interfaces;
using BookStore.UI;

namespace BookStore
{
    using Engine;

    public class BookStoreMain
    {
        public static void Main()
        {
            BookStoreEngine engine = new BookStoreEngine(new ConsoleRenderer(), new ConsoleInputHandler());

            engine.Run();
        }
    }
}
