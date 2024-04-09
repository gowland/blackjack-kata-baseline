namespace BlackjackGame;

public class Card : IEquatable<Card>
{
    private readonly Suit _suit;
    private readonly Rank _rank;

    public Card(Suit suit, Rank rank)
    {
        this._suit = suit;
        this._rank = rank;
    }

    public int RankValue()
    {
        return _rank.Value();
    }

    public (string, ConsoleColor) Display()
    {
        string[] lines = new string[7];
        lines[0] = "┌─────────┐";
        lines[1] = String.Format("│{0}{1}       │", _rank.Display(), _rank == Rank.Ten ? "" : " ");
        lines[2] = "│         │";
        lines[3] = String.Format("│    {0}    │", _suit.Symbol());
        lines[4] = "│         │";
        lines[5] = String.Format("│       {0}{1}│", _rank == Rank.Ten ? "" : " ", _rank.Display());
        lines[6] = "└─────────┘";

        ConsoleColor cardColor = _suit.IsRed() ? ConsoleColor.Red : ConsoleColor.Black;
        return (String.Join(Environment.NewLine, lines), cardColor);
    }

    public override string ToString()
    {
        return $"Card {{ suit={_suit}, rank={_rank} }}";
    }

    public override bool Equals(object? obj)
    {
        if (ReferenceEquals(null, obj)) return false;
        if (ReferenceEquals(this, obj)) return true;
        if (obj.GetType() != GetType()) return false;
        return Equals((Card)obj);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine((int)_suit, (int)_rank);
    }

    public bool Equals(Card? other)
    {
        if (ReferenceEquals(null, other)) return false;
        if (ReferenceEquals(this, other)) return true;
        return _suit == other._suit && _rank == other._rank;
    }
}