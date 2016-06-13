using System;
using Exam_20_12._15.Interfaces;

namespace Exam_20_12._15.IO
{
    class InputReader : IInputReader
    {
        public string ReadLine()
        {
            var input = Console.ReadLine();
            return input;
        }
    }
}
