using System;
using TddChessEngineLib;
using Xunit;

namespace TddChessEngineLibTests
{
    public class PawnTests
    {
        [Fact]
        public void WhenPawnTurnsFromE2ToE4_ThenItsPositionsChanges()
        {
            Pawn pawn = new Pawn("e2", FigureColor.White);
            pawn.TurnTo("e4");
            Position posTrue = new Position("e4");
            Position posFact = pawn.Pos;

            Assert.Equal(posTrue.Letter + posTrue.Number, posFact.Letter + posFact.Number);
        }
    }
}
