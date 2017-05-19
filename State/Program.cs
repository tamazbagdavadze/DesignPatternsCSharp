namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new Context(new ConcreteStateA());
            context.Request();
            context.Request();
        }
    }

    class Context
    {
        public State State { get; set; }

        public Context(State state)
        {
            State = state;
        }

        public void Request()
        {
            State.Handle(this);
        }
    }

    abstract class State
    {
        public abstract void Handle(Context context);
    }

    class ConcreteStateA : State
    {
        public override void Handle(Context context)
        {
            context.State = new ConcreteStateB();
        }
    }

    class ConcreteStateB : State
    {
        public override void Handle(Context context)
        {
            context.State = new ConcreteStateA();
        }
    }
}