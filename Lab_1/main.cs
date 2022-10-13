namespace OOP;

class main
    {
       public static void Main()
        {   
            GameAccount Vlad = new GameAccount("Vlad");
            GameAccount Olya = new GameAccount("Olya");

            for (int i = 0; i < 4; i++)
                
            {
                if (i == 2)
                    Vlad.WinGame(Olya, 5);
                else
                    Olya.WinGame(Vlad, 5);
            }
            Olya.GetStats();
            Vlad.GetStats();
            Console.WriteLine();
        }
    }
