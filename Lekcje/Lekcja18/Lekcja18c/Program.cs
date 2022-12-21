using Lekcja18c;

Stack<Memento> mementos = new Stack<Memento>();

Game game = new Game();
game.State = new GameState
{
    Health = 50,
    Level = 1,
    Mana = 75
};

while(game.IsAlive())
{
    mementos.Push(game.SaveState());
    game.Fight();
}

Console.WriteLine("Koniec gry");
Console.WriteLine(game);

game.LoadState(mementos.Pop());
Console.WriteLine("Stan po załadowaniu poprzedniego checkpointa");
Console.WriteLine(game);