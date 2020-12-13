using System.Text;
using System.Reflection;
using System;

namespace TddChessEngineLib
{

    public class Rook
    {
        public char[] letters = {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h'};
        public string Position {get;set;}
        public Rook(string position)
        {
            bool f = false;
            if (Convert.ToInt32(position[1]) - 48 > 0 && Convert.ToInt32(position[1]) - 48< 9 )
            {
                foreach (var letter in letters)
                {
                    if (letter == Convert.ToChar(position[0]))
                    {
                        Position = position;
                        f = true;
                    }
                }
            }
            if (!f)
            {
                throw new ArgumentException("Rook stand");
            }
        }
    }
}