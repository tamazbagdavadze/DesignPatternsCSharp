using System;

namespace ChainOfResponsibility
{
    class ConcreteHandler1 : Handler
    {
        public override void HandleRequest(int request)
        {
            if(request == 1)
            {
                Console.WriteLine("one");
            }
            else if(Successor != null)
            {
                Successor.HandleRequest(request);
            }
        }
    }
}
