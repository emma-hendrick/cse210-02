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
            string suitString = suitColor + suits[suit] + blackOnWhite;
            string suitAndNumber = suitString + number;
            string numberAndSuit = number + suitString;

            string[] cardString = new string[]{
                $"{blackOnWhite}╭───────────────╮{resetCol}",
                $"{blackOnWhite}|               |{resetCol}",
                $"{blackOnWhite}|               |{resetCol}",
                $"{blackOnWhite}|               |{resetCol}",
                $"{blackOnWhite}|               |{resetCol}",
                $"{blackOnWhite}|               |{resetCol}",
                $"{blackOnWhite}|               |{resetCol}",
                $"{blackOnWhite}|               |{resetCol}",
                $"{blackOnWhite}|               |{resetCol}",
                $"{blackOnWhite}|               |{resetCol}",
                $"{blackOnWhite}╰───────────────╯{resetCol}",
                ""
                };

            cardString[1] = cardString[1].Remove(10,2).Insert(10, suitAndNumber);
            cardString[9] = cardString[9].Remove(21,2).Insert(21, numberAndSuit);

            switch (value)
            {
                case 1:
                    cardString[5] = cardString[5].Remove(16,1).Insert(16, suitString);
                break;

                case 2:
                    cardString[3] = cardString[3].Remove(16,1).Insert(16, suitString);
                    cardString[7] = cardString[7].Remove(16,1).Insert(16, suitString);
                break;

                case 3:
                    cardString[3] = cardString[3].Remove(16,1).Insert(16, suitString);
                    cardString[5] = cardString[5].Remove(16,1).Insert(16, suitString);
                    cardString[7] = cardString[7].Remove(16,1).Insert(16, suitString);
                break;

                case 4:
                    cardString[3] = cardString[3].Remove(19,1).Insert(19, suitString);
                    cardString[7] = cardString[7].Remove(19,1).Insert(19, suitString);
                    cardString[3] = cardString[3].Remove(13,1).Insert(13, suitString);
                    cardString[7] = cardString[7].Remove(13,1).Insert(13, suitString);
                break;
                
                case 5:
                    cardString[5] = cardString[5].Remove(16,1).Insert(16, suitString);
                    cardString[3] = cardString[3].Remove(19,1).Insert(19, suitString);
                    cardString[7] = cardString[7].Remove(19,1).Insert(19, suitString);
                    cardString[3] = cardString[3].Remove(13,1).Insert(13, suitString);
                    cardString[7] = cardString[7].Remove(13,1).Insert(13, suitString);
                break;
                
                case 6:
                    cardString[3] = cardString[3].Remove(19,1).Insert(19, suitString);
                    cardString[5] = cardString[5].Remove(19,1).Insert(19, suitString);
                    cardString[7] = cardString[7].Remove(19,1).Insert(19, suitString);
                    cardString[3] = cardString[3].Remove(13,1).Insert(13, suitString);
                    cardString[5] = cardString[5].Remove(13,1).Insert(13, suitString);
                    cardString[7] = cardString[7].Remove(13,1).Insert(13, suitString);
                break;
                
                case 7:
                    cardString[4] = cardString[5].Remove(16,1).Insert(16, suitString);
                    cardString[3] = cardString[3].Remove(19,1).Insert(19, suitString);
                    cardString[5] = cardString[5].Remove(19,1).Insert(19, suitString);
                    cardString[7] = cardString[7].Remove(19,1).Insert(19, suitString);
                    cardString[3] = cardString[3].Remove(13,1).Insert(13, suitString);
                    cardString[5] = cardString[5].Remove(13,1).Insert(13, suitString);
                    cardString[7] = cardString[7].Remove(13,1).Insert(13, suitString);
                break;
                
                case 8:
                    cardString[4] = cardString[5].Remove(16,1).Insert(16, suitString);
                    cardString[6] = cardString[6].Remove(16,1).Insert(16, suitString);
                    cardString[3] = cardString[3].Remove(19,1).Insert(19, suitString);
                    cardString[5] = cardString[5].Remove(19,1).Insert(19, suitString);
                    cardString[7] = cardString[7].Remove(19,1).Insert(19, suitString);
                    cardString[3] = cardString[3].Remove(13,1).Insert(13, suitString);
                    cardString[5] = cardString[5].Remove(13,1).Insert(13, suitString);
                    cardString[7] = cardString[7].Remove(13,1).Insert(13, suitString);
                break;
                
                case 9:
                    cardString[5] = cardString[5].Remove(16,1).Insert(16, suitString);
                    cardString[2] = cardString[2].Remove(19,1).Insert(19, suitString);
                    cardString[4] = cardString[4].Remove(19,1).Insert(19, suitString);
                    cardString[6] = cardString[6].Remove(19,1).Insert(19, suitString);
                    cardString[8] = cardString[8].Remove(19,1).Insert(19, suitString);
                    cardString[2] = cardString[2].Remove(13,1).Insert(13, suitString);
                    cardString[4] = cardString[4].Remove(13,1).Insert(13, suitString);
                    cardString[6] = cardString[6].Remove(13,1).Insert(13, suitString);
                    cardString[8] = cardString[8].Remove(13,1).Insert(13, suitString);
                break;
                
                default:
                    // Lets also use the format for a 1 for the royalty
                    cardString[5] = cardString[5].Remove(16,1).Insert(16, suitString);
                break;
            }

            return cardString;
        }
    }   
}