namespace OOP;

class Game
{
    public GameAccount Winner { get; }
    public GameAccount Looser { get; }
    public int Rating { get; }
    private static uint TotalId = 1; 
    public uint Id;

    public Game(GameAccount firstPlayer, GameAccount secondPlayer, int rating)
    {
        Winner = firstPlayer;
        Looser = secondPlayer;
        Rating = rating;
        Id = TotalId++;
    }

}
