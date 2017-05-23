using System;

namespace Strategy.Fly
{
    public class NoFly : IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("no fly");
        }
    }
}
