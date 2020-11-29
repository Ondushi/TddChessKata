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
            string newPosition = "e7";


            Assert.Throws<ArgumentException>(() => pawn.TurnTo(newPosition));
        }
        [Fact]
        public void WhenWhitePawnTriesGoBack_ThenItsCantGoBack()
        {
            Pawn pawn = new Pawn("e2", FigureColor.White);
            string newPosition = "e1";

            Assert.Throws<ArgumentException>(() => pawn.TurnTo(newPosition));
        }

        [Fact]
        public void WhenWhitePawnTurnsFromE3ToE5_ThenItsCantJump()
        {
            Pawn pawn = new Pawn("e3", FigureColor.White);
            string newPosition = "e5";

            Assert.Throws<ArgumentException>(() => pawn.TurnTo(newPosition));

        }
    }
}
