using System;

namespace Strategy
{
    public class RubberDuck : DuckBase
    {
        public override void SomeCommonFunc()
        {
            Console.WriteLine("common func");
        }
    }
}
