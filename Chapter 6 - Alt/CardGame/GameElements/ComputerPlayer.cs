using CardGame.GameEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame.GameElements
{
    // This class needs to finish the rest of the implementation
    // for the IFishPlayer. (The PlayerPile property is implemented
    // in the AbstractFishPlayer already.)
    public class ComputerPlayer : AbstractFishPlayer, IFishPlayer
    {
        public void ShowCards()
        {
            Console.WriteLine("Looking at my cards....");
            foreach (var card in Hand)
                Console.WriteLine(card);
            Console.WriteLine();
        }

        public bool Ask(IFishPlayer person)
        {
            // TODO: move rnd to base class as a field....
            Random rnd = new Random();
            Card askedFor = Hand[rnd.Next(Count)]; // pick some random card
            Console.WriteLine("\tDo you have a " + askedFor + "?");
            Card result = person.Reply(askedFor);
            if (result != null)
                return true;
            else
                return false;
        }

        public Card Reply(Card askedFor)
        {
            Card myreply = null;
            foreach (var card in Hand)
                ;
            return myreply;
        }

        public bool HasPairs()
        {
            // TODO: Work out the logic to find any pairs of cards (cards with identical Faces) 
            //       and remove them from the Hand and add them to the PlayerPile. 
            throw new NotImplementedException();
        }

        public void RemovePairs()
        {
            // TODO: Work out the logic to find any pairs of cards (cards with identical Faces) 
            //       and remove them from the Hand and add them to the PlayerPile. 
            throw new NotImplementedException();
        }
    }
}
