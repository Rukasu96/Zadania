using BankMediator;

Bank bank = new Bank();
Account konto1 = new Account("Łukasz", "Kulesza", "23041", 23304);
Account konto2 = new Account("Jakub", "Kowalski", "12022", 24672);

bank.AddAccount(konto1);
bank.AddAccount(konto2);

konto1.Transfer(konto2, 700);