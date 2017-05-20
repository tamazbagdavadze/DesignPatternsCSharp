namespace State
{
    internal class Program
    {
        private static void Main()
        {
            var context = new Context(new ConcreteStateA());
            context.Request();
            context.Request();
        }
    }
}