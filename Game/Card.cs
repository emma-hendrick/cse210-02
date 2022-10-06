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

            // This hurt my brain
            string number = ((value < 10) ? value.ToString(): (value == 10) ? "J": (value == 11) ? "Q": (value == 12) ? "K": "A");

            // Reset color
            string resetCol = "\u001b[0m";
            string blackOnWhite = "\u001b[30;47m";
            string redOnWhite = "\u001b[31;47m";
            string suitColor = (suit <= 1) ? blackOnWhite: redOnWhite;

            // Suit and number
            string suitAndNumber = suitColor + suits[suit] + blackOnWhite + number;

            return new string[]{
                $"{blackOnWhite}-----------{resetCol}",
                $"{blackOnWhite}| {suitAndNumber}      |{resetCol}",
                $"{blackOnWhite}|         |{resetCol}",
                $"{blackOnWhite}|         |{resetCol}",
                $"{blackOnWhite}|         |{resetCol}",
                $"{blackOnWhite}|         |{resetCol}",
                $"{blackOnWhite}|         |{resetCol}",
                $"{blackOnWhite}-----------{resetCol}"
                };
        }
    }   
}