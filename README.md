## cse210-02 Hilo Project

# Game Design:

This project will contain the classes Director, Deck, and Card.


The director class will contain the variables score, _isPlaying, current card, next card, and _deck

The director class will also contain the methods GetInputs(), DoUpdates(), and DoOutputs()


The deck class will contain the variable cards, which will be a list containing the cards. It will also contain discard, which will be a list containing discarded cards

The deck class will also contain the methods DrawCard(), and ShuffleDeck()

The card class will contain the variable value, which will be the number on the card, the variable suit, which will contain the card suit, and the variable suits, which will contain the unicode characters for each respective suit.

The card class will contain a method RenderCard(), which will draw the card,
and ReturnRenderedCard(), which will return the card as an array seperated by \n characters