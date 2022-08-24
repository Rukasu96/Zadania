using lekcja7;

//Settings settings = new Settings
//{
//    Brightness = 15,
//    Resolution = "800x600",
//    Sound = 50
//};
//settings.SerializeXML("settings.xml");
//settings.SerializeBinary("settings.bin");

//Settings loadedSettings = Settings.DeserializeXML("settings.xml");

Settings loadedSettings = Settings.DeserializeBinary("settings.bin");
Console.WriteLine(loadedSettings.Resolution);
Console.WriteLine(loadedSettings.Sound);
Console.WriteLine(loadedSettings.Brightness);

