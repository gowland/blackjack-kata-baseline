﻿namespace BlackjackGame;

public class Hand
{
    private readonly List<Card> _cards = new List<Card>();

    public Hand(List<Card> cards)
    {
        this._cards.AddRange(cards);
    }

    public Hand()
    {
    }

    private int Value()
    {
        int handValue = _cards.Sum(card => card.RankValue());

        // does the hand contain at least 1 Ace?
        bool hasAce = _cards.Any(card => card.RankValue() == 1);

        // if the total hand value <= 11, then count the Ace as 11 by adding 10
        if (hasAce && handValue <= 11)
        {
            handValue += 10;
        }

        return handValue;
    }

    public (string, ConsoleColor) DisplayFaceUpCard()
    {
        return _cards[0].Display();
    }

    public bool DealerMustDrawCard()
    {
        return Value() <= 16;
    }

    public IEnumerable<(string, ConsoleColor)> Display()
    {
        return _cards.Select(card => card.Display());
    }

    public void DrawFrom(Deck deck)
    {
        _cards.Add(deck.Draw());
    }

    public bool IsBusted()
    {
        return Value() > 21;
    }

    public bool Pushes(Hand hand)
    {
        return hand.Value() == Value();
    }

    public bool Beats(Hand hand)
    {
        return hand.Value() < Value();
    }

    public string DisplayValue()
    {
        return Value().ToString();
    }

    public bool ValueEquals(int target)
    {
        return Value() == target;
    }
}