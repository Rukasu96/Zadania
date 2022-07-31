using SerwisSpolecznosciowy;
using System.Runtime.CompilerServices;

Repository repository = new Repository();

User user1 = new User("Happy", "Admin123", "kotek@op.pl");
User user2 = new User("LovelyMan", "Password", "zimneMleko@gmail.com");

Post post1 = new Post(DateTime.Today, "Dzisiaj są moje urodziny!", user2);
Post post2 = new Post(DateTime.Today, "Ma ktoś pożyczyć 15zł? Oddam jutro.", user1);

Comment comm1 = new Comment(DateTime.Today, "Wszystkiego Najlepszego!", user1, post1);
Comment comm2 = new Comment(DateTime.Today, "Napisz na priv", user2, post2);

repository.AddUser(user1);
repository.AddUser(user2);

repository.AddPost(post1);
repository.AddPost(post2);

repository.AddComment(comm1);
repository.AddComment(comm2);

repository.FindFirstPost(x => x.Id == comm1.Id);

repository.wyswietl();
