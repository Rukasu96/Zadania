
using System.ComponentModel;
using ZadanieLinq;

User user1 = new User("Janusz", "Admin", 40, null, new DateTime(2002,03,01), null);
User user2 = new User("Mikołaj", "Moderator", 34, null, new DateTime(2002,03,01), null);
User user3 = new User("Łukasz", "Moderator", 35, null, new DateTime(2002,03,01), new DateTime(2008,6,6));
User user4 = new User("Joanna", "Teacher", 50, null, new DateTime(2002,03,01), null);
User user5 = new User("Paweł", "Student", 15, new int[] { 2, 3, 3, 6, 5 }, new DateTime(2008,04,9), new DateTime(2011,5,8));
User user6 = new User("Halina", "Teacher", 32, null, new DateTime(2002,03, 01), new DateTime(2007, 4, 10));
User user7 = new User("Kuba", "Student", 16, new int[] { 5, 5, 5, 5, 5 }, new DateTime(2007,03,01), new DateTime(2010,2,14));
User user8 = new User("Michał", "Student", 14, new int[] { 1, 1, 1, 1, 2 }, new DateTime(2009,03,01), new DateTime(2012,1,15));
User user9 = new User("Adam", "Student", 17, new int[] { 4, 3, 2, 4, 5 }, new DateTime(2006,04,07), new DateTime(2009,4,4));
User user10 = new User("Monika", "Student", 15, new int[] { 3, 3, 2, 2, 3 }, new DateTime(2008,02,01), new DateTime(2011,6,10));
User user11 = new User("Agnieszka", "Student", 16, new int[] { 2, 4, 4, 4, 5 }, new DateTime(2007,03,04), new DateTime(2010,6,10));
User user12 = new User("Karol", "Student", 16, new int[] { 5, 3, 3, 5, 5 }, new DateTime(2007,01,01), new DateTime(2010,7,20));
User user13 = new User("Konrad", "Student", 17, new int[] { 5, 3, 1, 2, 5 }, new DateTime(2006,03,05), new DateTime(2009,8,24));
User user14 = new User("Karolina", "Student", 14, new int[] { 2, 1, 3, 6, 1 }, new DateTime(2009,03,01), new DateTime(2012,8,27));
User user15 = new User("Marcelina", "Student", 16, new int[] { 1, 1, 5, 4, 5 }, new DateTime(2007,06,06), new DateTime(2010,6,19));
User user16 = new User("Wojtek", "Student", 15, new int[] { 2, 3, 3 }, new DateTime(2008,07,20), new DateTime(2011,9,4));
User user17 = new User("Justyna", "Student", 17, new int[] { 2, 2, 3, 5 }, new DateTime(2006,03,30), new DateTime(2009,4,23));
User user18 = new User("Kuba", "Student", 15, new int[] { 4, 4, 4, 6, 5 }, new DateTime(2008,02,15), new DateTime(2011,5,18));
User user19 = new User("Rafał", "Student", 15, new int[] { 4, 5, 5, 5, 5 }, new DateTime(2008,03,2), new DateTime(2011,4,28));
User user20 = new User("Alex", "Student", 17, new int[] { 1, 5, 5, }, new DateTime(2006,01,10), new DateTime(2009,8,30));

User[] users = new User[20] {user1, user2, user3, user4, user5,user6,user7, user8, user9, user10, 
    user11, user12, user13, user14, user15, user16,user17,user18,user19,user20};


//Ilosc rekordów
Console.WriteLine(users.Length);

//Lista nazw użytkowników
var names = users.Select(x => x.Name).ToList();
names.ForEach(x => Console.WriteLine(x));

//Sortowanie po nazwach
var sortedNames = users.Select(x => x.Name).OrderBy(x => x).ToList();
sortedNames.ForEach(x => Console.WriteLine(x));


//Lista dostępnych ról użytkowników
var allRoles = users.Select(x => x.Role).Distinct().ToList();
allRoles.ForEach(x => Console.WriteLine(x));

//Lista pogrupowanych użytkowników po rolach
var groups = users.GroupBy(x => x.Role).ToList();
foreach(var g in groups)
{
    Console.WriteLine("Rola: " + g.Key);
    foreach(var group in g)
    {
        Console.WriteLine(group.Name);
    }
}

