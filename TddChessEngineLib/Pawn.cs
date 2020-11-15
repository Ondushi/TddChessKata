using System;

namespace TddChessEngineLib
{
    public class Pawn
    {
        public Position Pos {get; set; }
        public string Color {get; set; }
        public Pawn(string position, string color)
        {
            Pos = new Position(position);
            if (color == "Black" || color == "White")
            {
                Color = color;
            }
            else
            {
                Color = "White";
            }
        }
        public void TurnTo(string finishPos)
        {
            Position finishPosition = new Position(finishPos);
            if (Pos.Letter == finishPosition.Letter)
            {
                if (Color == "White")
                {
                    if (Pos.Number < finishPosition.Number && (finishPosition.Number - Pos.Number) <= 2)
                    {
                        Pos = finishPosition;
                    }
                    else
                    {
                        Console.WriteLine("Impossible move");
                    }
                }
                else
                {
                    if (Pos.Number > finishPosition.Number && (Pos.Number - finishPosition.Number) <= 2)
                    {
                        Pos = finishPosition;
                    }
                    else
                    {
                        Console.WriteLine("Impossible move");
                    }
                }
            }
        }
    }
}
