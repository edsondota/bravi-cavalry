using System.Collections.Generic;
using knight_moves_api.Models;

namespace knight_moves_api.Services
{
    public interface IMoveService
    {
        bool CanMove(Knight knight, Moves move);
        List<Moves> KnightPossibleMoves(Knight knight);
    }
}