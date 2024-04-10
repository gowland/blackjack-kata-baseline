using BlackjackGame;

namespace BlackjackGameTests;

public class CardTest
{
    private const Suit DummySuit = Suit.Hearts;
    private const Rank DummyRank = Rank.Ten;

    [Test]
    public void WithNumberCardHasNumericValueOfTheNumber()
    {
        var card = new Card(DummySuit, Rank.Seven);
        Assert.That(card.RankValue(), Is.EqualTo(7));
    }

    [Test]
    public void WithValueOfQueenHasNumericValueOf10()
    {
        var card = new Card(DummySuit, Rank.Queen);
        Assert.That(card.RankValue(), Is.EqualTo(10));
    }

    [Test]
    public void WithAceHasNumericValueOf1()
    {
        var card = new Card(DummySuit, Rank.Ace);
        Assert.That(card.RankValue(), Is.EqualTo(1));
    }

    [Test]
    public void SuitOfHeartsIsDisplayedInRed()
    {
        // given a card with Hearts or Diamonds
        var heartsCard = new Card(Suit.Hearts, DummyRank);

        // when we ask for its display representation
        var cardDisplay = heartsCard.Display();

        // then we expect a red color ansi sequence
        Assert.That(cardDisplay.Item2, Is.EqualTo(ConsoleColor.Red));
    }

    [Test]
    public void SuitOfDiamondsIsDisplayedInRed()
    {
        // given a card with Hearts or Diamonds
        var diamondsCard = new Card(Suit.Diamonds, DummyRank);

        // when we ask for its display representation
        var cardDisplay = diamondsCard.Display();

        // then we expect a red color ansi sequence
        Assert.That(cardDisplay.Item2, Is.EqualTo(ConsoleColor.Red));
    }
}