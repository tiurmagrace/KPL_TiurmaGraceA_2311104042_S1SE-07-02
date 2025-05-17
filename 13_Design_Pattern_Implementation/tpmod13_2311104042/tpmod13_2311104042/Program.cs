using System;

namespace tpmodul13_2311104042
{
    class Program
    {
        static void Main(string[] args)
        {
            var subject = new ConcreteSubject();

            var observerA = new ConcreteObserverA();
            subject.Attach(observerA);

            var observerB = new ConcreteObserverB();
            subject.Attach(observerB);

            subject.SomeBusinessLogic();
            subject.SomeBusinessLogic();

            subject.Detach(observerA);

            subject.SomeBusinessLogic();

            Console.WriteLine("Tekan tombol apa saja untuk keluar...");
            Console.ReadKey();
        }
    }
}
