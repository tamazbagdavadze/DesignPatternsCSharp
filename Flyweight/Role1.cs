namespace Flyweight
{
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
}