using System;

namespace TddChessEngineLib
{
    public class Pawn
    {
        public Position Pos {get; private set; }
        public FigureColor FigureColor {get;}
        public Pawn(string position, FigureColor figureColor)
        {
            Pos = new Position(position);
            FigureColor = figureColor;
        }
        public void TurnTo(string finishPos)
        {
            Position finishPosition = new Position(finishPos);
            if (FigureColor == FigureColor.White)
            {
                if (finishPosition.Number > Pos.Number && (finishPosition.Number - Pos.Number == 1 || finishPosition.Number - Pos.Number == 2 && Pos.Number == 2))
                {
                    Pos = finishPosition;
                }
                else
                {
                    throw new ArgumentException("Pawn can't go");
                }
            }
            else 
            {
                if (finishPosition.Number < Pos.Number && (Pos.Number - finishPosition.Number == 1 || Pos.Number - finishPosition.Number == 2 && Pos.Number == 7))
                {
                    Pos = finishPosition;
                }
                else
                {
                    throw new ArgumentException("Pawn can't go");
                }
            }
        }
    }
    public enum FigureColor
    {
        White, Black
    }
}
