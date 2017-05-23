using System;

namespace Mediator
{
    public class Farmer : Colleague
    {
        public Farmer(Mediator mediator) : base(mediator)
        {
        }

        public void GrowTomato()
        {
            var tomato = "tomato";

            Console.WriteLine("done : " + tomato);

            mediator.Send(tomato, this);
        }
    }
}
