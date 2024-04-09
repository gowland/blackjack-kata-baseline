using BlackjackGame;

namespace BlackjackGameTests;

public class HandValueAceTest
{
    private static readonly Suit DUMMY_SUIT = Suit.Clubs;

    [Test]
    public void HandWithOneAceAndOtherCardValuedLessThan10ThenAceIsValuedAt11()
    {
        Hand hand = CreateHand(Rank.Ace, Rank.Five);
        Assert.IsTrue(hand.ValueEquals(11 + 5));
    }

    [Test]
    public void HandWithOneAceAndOtherCardsValuedAt10ThenAceIsValuedAt11()
    {
        Hand hand = CreateHand(Rank.Ace, Rank.Ten);
        Assert.IsTrue(hand.ValueEquals(11 + 10));
    }

    [Test]
    public void HandWithOneAceAndOtherCardsValuedAs11ThenAceIsValuedAt1()
    {
        Hand hand = CreateHand(Rank.Ace, Rank.Eight, Rank.Three);
        Assert.IsTrue(hand.ValueEquals(1 + 8 + 3));
    }

    private Hand CreateHand(params Rank[] ranks)
    {
        List<Card> cards = new List<Card>();
        foreach (Rank rank in ranks)
        {
            cards.Add(new Card(DUMMY_SUIT, rank));
        }
        return new Hand(cards);
    }
}