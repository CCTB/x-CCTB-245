using CardGame.GameElements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CardGame.GameEngine
{
    /* An Abstract class is a class that cannot be instantiated.
     * Abstract classes are useful for inheritance whenever you
     * need a common set of behaviours or properties and you do
     * not have an implementation for one or more of the behaviours.
     */
    internal abstract class AbstractCardGame
    {
        protected DeckOfCards Deck { get; set; }
        protected Player[] Players { get; set; }

        public AbstractCardGame(DeckOfCards deckOfCards, params Player[] players)
        {
            // TODO: Simple validation - All games must have a DeckOfCards and at least one player
            this.Players = players;
            Deck = deckOfCards;
        }
        
        public void Play()
        {
            // Run the game - this is like the Main() method of your game
            SetUp();
            bool gameOver = false;
            Player winner = null;
            do
            {
                foreach (var person in Players)
                {
                    gameOver = TakeTurn(person);
                    if (gameOver)
                    {
                        winner = person;
                        break; // jump out of this foreach loop
                    }
                }
            } while (!gameOver);

            // TODO: Find some way to say who won.....
            //       This will necessitate "identifying" the Players (e.g.: give each one a Name)
        }

        protected abstract void SetUp();
        protected abstract bool TakeTurn(Player gamePlayer);
    }
}
