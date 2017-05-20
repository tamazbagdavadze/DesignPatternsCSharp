namespace Command
{
    internal abstract class Command
    {
        protected ArithmeticUnit Unit;
        protected int Operand;

        public abstract void Execute();
        public abstract void UnExecute();
    }
}
