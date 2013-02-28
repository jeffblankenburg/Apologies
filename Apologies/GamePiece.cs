using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apologies
{
    public enum State { Start, Play, Safe, Home};
    
    public class GamePiece
    {
        public int XPosition { get; set; }
        public int YPosition { get; set; }
        public State State { get; set; }
    }
}
