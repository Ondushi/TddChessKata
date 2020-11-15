using System;

namespace TddChessEngineLib
{
    public class Position
    {
        public int Number{get;set;}
        public char Letter{get;set;}

        public Position(string position)
        {
            char[] k = new char[2];
            int i = 0;
            foreach (char c in position)
            {
                k[i] = c;
                i++;
            }
            Letter = k[0];
            Number = Convert.ToInt32(k[1]) - 48;
        }
    }
}