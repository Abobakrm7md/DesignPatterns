using ObserverPattern.ObservableInterface;
using ObserverPattern.ObservarInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Observable
{
    public class ChatRoom : ISubject
    {
        private List<IObserver> observers = new List<IObserver>();

        public void RegisterObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void NotifyObservers(string message , List<IObserver> observers)
        {
            foreach (var observer in observers)
            {
                observer.Update(message);
            }
        }

        public void SendMessage(string message)
        {
            Console.WriteLine($"Message sent: {message}");
            NotifyObservers(message, observers);
        }
        public void SendMessageToOthers(string message , IObserver observer)
        {
            var otherObservers = observers;
            RemoveObserver(observer);
            NotifyObservers(message, otherObservers);
            RegisterObserver(observer);
        }
    }
}
