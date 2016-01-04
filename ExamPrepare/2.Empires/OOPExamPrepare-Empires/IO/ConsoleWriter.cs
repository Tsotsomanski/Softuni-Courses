using System;
using OOPExamPrepare_Empires.Interfaces;

namespace OOPExamPrepare_Empires.IO
{
    class ConsoleWriter : IOutputWriter
    {
        public void Print(string message)
        {
            Console.WriteLine(message);
        }
    }
}
