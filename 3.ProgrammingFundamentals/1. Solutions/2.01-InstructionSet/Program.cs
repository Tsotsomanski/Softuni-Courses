using System;

class InstructionSet_broken
{
    static void Main()
    {
        string opCode;

        while ((opCode = Console.ReadLine()) != "END")
        {
            string[] codeArgs = opCode.Split(' ');

            long result = 0;
            switch (codeArgs[0])
            {
                case "INC":
                    {
                        int operandOne = int.Parse(codeArgs[1]);
                        result = (uint)++operandOne;
                        break;
                    }
                case "DEC":
                    {
                        long operandOne = long.Parse(codeArgs[1]);
                        if (operandOne < 0)
                        {
                            result = (long)(--operandOne);
                            break;
                        }
                        else
                        {
                        result = (long)--operandOne;
                        break;    
                        }
                    }
                case "ADD":
                    {
                        int operandOne = int.Parse(codeArgs[1]);
                        int operandTwo = int.Parse(codeArgs[2]);
                        result = (uint)(operandOne + operandTwo);
                        break;
                    }
                case "MLA":
                    {
                        ulong operandOne = ulong.Parse(codeArgs[1]);
                        ulong operandTwo = ulong.Parse(codeArgs[2]);
                        result = (long)(operandOne * operandTwo);
                        break;
                    }
            }

            Console.WriteLine(result);
        }
    }
}