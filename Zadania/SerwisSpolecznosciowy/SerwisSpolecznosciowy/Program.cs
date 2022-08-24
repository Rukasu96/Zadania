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

Console.WriteLine();
Random rand = new Random();
int[] numbers = new int[42];
for(int i = 0; i < numbers.Length; i++)
{
    numbers[i] = i + 1;
}

for(int i = 0; i < 1000; i++)
{
    int index1 = rand.Next(numbers.Length);
    int index2 = rand.Next(numbers.Length);
    (numbers[index1], numbers[index2]) = (numbers[index2], numbers[index1]);
}

int[] result = numbers[..6];
for(int i = 0; i < result.Length; i++)
{
    Console.WriteLine(result[i]);
}

////zamiana wartsciami
//int a = 5;
//int b = 6;

//int t = a;
//a = b;
//b = t;
////zamiana wartsciami v2
//(a, b) = (b, a);