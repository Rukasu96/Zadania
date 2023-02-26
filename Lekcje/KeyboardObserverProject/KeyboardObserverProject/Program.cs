

using KeyboardObserverProject;

void Method()
{
    Console.WriteLine("<");
}

Keyboard keyboard = new Keyboard();
bool running = true;
keyboard.OnLeft += Method;


keyboard.OnRight += () => Console.WriteLine(">");
keyboard.OnUp += () => Console.WriteLine("/\\");

keyboard.OnDown += () =>
{
    keyboard.OnLeft -= Method;
    Console.WriteLine("Usuniet metoda");
};

keyboard.OnEnter += () => running = false;


while(running)
{
    keyboard.UpdateEvents();
}

