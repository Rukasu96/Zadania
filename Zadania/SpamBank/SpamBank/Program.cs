using SpamBank;

Bank bank = new Bank();
Client client1 = new Client("Łukasz");
Client client2 = new Client("Bartosz");
Client client3 = new Client("Radosław");
Client client4 = new Client("Karol");

bank.addSubscriber(client1);
bank.addSubscriber(client2);
bank.addSubscriber(client4);

bank.SendMessage("Weź kredyt");
bank.SendMessage("Rachunki zostały opłacone");
bank.SendMessage("Zgłoś się do banku po chwilówke");

client1.CheckSpam();
client2.CheckSpam();
client3.CheckSpam();
client4.CheckSpam();