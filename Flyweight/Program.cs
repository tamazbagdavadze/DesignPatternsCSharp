using System;

namespace Flyweight
{
    internal class Program
    {
        private static void Main()
        {
            var actor = new Actor();

            var role = new Role1(actor);
            role.Greeting("1");

            var role2 = new Role2(actor);
            role2.Greeting("2");

            Console.ReadLine();
        }
    }
}
