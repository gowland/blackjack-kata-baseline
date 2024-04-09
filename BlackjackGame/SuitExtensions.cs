namespace BlackjackGame;

public static class SuitExtensions
{
    public static string Symbol(this Suit suit)
    {
        switch (suit)
        {
            case Suit.Hearts:
                return "♥";
            case Suit.Clubs:
                return "♣";
            case Suit.Diamonds:
                return "♦";
            case Suit.Spades:
                return "♠";
            default:
                throw new ArgumentOutOfRangeException();
        }
    }

    public static bool IsRed(this Suit suit)
    {
        switch (suit)
        {
            case Suit.Hearts:
            case Suit.Diamonds:
                return true;
            case Suit.Clubs:
            case Suit.Spades:
                return false;
            default:
                throw new ArgumentOutOfRangeException();
        }
    }
}