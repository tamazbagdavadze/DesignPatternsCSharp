namespace Flyweight
{
    internal class Role1 : Flyweight
    {
        private readonly Flyweight _flyweight;

        public Role1(Flyweight flyweight)
        {
            _flyweight = flyweight;
        }

        public override void Greeting(string speech)
        {
            _flyweight.Greeting(speech);
        }
    }
}