namespace BlackjackGame;

public static class RankExtensions
{
    public static string Display(this Rank rank)
    {
        switch (rank)
        {
            case Rank.Ace:
                return "A";
            case Rank.Two:
                return "2";
            case Rank.Three:
                return "3";
            case Rank.Four:
                return "4";
            case Rank.Five:
                return "5";
            case Rank.Six:
                return "6";
            case Rank.Seven:
                return "7";
            case Rank.Eight:
                return "8";
            case Rank.Nine:
                return "9";
            case Rank.Ten:
                return "10";
            case Rank.Jack:
                return "J";
            case Rank.Queen:
                return "Q";
            case Rank.King:
                return "K";
            default:
                throw new ArgumentOutOfRangeException();
        }
    }
    
    public static int Value(this Rank rank)
    {
        switch (rank)
        {
            case Rank.Ace:
                return 1;
            case Rank.Two:
                return 2;
            case Rank.Three:
                return 3;
            case Rank.Four:
                return 4;
            case Rank.Five:
                return 5;
            case Rank.Six:
                return 6;
            case Rank.Seven:
                return 7;
            case Rank.Eight:
                return 8;
            case Rank.Nine:
                return 9;
            case Rank.Ten:
            case Rank.Jack:
            case Rank.Queen:
            case Rank.King:
                return 10;
            default:
                throw new ArgumentOutOfRangeException();
        }
    }
}