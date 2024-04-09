using BlackjackGame;

namespace BlackjackGameTests;

class DeckTest
{
    [Test]
    public void FullDeckHas52Cards()
    {
        Deck deck = new Deck();
        Assert.That(deck.Size(), Is.EqualTo(52));
    }

    [Test]
    public void DrawCardFromDeckReducesDeckSizeByOne()
    {
        Deck deck = new Deck();
        deck.Draw();
        Assert.That(deck.Size(), Is.EqualTo(51));
    }

    [Test]
    public void DrawCardFromDeckReturnsValidCard()
    {
        Deck deck = new Deck();
        Card card = deck.Draw();
        Assert.IsNotNull(card);
        Assert.IsTrue(card.RankValue() > 0);
    }

    [Test]
    public void DrawAllCardsResultsInSetOf52UniqueCards()
    {
        Deck deck = new Deck();
        HashSet<Card> drawnCards = new HashSet<Card>();
        for (int i = 1; i <= 52; i++)
        {
            drawnCards.Add(deck.Draw());
        }
        Assert.That(drawnCards.Count, Is.EqualTo(52));
    }
}