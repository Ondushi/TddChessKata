using System.Reflection;
using System;
namespace TddChessEngineLib
{
    public class Bishop
    {
        public Position Pos{get;set;}
        public Bishop(Position pos)
        {
            if (pos.Letter == 'e' && pos.Number == 9)
            {
                throw new ArgumentException();
            }
            else
            {
                Pos = pos;
            }
        }
    }
}