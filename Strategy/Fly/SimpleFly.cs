using System;

namespace Strategy.Fly
{
    public class SimpleFly : IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("simple fly");
        }
    }
}
