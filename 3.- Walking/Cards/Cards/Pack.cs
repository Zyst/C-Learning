using System;

namespace Cards
{
	class Pack
	{
        public const int NumSuits = 4;
        public const int CardsPerSuit = 13;
        private PlayingCard[,] cardPack;
        private Random randomCardSelector = new Random();

        /// <summary>
        /// Default constructor populates our card pack.
        /// </summary>
		public Pack()
		{
            this.cardPack = new PlayingCard[NumSuits, CardsPerSuit];

            for (Suit suit = Suit.Clubs; suit <= Suit.Spades; suit++)
            {
                for (Value value = Value.Two; value <= Value.Ace; value++)
                {
                    this.cardPack[(int)suit, (int)value] = new PlayingCard(suit, value);
                }
            }
		}

        /// <summary>
        /// Finds a card that hasn't been dealt before, deals it and removes it from the deck.
        /// </summary>
        /// <returns>A card that hasn't been dealt before.</returns>
        public PlayingCard DealCardFromPack()
        {
            Suit suit = (Suit)randomCardSelector.Next(NumSuits);

            while (this.IsSuitEmpty(suit))
            {
                suit = (Suit)randomCardSelector.Next(NumSuits);
            }

            Value value = (Value)randomCardSelector.Next(CardsPerSuit);

            while (this.IsCardAlreadyDealt(suit, value))
            {
                value = (Value)randomCardSelector.Next(CardsPerSuit);
            }

            PlayingCard card = this.cardPack[(int)suit, (int)value];

            this.cardPack[(int)suit, (int)value] = null;

            return card;
        }

        /// <summary>
        /// Checks if a Suit has no more cards left in the deck.
        /// </summary>
        /// <param name="suit">The suit we are checking to see if it's empty, example: 'Spades'.</param>
        /// <returns>A boolean that tells us whether the suit is empty or not.</returns>
        private bool IsSuitEmpty(Suit suit)
        {
            bool result = true;

            for (Value value = Value.Two; value <= Value.Ace; value++)
            {
                if (!IsCardAlreadyDealt(suit, value))
                {
                    result = false; // Card has already been dealt
                    break;
                }
            }

            return result;
        }

        /// <summary>
        /// Checks if a card has already been dealt.
        /// </summary>
        /// <param name="suit">The suit of the card.</param>
        /// <param name="value">The value of the card.</param>
        /// <returns>Boolean telling us whether the card has been dealt or not.</returns>
        private bool IsCardAlreadyDealt(Suit suit, Value value)
        {
            return (this.cardPack[(int)suit, (int)value] == null);
        }
	}
}