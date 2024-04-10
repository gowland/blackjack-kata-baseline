namespace BlackjackGame;

public static class RankExtensions
{
    private const int TenOrHigherValue = 10;

    public static string Display(this Rank rank)
    {
        return rank switch
        {
            Rank.Ace => "A",
            Rank.Two => "2",
            Rank.Three => "3",
            Rank.Four => "4",
            Rank.Five => "5",
            Rank.Six => "6",
            Rank.Seven => "7",
            Rank.Eight => "8",
            Rank.Nine => "9",
            Rank.Ten => "10",
            Rank.Jack => "J",
            Rank.Queen => "Q",
            Rank.King => "K",
            _ => throw new ArgumentOutOfRangeException()
        };
    }
    
    public static int Value(this Rank rank)
    {
        return rank switch
        {
            Rank.Ace => 1,
            Rank.Two => 2,
            Rank.Three => 3,
            Rank.Four => 4,
            Rank.Five => 5,
            Rank.Six => 6,
            Rank.Seven => 7,
            Rank.Eight => 8,
            Rank.Nine => 9,
            Rank.Ten => TenOrHigherValue,
            Rank.Jack => TenOrHigherValue,
            Rank.Queen => TenOrHigherValue,
            Rank.King => TenOrHigherValue,
            _ => throw new ArgumentOutOfRangeException()
        };
    }
}