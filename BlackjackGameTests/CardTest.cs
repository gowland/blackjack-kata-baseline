using System.Drawing;
using BlackjackGame;

namespace BlackjackGameTests;

class CardTest
{
    private static readonly Suit DummySuit = Suit.Hearts;
    private static readonly Rank DummyRank = Rank.Ten;

    [Test]
    public void WithNumberCardHasNumericValueOfTheNumber()
    {
        Card card = new Card(DummySuit, Rank.Seven);
        Assert.That(card.RankValue(), Is.EqualTo(7));
    }

    [Test]
    public void WithValueOfQueenHasNumericValueOf10()
    {
        Card card = new Card(DummySuit, Rank.Queen);
        Assert.That(card.RankValue(), Is.EqualTo(10));
    }

    [Test]
    public void WithAceHasNumericValueOf1()
    {
        Card card = new Card(DummySuit, Rank.Ace);
        Assert.That(card.RankValue(), Is.EqualTo(1));
    }

    [Test]
    public void SuitOfHeartsIsDisplayedInRed()
    {
        // given a card with Hearts or Diamonds
        Card heartsCard = new Card(Suit.Hearts, DummyRank);

        // when we ask for its display representation
        var cardDisplay = heartsCard.Display();

        // then we expect a red color ansi sequence
        Assert.That(cardDisplay.Item2, Is.EqualTo(ConsoleColor.Red));
    }

    [Test]
    public void SuitOfDiamondsIsDisplayedInRed()
    {
        // given a card with Hearts or Diamonds
        Card diamondsCard = new Card(Suit.Diamonds, DummyRank);

        // when we ask for its display representation
        var cardDisplay = diamondsCard.Display();

        // then we expect a red color ansi sequence
        Assert.That(cardDisplay.Item2, Is.EqualTo(ConsoleColor.Red));
    }
}