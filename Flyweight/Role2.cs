namespace Flyweight
{
    internal class Role2 : Flyweight
    {
        public readonly Flyweight _flyweight;

        public Role2(Flyweight flyweight)
        {
            _flyweight = flyweight;
        }

        public override void Greeting(string speech)
        {
            _flyweight.Greeting(speech);
        }
    }
}