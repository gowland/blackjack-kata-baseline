using BlackjackGame;

namespace BlackjackGameTests;

public class HandValueAceTest
{
    private const Suit DummySuit = Suit.Clubs;

    [Test]
    public void HandWithOneAceAndOtherCardValuedLessThan10ThenAceIsValuedAt11()
    {
        Hand hand = CreateHand(Rank.Ace, Rank.Five);
        Assert.That(hand.ValueEquals(16), Is.True);
    }

    [Test]
    public void HandWithOneAceAndOtherCardsValuedAt10ThenAceIsValuedAt11()
    {
        Hand hand = CreateHand(Rank.Ace, Rank.Ten);
        Assert.That(hand.ValueEquals(21), Is.True);
    }

    [Test]
    public void HandWithOneAceAndOtherCardsValuedAs11ThenAceIsValuedAt1()
    {
        Hand hand = CreateHand(Rank.Ace, Rank.Eight, Rank.Three);
        Assert.That(hand.ValueEquals(12), Is.True);
    }

    private Hand CreateHand(params Rank[] ranks)
    {
        return new Hand(ranks.Select(rank => new Card(DummySuit, rank)).ToList());
    }
}