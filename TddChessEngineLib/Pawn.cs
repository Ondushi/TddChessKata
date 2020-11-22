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
                if (finishPosition.Number > Pos.Number)
                {
                    Pos = finishPosition;
                }
            }
            else 
            {
                if (finishPosition.Number < Pos.Number)
                {
                    Pos = finishPosition;
                }
            }
        }
    }
    public enum FigureColor
    {
        White, Black
    }
}