//Ilość rekordów dla których podano oceny nie null i więcej niż 0
var marksCount = users.Count(x => x.Marks != null && x.Marks.Count() > 0);
Console.WriteLine(marksCount);

//Sumę, ilość i średnią wszystkich ocen studentów
var marksStudents = users.Where(x => x.Marks != null && x.Marks.Count() > 0).ToList();
var marksStudentsNames = marksStudents.Select(x => x.Name).ToList();
var sumMarks = marksStudents.Select(x => x.Marks.Sum()).ToList();
var studentmarksCount = marksStudents.Select(x => x.Marks.Count()).ToList();
var averageMarks = marksStudents.Select(x => x.Marks.Average()).ToList();

for (int i = 0; i < marksStudents.Count; i++)
{
    Console.WriteLine($"{marksStudentsNames[i]} Suma: {sumMarks[i]} Ilość: {studentmarksCount[i]} Średnia: {averageMarks[i]}");
}

//Najlepsza ocena
var bestMarks = users.Where(x => x.Marks != null && x.Marks.Count() > 0).Select(x => x.Marks.Max()).ToList();

for (int i = 0; i < marksStudents.Count; i++)
{
    Console.WriteLine($"{marksStudentsNames[i]} {bestMarks[i]}");
}

//Najgorsza ocena
var worstMarks = users.Where(x => x.Marks != null && x.Marks.Count() > 0).Select(x => x.Marks.Min()).ToList();

for (int i = 0; i < marksStudents.Count; i++)
{
    Console.WriteLine($"{marksStudentsNames[i]} {worstMarks[i]}");
}

//Najlepszy student
//var bestStudent = marksStudents.First(x => x.Marks.Average() == averageMarks.Max());
var bestStudent = marksStudents.OrderByDescending(x => x.Marks.Average()).FirstOrDefault();
Console.WriteLine(bestStudent.Name);

//Lista studentów którzy posiadają najmniej ocen
var studentsWithLowestNumberMarks = marksStudents.Where(x => x.Marks.Count() == studentmarksCount.Min()).Select(x => x.Name).ToList();
Console.WriteLine("Studenci z najmniejszą liczbą ocen:");
studentsWithLowestNumberMarks.ForEach(x => Console.WriteLine(x));

//Lista studentów którzy posiadają największą liczbę ocen
var studentsWithHigherNumberMarks = marksStudents.Where(x => x.Marks.Count() == studentmarksCount.Max()).Select(x => x.Name).ToList();
Console.WriteLine("Studenci z największą liczbą ocen:");
studentsWithHigherNumberMarks.ForEach(x => Console.WriteLine(x));

//Lista obiektów zawierającą tylko nazwę i średnią ocenę
var students = marksStudents.Select(x => new Student { Name = x.Name, Average = x.Marks.Average() }).ToList();

//Studenci posortowani od najlepszego
Console.WriteLine("Posortowani od najlepszego:");
var sortedByBest = students.OrderByDescending(x => x.Average).ToList();
foreach (var student in sortedByBest)
{
    Console.WriteLine($"{student.Name} {student.Average}");
}

//Średnia ocena wszystkich studentów
var averageAllStudents = averageMarks.Average();
Console.WriteLine($"Średnia ocena wszystkich studentów: {averageAllStudents}");

//Lista użytkowników pogrupowanych po miesiącach daty utworzenia
Console.WriteLine();
var groupsByMonth = users.GroupBy(x => x.CreatedAt.Value.Year + "-" + x.CreatedAt.Value.Month).ToList();
foreach(var group in groupsByMonth)
{
    Console.WriteLine("Miesiąc: " + group.Key);
    foreach(var student in group)
    {
        Console.WriteLine(student.Name);
    }
}

//Lista użytkowników którzy nie zostali usunięci
Console.WriteLine();
Console.WriteLine("Istniejący użytkownicy: ");
var existusers = users.Where(x => x.RemovedAt == null).Select(x => x.Name).ToList();
existusers.ForEach(x => Console.WriteLine(x));

//Najnowszy student
var newestDate = users.Select(x => x.CreatedAt.Value.Date).Max();
var freshStudent = users.Where(x => x.CreatedAt.Value.Date == newestDate).Select(x => x.Name).ToList();
Console.WriteLine("Najnowsi Studenci: ");
freshStudent.ForEach(x => Console.WriteLine(x));
