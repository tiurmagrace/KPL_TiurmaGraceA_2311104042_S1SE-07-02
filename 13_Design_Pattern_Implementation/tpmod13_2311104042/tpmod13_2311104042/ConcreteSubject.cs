using System;
using System.Collections.Generic;
using System.Threading;

namespace tpmodul13_2311104042
{
    public class ConcreteSubject : ISubject
    {
        public int State { get; set; } = 0;

        private List<IObserver> _observers = new List<IObserver>();

        public void Attach(IObserver observer)
        {
            Console.WriteLine("Subject: Observer ditambahkan.");
            _observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            _observers.Remove(observer);
            Console.WriteLine("Subject: Observer dihapus.");
        }

        public void Notify()
        {
            Console.WriteLine("Subject: Memberitahu observer...");
            foreach (var observer in _observers)
            {
                observer.Update(this);
            }
        }

        public void SomeBusinessLogic()
        {
            Console.WriteLine("\nSubject: Saya melakukan sesuatu yang penting.");
            this.State = new Random().Next(0, 10);

            Thread.Sleep(15);

            Console.WriteLine($"Subject: State saya telah berubah menjadi: {this.State}");
            this.Notify();
        }
    }
}
