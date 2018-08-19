using System.Collections.Generic;

namespace knight_moves_api.Models
{
    public class Knight
    {
        public Moves ActualPos { get; set; }

        public List<Moves> PossibleMoves { get; set; }
    }
}