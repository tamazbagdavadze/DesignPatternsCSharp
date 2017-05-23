using System;
using Strategy.Fly;

namespace Strategy
{
    class SimpleDuck : DuckBase
    {
        public SimpleDuck()
        {
            flyBehavior = new SimpleFly();
        }

        public override void SomeCommonFunc()
        {
            Console.WriteLine("common func");
        }
    }
}
