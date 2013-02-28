using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apologies
{
    public enum GameColor { Red, Yellow, Green, Blue };
    
    public class Player
    {
        public string Name { get; set; }
        public List<GamePiece> GamePieces { get; set; }
        public GameColor Color { get; set; }
    }
}
