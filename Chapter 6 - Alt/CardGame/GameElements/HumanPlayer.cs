using CardGame.GameEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame.GameElements
{
    public class HumanPlayer : AbstractFishPlayer, IFishPlayer
    {
        void IFishPlayer.ShowCards()
        {
            throw new NotImplementedException();
        }

        bool IFishPlayer.Ask(IFishPlayer person)
        {
            throw new NotImplementedException();
        }

        Card IFishPlayer.Reply(Card askedFor)
        {
            throw new NotImplementedException();
        }

        bool IFishPlayer.HasPairs()
        {
            throw new NotImplementedException();
        }

        void IFishPlayer.RemovePairs()
        {
            throw new NotImplementedException();
        }

        Stack<Card> IFishPlayer.PlayerPile
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }
    }
}
