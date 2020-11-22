using System;
using TddChessEngineLib;
using Xunit;

namespace TddChessEngineLibTests
{
    public class PawnTests
    {
        [Fact]
        public void WhenWhitePawnTurnsFromE2ToE4_ThenItsPositionsChanges()
        {
            Pawn pawn = new Pawn("e2", FigureColor.White);
            pawn.TurnTo("e4");
            Position posTrue = new Position("e4");
            Position posFact = pawn.Pos;

            Assert.Equal(posTrue.Letter + posTrue.Number, posFact.Letter + posFact.Number);
        }
        [Fact]
        public void WhenBlackPawnTriesToGoBack_ThenItsCantGoBack()
        {
            Pawn pawn = new Pawn("e6", FigureColor.Black);
            pawn.TurnTo("e7");
            Position posTrue = new Position("e6");
            Position posFact = pawn.Pos;

            Assert.Equal(posTrue.Letter + posTrue.Number, posFact.Letter + posFact.Number);
        }
    }
}
