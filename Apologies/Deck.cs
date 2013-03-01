using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apologies
{
    public class Deck
    {
        public List<Card> Cards { get; set; }

        public Deck()
        {
            Cards = new List<Card>();
            Cards.Add(new Card { Name = "One", Value = "1", Text = "Move a pawn from Start or move a pawn 1 space forward." });
            Cards.Add(new Card { Name = "One", Value = "1", Text = "Move a pawn from Start or move a pawn 1 space forward." });
            Cards.Add(new Card { Name = "One", Value = "1", Text = "Move a pawn from Start or move a pawn 1 space forward." });
            Cards.Add(new Card { Name = "One", Value = "1", Text = "Move a pawn from Start or move a pawn 1 space forward." });
            Cards.Add(new Card { Name = "One", Value = "1", Text = "Move a pawn from Start or move a pawn 1 space forward." });
            Cards.Add(new Card { Name = "Two", Value = "2", Text = "Move a pawn from Start or move a pawn 2 spaces forward.  Also, play again." });
            Cards.Add(new Card { Name = "Two", Value = "2", Text = "Move a pawn from Start or move a pawn 2 spaces forward.  Also, play again." });
            Cards.Add(new Card { Name = "Two", Value = "2", Text = "Move a pawn from Start or move a pawn 2 spaces forward.  Also, play again." });
            Cards.Add(new Card { Name = "Two", Value = "2", Text = "Move a pawn from Start or move a pawn 2 spaces forward.  Also, play again." });
            Cards.Add(new Card { Name = "Two", Value = "2", Text = "Move a pawn from Start or move a pawn 2 spaces forward.  Also, play again." });
            Cards.Add(new Card { Name = "Three", Value = "3", Text = "Move a pawn 3 spaces forward." });
            Cards.Add(new Card { Name = "Three", Value = "3", Text = "Move a pawn 3 spaces forward." });
            Cards.Add(new Card { Name = "Three", Value = "3", Text = "Move a pawn 3 spaces forward." });
            Cards.Add(new Card { Name = "Three", Value = "3", Text = "Move a pawn 3 spaces forward." });
            Cards.Add(new Card { Name = "Three", Value = "3", Text = "Move a pawn 3 spaces forward." });
            Cards.Add(new Card { Name = "Four", Value = "4", Text = "Move a pawn 4 spaces BACKWARDS." });
            Cards.Add(new Card { Name = "Four", Value = "4", Text = "Move a pawn 4 spaces BACKWARDS." });
            Cards.Add(new Card { Name = "Four", Value = "4", Text = "Move a pawn 4 spaces BACKWARDS." });
            Cards.Add(new Card { Name = "Four", Value = "4", Text = "Move a pawn 4 spaces BACKWARDS." });
            Cards.Add(new Card { Name = "Four", Value = "4", Text = "Move a pawn 4 spaces BACKWARDS." });
            Cards.Add(new Card { Name = "Five", Value = "5", Text = "Move a pawn 5 spaces forward." });
            Cards.Add(new Card { Name = "Five", Value = "5", Text = "Move a pawn 5 spaces forward." });
            Cards.Add(new Card { Name = "Five", Value = "5", Text = "Move a pawn 5 spaces forward." });
            Cards.Add(new Card { Name = "Five", Value = "5", Text = "Move a pawn 5 spaces forward." });
            Cards.Add(new Card { Name = "Five", Value = "5", Text = "Move a pawn 5 spaces forward." });
            Cards.Add(new Card { Name = "Seven", Value = "7", Text = "Move one pawn 7 spaces forward or split the 7 spaces between two pawns (such as four spaces for one pawn and three for another). This makes it possible for two pawns to enter Home on the same turn, for example. The 7 cannot be split into a 6 and 1 or a 5 and 2 for the purposes of moving out of Start. The entire seven spaces must be used one way or the other or the turn is lost." });
            Cards.Add(new Card { Name = "Seven", Value = "7", Text = "Move one pawn 7 spaces forward or split the 7 spaces between two pawns (such as four spaces for one pawn and three for another). This makes it possible for two pawns to enter Home on the same turn, for example. The 7 cannot be split into a 6 and 1 or a 5 and 2 for the purposes of moving out of Start. The entire seven spaces must be used one way or the other or the turn is lost." });
            Cards.Add(new Card { Name = "Seven", Value = "7", Text = "Move one pawn 7 spaces forward or split the 7 spaces between two pawns (such as four spaces for one pawn and three for another). This makes it possible for two pawns to enter Home on the same turn, for example. The 7 cannot be split into a 6 and 1 or a 5 and 2 for the purposes of moving out of Start. The entire seven spaces must be used one way or the other or the turn is lost." });
            Cards.Add(new Card { Name = "Seven", Value = "7", Text = "Move one pawn 7 spaces forward or split the 7 spaces between two pawns (such as four spaces for one pawn and three for another). This makes it possible for two pawns to enter Home on the same turn, for example. The 7 cannot be split into a 6 and 1 or a 5 and 2 for the purposes of moving out of Start. The entire seven spaces must be used one way or the other or the turn is lost." });
            Cards.Add(new Card { Name = "Seven", Value = "7", Text = "Move one pawn 7 spaces forward or split the 7 spaces between two pawns (such as four spaces for one pawn and three for another). This makes it possible for two pawns to enter Home on the same turn, for example. The 7 cannot be split into a 6 and 1 or a 5 and 2 for the purposes of moving out of Start. The entire seven spaces must be used one way or the other or the turn is lost." });
            Cards.Add(new Card { Name = "Eight", Value = "8", Text = "Move a pawn 8 spaces forward." });
            Cards.Add(new Card { Name = "Eight", Value = "8", Text = "Move a pawn 8 spaces forward." });
            Cards.Add(new Card { Name = "Eight", Value = "8", Text = "Move a pawn 8 spaces forward." });
            Cards.Add(new Card { Name = "Eight", Value = "8", Text = "Move a pawn 8 spaces forward." });
            Cards.Add(new Card { Name = "Eight", Value = "8", Text = "Move a pawn 8 spaces forward." });
            Cards.Add(new Card { Name = "Ten", Value = "10", Text = "Move a pawn 10 spaces forward or 1 space backward. If a player cannot go forward ten spaces, then one pawn must go back one space." });
            Cards.Add(new Card { Name = "Ten", Value = "10", Text = "Move a pawn 10 spaces forward or 1 space backward. If a player cannot go forward ten spaces, then one pawn must go back one space." });
            Cards.Add(new Card { Name = "Ten", Value = "10", Text = "Move a pawn 10 spaces forward or 1 space backward. If a player cannot go forward ten spaces, then one pawn must go back one space." });
            Cards.Add(new Card { Name = "Ten", Value = "10", Text = "Move a pawn 10 spaces forward or 1 space backward. If a player cannot go forward ten spaces, then one pawn must go back one space." });
            Cards.Add(new Card { Name = "Ten", Value = "10", Text = "Move a pawn 10 spaces forward or 1 space backward. If a player cannot go forward ten spaces, then one pawn must go back one space." });
            Cards.Add(new Card { Name = "Eleven", Value = "11", Text = "Move 11 spaces forward or switch places with one opposing pawn. A player that cannot move 11 spaces is not forced to switch and instead can forfeit the turn." });
            Cards.Add(new Card { Name = "Eleven", Value = "11", Text = "Move 11 spaces forward or switch places with one opposing pawn. A player that cannot move 11 spaces is not forced to switch and instead can forfeit the turn." });
            Cards.Add(new Card { Name = "Eleven", Value = "11", Text = "Move 11 spaces forward or switch places with one opposing pawn. A player that cannot move 11 spaces is not forced to switch and instead can forfeit the turn." });
            Cards.Add(new Card { Name = "Eleven", Value = "11", Text = "Move 11 spaces forward or switch places with one opposing pawn. A player that cannot move 11 spaces is not forced to switch and instead can forfeit the turn." });
            Cards.Add(new Card { Name = "Eleven", Value = "11", Text = "Move 11 spaces forward or switch places with one opposing pawn. A player that cannot move 11 spaces is not forced to switch and instead can forfeit the turn." });
            Cards.Add(new Card { Name = "Twelve", Value = "12", Text = "Move a pawn 12 spaces forward." });
            Cards.Add(new Card { Name = "Twelve", Value = "12", Text = "Move a pawn 12 spaces forward." });
            Cards.Add(new Card { Name = "Twelve", Value = "12", Text = "Move a pawn 12 spaces forward." });
            Cards.Add(new Card { Name = "Twelve", Value = "12", Text = "Move a pawn 12 spaces forward." });
            Cards.Add(new Card { Name = "Twelve", Value = "12", Text = "Move a pawn 12 spaces forward." });
            Cards.Add(new Card { Name = "Sorry", Value = "SORRY", Text = "Move any one pawn from Start to a square occupied by any opponent, sending that pawn back to its own Start. If there are no pawns on the player's Start, or no opponent's pawns on any squares, the turn is lost." });
            Cards.Add(new Card { Name = "Sorry", Value = "SORRY", Text = "Move any one pawn from Start to a square occupied by any opponent, sending that pawn back to its own Start. If there are no pawns on the player's Start, or no opponent's pawns on any squares, the turn is lost." });
            Cards.Add(new Card { Name = "Sorry", Value = "SORRY", Text = "Move any one pawn from Start to a square occupied by any opponent, sending that pawn back to its own Start. If there are no pawns on the player's Start, or no opponent's pawns on any squares, the turn is lost." });
            Cards.Add(new Card { Name = "Sorry", Value = "SORRY", Text = "Move any one pawn from Start to a square occupied by any opponent, sending that pawn back to its own Start. If there are no pawns on the player's Start, or no opponent's pawns on any squares, the turn is lost." });
            Cards.Add(new Card { Name = "Sorry", Value = "SORRY", Text = "Move any one pawn from Start to a square occupied by any opponent, sending that pawn back to its own Start. If there are no pawns on the player's Start, or no opponent's pawns on any squares, the turn is lost." });
            Shuffle();
        }

        public void Shuffle()
        {
            Random r = new Random();
            for (int i = 0; i < Cards.Count; i++)
            {
                int index1 = i;
                int index2 = r.Next(Cards.Count);
                SwapCard(index1, index2);
            }
        }

        private void SwapCard(int index1, int index2)
        {
            Card card = Cards[index1];
            Cards[index1] = Cards[index2];
            Cards[index2] = card;
        }
    }
}
