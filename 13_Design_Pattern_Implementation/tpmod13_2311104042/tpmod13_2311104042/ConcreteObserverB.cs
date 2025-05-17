using System;

namespace tpmodul13_2311104042
{
    public class ConcreteObserverB : IObserver
    {
        public void Update(ISubject subject)
        {
            if ((subject as ConcreteSubject).State >= 3)
            {
                Console.WriteLine("ConcreteObserverB: Merespons perubahan state yang besar");
            }
        }
    }
}
