namespace State
{
    internal abstract class State
    {
        public abstract void Handle(Context context);
    }
}