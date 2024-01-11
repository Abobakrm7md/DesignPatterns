using ObserverPattern.Observable;
using ObserverPattern.ObservarInterfaces;

namespace ObserverPattern.Observer
{
    //Define one of observers 
    internal class User : IObserver
    {
        private string username;
        private ChatRoom room;

        public User(string username, ChatRoom room)
        {
            this.username = username;
            this.room = room;
        }

        public void Update(string message)
        {
            Console.WriteLine($"{username} received a message: {message}");
        }
        public void SendMessage(string message)
        {
            Console.WriteLine($"{username} : {message}");

            room.SendMessageToOthers(message, this);
        }
    }
}
