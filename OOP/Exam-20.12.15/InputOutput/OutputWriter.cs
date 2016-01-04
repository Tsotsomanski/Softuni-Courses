using System;
using Exam_20_12._15.Interfaces;

namespace Exam_20_12._15.IO
{
    class OutputWriter : IOutputWriter
    {
        public void Print(string message)
        {
            Console.WriteLine(message);
        }
    }
}
