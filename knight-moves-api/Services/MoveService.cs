using System.Collections.Generic;
using knight_moves_api.Models;

namespace knight_moves_api.Services
{
    public class MoveService : IMoveService
    {
        public bool CanMove(Knight knight, Moves move)
        {
            return true;
        }
        public List<Moves> KnightPossibleMoves(Knight knight)
        {
            var cx = 0;
            var moves = new List<Moves>();
            var pos = knight.ActualPos;
            if((pos.coordy + 2) <= 8)
            {
                cx = getIndexCoordX(pos.coordx);
                if ((cx + 1) <= 8)
                {
                    moves.Add(new Moves(){
                        coordy = pos.coordy + 2,
                        coordx = getCoordXIndex(cx + 1)
                    });
                }
                if ((cx -1) >= 1)
                {
                    moves.Add(new Moves(){
                        coordy = pos.coordy + 2,
                        coordx = getCoordXIndex(cx - 1)
                    });
                }
            }
            if ((pos.coordy - 2) >= 1)
            {
                cx = getIndexCoordX(pos.coordx);
                if ((cx + 1) <= 8)
                {
                    moves.Add(new Moves(){
                        coordy = pos.coordy - 2,
                        coordx = getCoordXIndex(cx + 1)
                    });
                }
                if ((cx -1) >= 1)
                {
                    moves.Add(new Moves(){
                        coordy = pos.coordy - 2,
                        coordx = getCoordXIndex(cx - 1)
                    });
                }
            }
            cx = getIndexCoordX(pos.coordx);
            if ((cx + 2) <= 8)
            {
                var cy = pos.coordy;
                if ((cy + 1) <= 8) {
                    moves.Add(new Moves(){
                        coordy = cy + 1,
                        coordx = getCoordXIndex(cx + 2)
                    });
                }
                if ((cy - 1) >= 1) {
                    moves.Add(new Moves(){
                        coordy = cy - 1,
                        coordx = getCoordXIndex(cx + 2)
                    });
                }
            }
            if ((cx - 2) <= 8)
            {
                var cy = pos.coordy;
                if ((cy + 1) <= 8) {
                    moves.Add(new Moves(){
                        coordy = cy + 1,
                        coordx = getCoordXIndex(cx - 2)
                    });
                }
                if ((cy - 1) >= 1) {
                    moves.Add(new Moves(){
                        coordy = cy - 1,
                        coordx = getCoordXIndex(cx - 2)
                    });
                }
            }
            return moves;
        }

        private int getIndexCoordX(string coordx)
        {
            switch(coordx) {
                case "a":
                    return 1;
                case "b":
                    return 2;
                case "c":
                    return 3;
                case "d":
                    return 4;
                case "e":
                    return 5;
                case "f":
                    return 6;
                case "g":
                    return 7;
                case "h":
                    return 8;
                default:
                    return 0;
            }
        }

        private string getCoordXIndex(int coordx)
        {
            switch(coordx) {
                case 1:
                    return "a";
                case 2:
                    return "b";
                case 3:
                    return "c";
                case 4:
                    return "d";
                case 5:
                    return "e";
                case 6:
                    return "f";
                case 7:
                    return "g";
                case 8:
                    return "h";
                default:
                    return "";
            }
        }
    }
}