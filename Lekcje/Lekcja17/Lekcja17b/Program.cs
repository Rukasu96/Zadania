using Lekcja17b;

Device device = new Device();

while(device.IsOn)
{
    Console.Clear();
    device.ShowDisplay();
    Console.WriteLine("/\\ - w, \\/ - s, < - a");
    string response = Console.ReadLine();
    switch(response)
    {
        case "w":
            device.ClickUp();
            break;
        case "s":
            device.ClickDown();
            break;
        case "a":
            device.ClickBack();
            break;
    }
}
