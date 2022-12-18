using Lekcja16b;
using System.Reflection.Metadata;

ChatRoom chat = new ChatRoom();
ChatUser user1 = new ChatUser("Janusz");
ChatUser user2 = new ChatUser("Ada");

chat.Join(user1);
chat.Join(user2);

user1.Say("Hejka");
user2.Say("Witajcie kochani");

ChatUser user3 = new ChatUser("Ola");
chat.Join(user3);
user3.Say("Hej dawno mnie tu nie bylo..");

user1.PrivateMessage("Ola", "ooo super ze jestes");
Console.WriteLine();