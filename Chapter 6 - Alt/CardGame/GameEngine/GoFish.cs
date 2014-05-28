using CardGame.GameElements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame.GameEngine
{
    // TODO: Push some parts to an abstract class called AbstractCardGame
    class GoFish : AbstractCardGame
    {
        public GoFish(params AbstractFishPlayer[] players)
            : base(new DeckOfCards(), players)
        {
            // TODO: Validate the list of players, that there are from 2 to 5 players
        }

        protected override bool TakeTurn(Player gamePlayer)
        {
            bool iWon = false;
            IFishPlayer person = gamePlayer as IFishPlayer;
            // Make a list of all the other players (besides the person taking their turn)
            List<IFishPlayer> otherPlayers = new List<IFishPlayer>();
            foreach (IFishPlayer player in Players)
                if (player != person)
                    otherPlayers.Add(player);
            // Pick someone
            int index = Rnd.Get.Next(otherPlayers.Count);
            bool gotCard = person.Ask(otherPlayers[index]);

            if (!gotCard)
            {
                Deck.Draw(person as Player);
            }
            person.RemovePairs();

            iWon = (person as Player).Count == 0;

            return iWon;
        }

        protected override void SetUp()
        {
            Deck.Shuffle();
            Deck.Deal(5, Players);
            // Give each player a chance to remove all their matching pairs
            foreach (IFishPlayer person in Players)
                person.RemovePairs();
        }


    }
}
