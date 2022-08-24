//Singleton
//jest dostepny wszedzie (statyczna instancja)
//istnieje tylko jedna instancja tego obiektu (prywatny konstruktor)

using SingletonPattern;

Console.WriteLine(Settings.Instance.Music);

Settings.Instance.SoundUp();
