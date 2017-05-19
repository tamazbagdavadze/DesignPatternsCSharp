using System;

namespace Flyweight
{
    class Program
    {
        static void Main(string[] args)
        {
            var actor = new Actor();

            var role = new Role1(actor);
            role.Greeting("1");

            var role2 = new Role2(actor);
            role2.Greeting("2");

            Console.ReadLine();
        }
    }

    abstract class Flyweight
    {
        public abstract void Greeting(string speech);
    }

    class Role1 : Flyweight
    {
        Flyweight flyweight;

        public Role1(Flyweight flyweight)
        {
            this.flyweight = flyweight;
        }

        public override void Greeting(string speech)
        {
            flyweight.Greeting(speech);
        }
    }

    class Role2 : Flyweight
    {
        Flyweight flyweight;

        public Role2(Flyweight flyweight)
        {
            this.flyweight = flyweight;
        }

        public override void Greeting(string speech)
        {
            flyweight.Greeting(speech);
        }
    }

    class Actor : Flyweight
    {
        public override void Greeting(string speech)
        {
            Console.WriteLine(speech);
        }
    }
}
