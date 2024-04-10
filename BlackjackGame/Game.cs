namespace BlackjackGame;

public class Game
{
    private readonly Deck _deck;

    private readonly Hand _dealerHand = new Hand();
    private readonly Hand _playerHand = new Hand();

    public void StartPlay()
    {
        DisplayWelcomeScreen();
        WaitForEnterFromUser();

        PlayGame();

        ResetScreen();
    }

    private static void ResetScreen()
    {
        Console.ResetColor();
    }

    private static void PlayGame()
    {
        Game game = new Game();
        game.InitialDeal();
        game.Play();
    }

    private static void WaitForEnterFromUser()
    {
        Console.WriteLine("Hit [ENTER] to start...");
        Console.ReadLine();
    }

    private static void DisplayWelcomeScreen()
    {
        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Clear();
        Console.WriteLine("Welcome to JitterTed's BlackJack game");
        Console.ResetColor();
    }

    public Game()
    {
        _deck = new Deck();
    }

    private void InitialDeal()
    {
        DealRoundOfCards();
        DealRoundOfCards();
    }

    private void Play()
    {
        PlayerTurn();

        DealerTurn();

        DisplayFinalGameState();

        DetermineOutcome();
    }

    private void DealRoundOfCards()
    {
        _playerHand.DrawFrom(_deck);
        _dealerHand.DrawFrom(_deck);
    }

    private void DetermineOutcome()
    {
        if (_playerHand.IsBusted())
        {
            Console.WriteLine("You Busted, so you lose.  💸");
        }
        else if (_dealerHand.IsBusted())
        {
            Console.WriteLine("Dealer went BUST, Player wins! Yay for you!! 💵");
        }
        else if (_playerHand.Beats(_dealerHand))
        {
            Console.WriteLine("You beat the Dealer! 💵");
        }
        else if (_playerHand.Pushes(_dealerHand))
        {
            Console.WriteLine("Push: Nobody wins, we'll call it even.");
        }
        else
        {
            Console.WriteLine("You lost to the Dealer. 💸");
        }
    }

    private void DealerTurn()
    {
        if (!_playerHand.IsBusted())
        {
            while (_dealerHand.DealerMustDrawCard())
            {
                _dealerHand.DrawFrom(_deck);
            }
        }
    }

    private void PlayerTurn()
    {
        while (!_playerHand.IsBusted())
        {
            DisplayGameState();
            string? playerChoice = InputFromPlayer()?.ToLower();
            if (playerChoice?.StartsWith("s") ?? false)
            {
                break;
            }
            if (playerChoice?.StartsWith("h") ?? false)
            {
                _playerHand.DrawFrom(_deck);
                if (_playerHand.IsBusted())
                {
                    return;
                }
            }
            else
            {
                Console.WriteLine("You need to [H]it or [S]tand");
            }
        }
    }

    private string? InputFromPlayer()
    {
        Console.WriteLine("[H]it or [S]tand?");
        return Console.ReadLine();
    }
    
    private void DisplayBackOfCard()
    {
        Console.WriteLine("┌─────────┐");
        Console.WriteLine("│░░░░░░░░░│");
        Console.WriteLine("│░ J I T ░│");
        Console.WriteLine("│░ T E R ░│");
        Console.WriteLine("│░ T E D ░│");
        Console.WriteLine("│░░░░░░░░░│");
        Console.WriteLine("└─────────┘");
    }

    private void DisplayGameState()
    {
        Console.Clear();
        Console.WriteLine("Dealer has: ");
        WriteColoredString(_dealerHand.DisplayFaceUpCard());

        // second card is the hole card, which is hidden, or "face down"
        DisplayBackOfCard();

        Console.WriteLine();
        Console.WriteLine("Player has: ");
        WriteDisplayInfos(_playerHand.Display());
        Console.WriteLine(" (" + _playerHand.DisplayValue() + ")");
    }
    
    private void WriteDisplayInfos(IEnumerable<(string, ConsoleColor)> displayInfos)
    {
        foreach (var displayInfo in displayInfos)
        {
            WriteColoredString(displayInfo);        
        }
    }
    
    private void WriteColoredString((string Text, ConsoleColor Color) displayInfo)
    {
        // Store the original color so we can reset it
        ConsoleColor originalColor = Console.ForegroundColor;

        // Set the color and write the text
        Console.ForegroundColor = displayInfo.Color;
        Console.WriteLine(displayInfo.Text);

        // Reset the color
        Console.ForegroundColor = originalColor;
    }

    private void DisplayFinalGameState()
    {
        Console.Clear();
        Console.WriteLine("Dealer has: ");
        WriteDisplayInfos(_dealerHand.Display());
        Console.WriteLine(" (" + _dealerHand.DisplayValue() + ")");

        Console.WriteLine();
        Console.WriteLine("Player has: ");
        WriteDisplayInfos(_playerHand.Display());
        Console.WriteLine(" (" + _playerHand.DisplayValue() + ")");
    }
}