using System;

class InstructionSet_broken
{
    static void Main()
    {
        string opCode = Console.ReadLine();
        while (opCode != "END")
        {

            string[] codeArgs = opCode.Split(' ');

            long result;
            switch (codeArgs[0])
            {
                case "INC":
                    {
                        long operandOne = long.Parse(codeArgs[1]);
                        result = ++operandOne;
                        Console.WriteLine(result);
                        break;
                    }
                case "DEC":
                    {
                        long operandOne = long.Parse(codeArgs[1]);
                        result = --operandOne;
                        Console.WriteLine(result);
                        break;
                    }
                case "ADD":
                    {
                        long operandOne = long.Parse(codeArgs[1]);
                        long operandTwo = long.Parse(codeArgs[2]);
                        result = operandOne + operandTwo;
                        Console.WriteLine(result);
                        break;
                    }
                case "MLA":
                    {
                        var operandOne = long.Parse(codeArgs[1]);
                        var operandTwo = long.Parse(codeArgs[2]);
                        result = operandOne * operandTwo;
                        Console.WriteLine(result);
                        break;
                    }
            }
            opCode = Console.ReadLine();
        }
    }
}