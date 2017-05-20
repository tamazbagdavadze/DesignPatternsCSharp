namespace Command
{
    internal class Calculator
    {
        private readonly ArithmeticUnit _arithmeticUnit;
        private readonly ControlUnit _controlUnit;

        public Calculator()
        {
            _arithmeticUnit = new ArithmeticUnit();
            _controlUnit = new ControlUnit();
        }

        private int Run(Command command)
        {
            _controlUnit.StoreCommand(command);
            _controlUnit.ExecuteCommand();
            return _arithmeticUnit.Register;
        }

        public int Add(int v)
        {
            return Run(new Add(_arithmeticUnit, v));
        }

        public int Sub(int v)
        {
            return Run(new Sub(_arithmeticUnit, v));
        }

        public int Undo(int levels)
        {
            _controlUnit.Undo(levels);
            return _arithmeticUnit.Register;
        }

        public int Redo(int levels)
        {
            _controlUnit.Redo(levels);
            return _arithmeticUnit.Register;
        }
    }
}
