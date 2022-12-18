class InfoButton
{
    public void Execute()
    {
        Console.WriteLine("Autor: Ada");
    }
}

class RandomButton
{
    public void Execute()
    {
        Random rand = new Random();
        Console.WriteLine(rand.Next(0, 10));
    }
}

class ExitButton
{
    public void Execute()
    {
        Environment.Exit(0);
    }
}

class Button
{
    private Action action;
    private Func<bool> condition;

    public Button(Action action, Func<bool> condition)
    {
        this.action = action;
        this.condition = condition;
    }

    public void Execute()
    {
        if(condition?.Invoke() == true)
        {
            action?.Invoke();
        }
    }
}

class Program
{
    public static void Main(string[] args)
    {
        int currentValue = 15;
        Button info = new Button(() => Console.WriteLine("Autor: Ada"), () => true);
        Button random = new Button(() => Console.WriteLine(new Random().Next(0, 10)), () => currentValue > 8);
        Button exitButton = new Button(() => Environment.Exit(0), () => true);
    }
}
