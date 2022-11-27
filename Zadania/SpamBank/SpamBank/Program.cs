using SpamBank;

Bank bank = new Bank();
Client client1 = new Client("Łukasz",true, bank);
Client client2 = new Client("Bartosz", true, bank);
Client client3 = new Client("Radosław", false, bank);
Client client4 = new Client("Karol", true, bank);

bank.WriteMessage();

client1.CheckSpam();
client2.CheckSpam();
client3.CheckSpam();
client4.CheckSpam();