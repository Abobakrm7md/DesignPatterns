// Create a chat room
using ObserverPattern.Observable;
using ObserverPattern.Observer;

ChatRoom chatRoom = new ChatRoom();

// Create users
User user1 = new User("User1", chatRoom);
User user2 = new User("User2", chatRoom);
User user3 = new User("User3", chatRoom);

// Register users as observers
chatRoom.RegisterObserver(user1);
chatRoom.RegisterObserver(user2);
chatRoom.RegisterObserver(user3);
chatRoom.SendMessage("Start Conversation");
// Users send messages
user1.SendMessage("Hello, everyone!");
user2.SendMessage("How are you?");
user3.SendMessage("I'm fine, thank you!");
