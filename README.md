This is a C# port of this repo: https://github.com/tedyoung/mycmt2-blackjack-baseline created by @tedyoung .

## Rules of Blackjack

Players play against the Dealer, not each other. The goal of the game is to get a hand with a score as close to 21 without going over, as well as beating the score of the Dealer's hand. The score of the hand is the sum of the point values of its cards. If a Player's hand score is over 21, the Player loses ("busts").

Blackjack uses a standard deck of 52 playing cards. Each card has a rank: Ace (A), 2, 3, 4, 5, 6, 7, 8, 9, 10, Jack (J), Queen (Q), or King (K). The card's rank determines its scoring value: numbered cards 2-10 are worth their number; face cards (Jack, Queen, King) are worth 10 points; Aces are worth 1 point or 11 points, whichever would bring the hand value closer to 21 without exceeding it.

Each round proceeds as follows:

* The dealer shuffles the deck and deals two cards "face up" (with the Rank of the card showing) to each player. The dealer deals their cards with one card "face down" (with only the back showing) and one card "face up".
* The dealer asks the first player whether they want to "hit" (get another card from the deck) or "stand" (not get any more cards).
* If they choose to stand, their turn is over and the game moves on to the next player, if any.
* If the player hits, the dealer deals them a card from the deck, face up, and their hand score changes based on the additional card.
* If this causes their score to go over 21, they have "busted" and immediately lose the round and play continues with the next player.
* If they haven't busted, they continue to have the option to hit or stand again.

Once all players have either busted or stood, it's the dealer's turn to play. They turns their face-down card over. They then hit until their score is 17 or higher at which point they must stand. The dealer cannot decide to hit or stand, if their hand's score is 16 or lower, they must hit, and at 17 or higher, they must stand.

If the dealer busts, any players who did not bust earlier automatically win the round. Otherwise, each player wins if they have a strictly higher score than the dealer, or loses if they have a strictly lower score, and "pushes" (ties) if they have the same score.

