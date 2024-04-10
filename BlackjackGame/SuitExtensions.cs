namespace BlackjackGame;

public static class SuitExtensions
{
    public static string Symbol(this Suit suit)
    {
        return suit switch
        {
            Suit.Hearts => "♥",
            Suit.Clubs => "♣",
            Suit.Diamonds => "♦",
            Suit.Spades => "♠",
            _ => throw new ArgumentOutOfRangeException()
        };
    }

    public static bool IsRed(this Suit suit)
    {
        return suit switch
        {
            Suit.Hearts => true,
            Suit.Diamonds => true,
            Suit.Clubs => false,
            Suit.Spades => false,
            _ => throw new ArgumentOutOfRangeException()
        };
    }
}