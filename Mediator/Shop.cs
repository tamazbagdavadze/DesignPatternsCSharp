using System;

namespace Mediator
{
    public class Shop : Colleague
    {
        public Shop(Mediator mediator) : base(mediator)
        {
        }

        public void Sell(string msg)
        {
            Console.WriteLine("sold : " + msg);
        }
    }
}
