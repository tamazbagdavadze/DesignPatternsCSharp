using System;

namespace ChainOfResponsibility
{
    public class ConcreteHandler2 : Handler
    {
        public override void HandleRequest(int request)
        {
            if (request == 2)
            {
                Console.WriteLine("two");
            }
            else if (Successor != null)
            {
                Successor.HandleRequest(request);
            }
        }
    }
}
