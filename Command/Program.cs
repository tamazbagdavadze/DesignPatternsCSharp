using System;

namespace Command
{
    internal class Program
    {
        private static void Main()
        {
            var calculator = new Calculator();

            var result = calculator.Add(5);
            Console.WriteLine(result);

            result = calculator.Sub(3);
            Console.WriteLine(result);

            result = calculator.Undo(2);
            Console.WriteLine(result);

            result = calculator.Redo(1);
            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}
