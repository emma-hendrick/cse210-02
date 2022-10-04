using System;


namespace Hilo.Game
{

    /// <summary>
    /// A set of 13 cards of 4 different suits.
    /// 
    /// The responsibility of Deck is to keep track of the cards in it, and their order
    /// </summary> 
    class Deck
    {

        public List<Card> cards = new List<Card>();
        public List<Card> discard = new List<Card>();

        /// <summary>
        /// Constructs a new instance of Deck.
        /// </summary>
        public Deck() 
        { 

            for (int i = 1; i < 5; i++) 
            {
                for (int j = 1; j < 14; j++) 
                {

                    Card card = new Card(j, i);
                    cards.Add(card);

                }
            }

        }
        
        /// <summary>
        /// Draws a new card from the deck
        /// </summary>
        /// <returns> Card </returns>
        public Card DrawCard() 
        {

            // If we are out of cards shuffle the deck
            if (cards.Count == 0) 
            {
                Shuffle();
            }

            Card drawnCard = cards[0];

            // Remove the item from the first index
            cards.RemoveAt(0);
            discard.Add(drawnCard);

            return drawnCard;

        }

        /// <summary>
        /// Shuffles the deck
        /// </summary>
        public void Shuffle() {
            Console.WriteLine("Shuffling Deck...");

            Random rnd = new Random();

            discard.AddRange(cards);
            cards.Clear();

            for (int i = 52; i > 0; i--) 
            {
                // Pick a random card from the discard and add it to the bottom of the deck
                int index = rnd.Next(0, i);
                cards.Add(discard[index]);
                discard.RemoveAt(index);
            }

        }

    }   
}