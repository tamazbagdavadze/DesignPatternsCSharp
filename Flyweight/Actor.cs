using System;

namespace Flyweight
{
    internal class Actor : Flyweight
    {
        public override void Greeting(string speech)
        {
            Console.WriteLine(speech);
        }
    }
}