using System;

namespace Command
{
    internal class ArithmeticUnit
    {
        public int Register { get; set; }

        public void Run(char operationCode, int operand)
        {
            switch (operationCode)
            {
                case '+':
                    Register += operand;
                    break;
                case '-':
                    Register -= operand;
                    break;
                default: throw new NotImplementedException();
            }
        }
    }
}
