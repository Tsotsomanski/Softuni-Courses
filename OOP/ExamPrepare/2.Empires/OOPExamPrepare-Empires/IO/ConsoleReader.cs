using System;
using OOPExamPrepare_Empires.Interfaces;

namespace OOPExamPrepare_Empires.IO
{
    class ConsoleReader : IInputReader
    {
        public string ReadLine()
        {
            var input = Console.ReadLine();

            return input;
        }
    }
}
