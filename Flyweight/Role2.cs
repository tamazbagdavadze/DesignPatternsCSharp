namespace Flyweight
{
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
}