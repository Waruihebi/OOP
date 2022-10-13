namespace OOP;
class GameAccount
{
    private string UserName { get; }
    private int CurrentRating{ get; set; }
    private int GamesCount{ get; set; }
    private List<Game> GamesHistory = new();
    
    public GameAccount(string UserName)
    {
        this.UserName = UserName;
        CurrentRating = 1;
        GamesCount = 0;
    }
    public void WinGame(GameAccount opponentName, int rating)
    {
        var game = new Game(this, opponentName, rating);
        opponentName.LoseGame( game, rating);
        CurrentRating += rating;
        GamesCount++;
        GamesHistory.Add(game);
        if (rating <= 0) throw new ArgumentOutOfRangeException("Рейтинг має бути більшим ніж 0");
    }
    
    private void LoseGame(Game game,int rating)
    {
        if (rating > CurrentRating)
            CurrentRating = 1;
        else CurrentRating -= rating;
        GamesHistory.Add(game);
        GamesCount++;
    }
    
    public void GetStats()
    {
        Console.WriteLine("Cтатус гравця: "+ UserName, "\n");
        int i = 1;
        foreach (Game game in GamesHistory)
        {
            Console.Write("Змагання номер " + i +  ":\n");
            Console.Write("Переможець - " + game.Winner.UserName);
            Console.Write("  "+ "Програвший - " + game.Looser.UserName);
            Console.WriteLine("  " + "Рейтинг - " + game.Rating + "  " + "Проведено змагань: " + game.Id);
            i++;
        }
        Console.WriteLine("\nПроведено змагань: " + GamesCount);
        Console.WriteLine("Актуальний рейтинг гравця " + UserName + ": " + CurrentRating);
        
    }
}

