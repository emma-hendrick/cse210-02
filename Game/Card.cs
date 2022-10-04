using System;


namespace Hilo.Game
{

    /// <summary>
    /// A card, with a value and a suit.
    /// 
    /// The responsibility of Card is to keep track of its value and suit,
    /// and to render itself
    /// </summary> 
    class Card
    {
        public int value;
        public int suit;
        private char[] suits = new char[]{'♣', '♠', '♦', '♥'};

        /// <summary>
        /// Constructs a new instance of Card.
        /// </summary>
        public Card(int value, int suit) 
        {
            this.value = value;
            this.suit = suit - 1;
        }

        public void RenderCard()
        {
            foreach (string line in ReturnRenderedCard())
            {
                Console.WriteLine(line);
            }
        }

        public string[] ReturnRenderedCard()
        {
            Console.WriteLine(suit);
            Console.WriteLine(value);

            // This hurt my brain
            string number = ((value < 10) ? value.ToString(): (value == 10) ? "J": (value == 11) ? "Q": (value == 12) ? "K": "A");

            return new string[]{
                $"---------",
                $"|{suits[suit]}{number}     |",
                $"|       |",
                $"|       |",
                $"|       |",
                $"|       |",
                $"---------"
                };
        }
    }   
}