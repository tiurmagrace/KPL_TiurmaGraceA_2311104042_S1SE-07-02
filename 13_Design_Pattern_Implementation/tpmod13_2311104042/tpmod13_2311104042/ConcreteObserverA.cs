using System;

namespace tpmodul13_2311104042
{
    public class ConcreteObserverA : IObserver
    {
        public void Update(ISubject subject)
        {
            if ((subject as ConcreteSubject).State < 3)
            {
                Console.WriteLine("ConcreteObserverA: Merespons perubahan state yang kecil");
            }
        }
    }
}
