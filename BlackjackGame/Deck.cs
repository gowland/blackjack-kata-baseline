namespace BlackjackGame;

public class Deck
{
    private readonly List<Card> _cards = new();

    public Deck()
    {
        foreach (Suit suit in Enum.GetValues(typeof(Suit)))
        {
            foreach (Rank rank in Enum.GetValues(typeof(Rank)))
            {
                _cards.Add(new Card(suit, rank));
            }
        }
        Shuffle(_cards);
    }

    public int Size()
    {
        return _cards.Count;
    }

    public Card Draw()
    {
        Card card = _cards[0];
        _cards.RemoveAt(0);
        return card;
    }

    private void Shuffle(List<Card> list)
    {
        Random rng = new Random();
        int n = list.Count;
        while (n > 1)
        {
            n--;
            int k = rng.Next(n + 1);
            (list[k], list[n]) = (list[n], list[k]);
        }
    }
}