using System;
using System.Collections.Generic;


namespace Hilo.Game
{
    /// <summary>
    /// A person who directs the game. 
    ///
    /// The responsibility of a Director is to control the sequence of play.
    /// </summary>
    public class Director
    {
        Deck _deck = new Deck();
        Card _currentCard;
        Card _nextCard;
        bool _isPlaying = true;
        int _score = 300;
        string _guess;

        /// <summary>
        /// Constructs a new instance of Director.
        /// </summary>
        public Director()
        {
            _deck.Shuffle();
            _currentCard = _deck.DrawCard();
            _nextCard = _deck.DrawCard();
            _guess = "h";
        }

        /// <summary>
        /// Starts the game by running the main game loop.
        /// </summary>
        public void StartGame()
        {
            while (_isPlaying)
            {
                GetInputs();
                DoUpdates();
                DoOutputs();
            }
        }

        /// <summary>
        /// Asks the user if they want to draw.
        /// </summary>
        public void GetInputs()
        {

            Console.Write("Play Again? [y/n] ");
            string rollDice = Console.ReadLine() ?? "y";
            _isPlaying = (rollDice == "y");

            if (!_isPlaying)
            {
                return;
            }

            Console.WriteLine();
            _currentCard.RenderCard();

            Console.Write("Higher or lower? [h/l] ");
            _guess = Console.ReadLine() ?? "h";

        }

        /// <summary>
        /// Updates the player's score.
        /// </summary>
        public void DoUpdates()
        {
            if (!_isPlaying)
            {
                return;
            }

            _nextCard.RenderCard();

            _score += (_guess == "h") != ((_currentCard.value * 4 + _currentCard.suit) > (_nextCard.value * 4 + _nextCard.suit)) ? 100: -75;

            _currentCard = _nextCard;
            _nextCard = _deck.DrawCard();

        }

        /// <summary>
        /// Displays the new card and the score.
        /// </summary>
        public void DoOutputs()
        {
            if (!_isPlaying)
            {
                return;
            }
            
            Console.WriteLine($"Your score is: {_score}\n");
            _isPlaying = (_score > 0);

        }
    }
}


