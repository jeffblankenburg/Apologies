using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apologies
{
    public class Game
    {
        public Deck Deck { get; set; }

        public Game()
        {
            Deck = new Deck();
            Player Player1 = new Player();
            Player Player2 = new Player();
            Player Player3 = new Player();
            Player Player4 = new Player();

            for (int i = 0; i < 5; i++)
            {
                //int counter = 4 * i;
                //Player1.Hand.Cards.Add(Deck.Cards[counter]);
                //Player2.Hand.Cards.Add(Deck.Cards[counter + 1]);
                //Player3.Hand.Cards.Add(Deck.Cards[counter + 2]);
                //Player4.Hand.Cards.Add(Deck.Cards[counter + 3]);
            }
        }
    }
}
