using System.Reflection;
using System;
using TddChessEngineLib;
using Xunit;

namespace TddChessEngineLibTests
{
    public class RookTests
    {
        [Fact]
        public void WhenCreatingRookOnA1ItsPositionA1()
        {
            Rook rook = new Rook("a1");
            string positionExpected = "a1";
            string positionFact = rook.Position;

            Assert.Equal(positionExpected, positionFact);
        }
    }
}