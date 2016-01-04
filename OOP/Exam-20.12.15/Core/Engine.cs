using System;
using Exam_20_12._15.Enums;
using Exam_20_12._15.Interfaces;

namespace Exam_20_12._15.Core
{
    class Engine : IEngine
    {
        private IBlob blob;
        private Data data;
        private IInputReader reader;
        private IBlobFactory blobFactory;
        private IOutputWriter writer;

        public Engine(IBlob blob, Data data, IInputReader reader, IBlobFactory blobFactory, IOutputWriter writer)
        {
            this.blob = blob;
            this.data = data;
            this.reader = reader;
            this.blobFactory = blobFactory;
            this.writer = writer;
        }

        public void Run()
        {
            while (true)
            {
                string[] input = this.reader.ReadLine().Split();

                this.ExecuteCommand(input);
            }
        }


        private void ExecuteCommand(string[] inputParams)
        {
            switch (inputParams[0])
            {
                case "create":
                    break;
                case "attack":
                    break;
                case "status":
                    break;
                case "drop":
                    Environment.Exit(0);
                    break;
                default:
                    throw new ArgumentException("Unknown command !");
            }
        }
    }
}
