using CardGame.GameEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame.GameElements
{
    // This class inherits from the Player class,
    // and implements part of the IFishPlayer interface.
    // This is also an abstract class, meaning that
    // I cannot create an instance of this class;
    // I can only create instances of sub-classes.
    public abstract class AbstractFishPlayer : Player
    {
        public Stack<Card> PlayerPile { get; set; }

        public AbstractFishPlayer()
        {
            PlayerPile = new Stack<Card>(); // empty stack of cards
        }
    }
}