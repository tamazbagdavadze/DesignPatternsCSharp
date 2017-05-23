using Strategy.Fly;

namespace Strategy
{
    public abstract class DuckBase
    {
        protected IFlyable flyBehavior;

        public DuckBase()
        {
            flyBehavior = new NoFly();
        }

        public void Fly()
        {
            flyBehavior.Fly();
        }

        public void SetFlyBehavior(IFlyable behavior)
        {
            flyBehavior = behavior;
        }

        public abstract void SomeCommonFunc();
    }
}
