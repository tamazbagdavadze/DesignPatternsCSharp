using System;

namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            var mediator = new ConcreteMediator();

            var farmer = new Farmer(mediator);
            var cannary = new Cannery(mediator);
            var shop = new Shop(mediator);

            mediator.Farmer = farmer;
            mediator.Cannery = cannary;
            mediator.Shop = shop;

            farmer.GrowTomato();

            Console.ReadLine();
        }
    }
}