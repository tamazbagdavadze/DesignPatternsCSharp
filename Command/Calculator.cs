namespace Command
{
    class Calculator
    {
        ArithmeticUnit arithmeticUnit;
        ControlUnit controlUnit;

        public Calculator()
        {
            arithmeticUnit = new ArithmeticUnit();
            controlUnit = new ControlUnit();
        }

        private int Run(Command command)
        {
            controlUnit.StoreCommand(command);
            controlUnit.ExecuteCommand();
            return arithmeticUnit.Register;
        }

        public int Add(int v)
        {
            return Run(new Add(arithmeticUnit, v));
        }

        public int Sub(int v)
        {
            return Run(new Sub(arithmeticUnit, v));
        }

        public int Undo(int levels)
        {
            controlUnit.Undo(levels);
            return arithmeticUnit.Register;
        }

        public int Redo(int levels)
        {
            controlUnit.Redo(levels);
            return arithmeticUnit.Register;
        }
    }
}
