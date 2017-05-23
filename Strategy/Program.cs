using Strategy.Fly;
using System;
using System.Collections.Generic;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            var ducks = new List<DuckBase>
            {
                new SimpleDuck(),
                new RubberDuck()
            };

            foreach (var duck in ducks)
            {
                duck.Fly();
            }

            Console.WriteLine("----------");

            ducks[1].SetFlyBehavior(new SimpleFly());

            foreach (var duck in ducks)
            {
                duck.Fly();
            }

            Console.ReadLine();
        }
    }
}