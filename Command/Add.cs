namespace Command
{
    internal class Add : Command
    {
        public Add(ArithmeticUnit unit, int operand)
        {
            Unit = unit;
            Operand = operand;
        }

        public override void Execute()
        {
            Unit.Run('+', Operand);
        }

        public override void UnExecute()
        {
            Unit.Run('-', Operand);
        }
    }
}
