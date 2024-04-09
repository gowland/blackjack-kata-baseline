namespace BlackjackGame;

public class Card
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

    public override bool Equals(object obj)
    {
        if (ReferenceEquals(this, obj)) return true;
        if (obj == null || GetType() != obj.GetType()) return false;

        Card card = (Card)obj;

        if (!_suit.Equals(card._suit)) return false;
        return _rank.Equals(card._rank);
    }

    public override int GetHashCode()
    {
        int result = _suit.GetHashCode();
        result = 31 * result + _rank.GetHashCode();
        return result;
    }
}