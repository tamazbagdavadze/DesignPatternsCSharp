using System;

namespace Mediator
{
    public class Cannery : Colleague
    {
        public Cannery(Mediator mediator) : base(mediator)
        {
        }

        public void MakeKetchup(string msg)
        {
            var ketchup = msg + " ketchup";

            Console.WriteLine("done : " + ketchup);

            mediator.Send(ketchup, this);
        }
    }
}
