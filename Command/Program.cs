using System;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculator = new Calculator();

            var result = 0;

            result = calculator.Add(5);
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
