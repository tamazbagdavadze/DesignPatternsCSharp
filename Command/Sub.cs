namespace Command
{
    internal class Sub : Command
    {
        public Sub(ArithmeticUnit unit, int operand)
        {
            Unit = unit;
            Operand = operand;
        }

        public override void Execute()
        {
            Unit.Run('-', Operand);
        }

        public override void UnExecute()
        {
            Unit.Run('+', Operand);
        }
    }
}
