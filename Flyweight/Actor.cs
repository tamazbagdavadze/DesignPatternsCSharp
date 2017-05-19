using System;

namespace Flyweight
{
    class Actor : Flyweight
    {
        public override void Greeting(string speech)
        {
            Console.WriteLine(speech);
        }
    }
}