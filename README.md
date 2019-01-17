
# Lab 07: Word Guess Game
 
## Specs
- Create a custom generic collection named Deck< T >.
- As we learned, under the hood, generic collections are arrays. Utilizing this concept, create a new generic collection (Deck< T >) that dynamically resizes an array for all the specified methods described below. (*Do not use a collection within your Deck class).
- Your Generic collection should hold Cards. (You will need to create a custom Card class)
- Create an Enum to hold the different card suits (Hearts, Diamonds, Spades, Clubs)
- The methods within your Deck class should contain at minimum:
  - Add
  - Remove
  - Count (the total number of cards in the deck)
- In your Program.cs have a method named Deal that gets called from Main that evenly distributes the deck of cards amongst 2 players. the Deck should keeps any remaining cards (if any). Output to the console the cards each player has and what the initial Deck has kept.
- When running your application, it should activate a console that outputs an example for each of the custom methods within your deck. It should show what cards were added to the deck, information about what card was removed, and then proof it is gone, as well as a final count of the number of cards without any direct code manipulation from the grader.

- Your Program.cs Main method should demonstrate:
  - The instantiation of the generic collection.
  - The instantiation of at least 10 cards with values.
  - Adding and removing cards from the Deck.
  - Use a foreach loop on your created Deck, and output each of the cards to the console.
  - Call to the Deal() method following the directions from above.

## Unit Tests
- Test that your app has the following functionality:
    - Add a card to your deck
    - Getter/Setters of your properties from your Card class
    - Remove a card from your deck that exists
    - Remove a card from your deck that does not exist
## Example Usage
### PrintCards Method using a deck made with Deck.FullDeck() method.


    Deck<Card> fullDeck = new Deck<Card>("Full Deck");
    fullDeck = fullDeck.FullDeck();
    PrintCards(fullDeck);
![solution image](assets/PrintMethod.PNG)    

### Deal Method using a deck made with Deck.FullDeck() method.
    Deck<Card> fullDeck = new Deck<Card>("Full Deck");
    fullDeck = fullDeck.FullDeck();
    Deal(fullDeck);
![solution image](assets/DealMethod.PNG)    

### Add Method and Remove Method using a deck that is initally empty
    Deck<Card> testDeck = new Deck<Card>("Test Deck");
    Card test = new Card(Card.SuitType.Clubs, Card.DenominationType.Two);
    Card test2 = new Card(Card.SuitType.Clubs, Card.DenominationType.Ace);
    PrintCards(testDeck);
    UIAddCard(test, testDeck);
    UIAddCard(test, testDeck);
    PrintCards(testDeck);
    UIRemoveCard(test, testDeck);
    UIRemoveCard(test2, testDeck);
    UIRemoveCard(test, testDeck);
    UIRemoveCard(test, testDeck);
    
![solution image](assets/AddRemoveMethods.PNG)

 