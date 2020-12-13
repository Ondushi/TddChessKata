using System;
using TddChessEngineLib;
using Xunit;

namespace TddChessEngineLibTests
{
    public class BishopTests
    {
        [Fact]
        public void WhenCreatingBishopOnE2_ThenItCurrentPositionE2()
        {
            Bishop bishop = new Bishop(new Position("e2"));
            Assert.Equal((new Position("e2")).Letter + (new Position("e2")).Number, bishop.Pos.Letter + bishop.Pos.Number);
        }
        [Fact]
        public void WhenTryCreatingBishopOnE9_ThenItThrowsArgumentException()
        {
            Bishop bishop = new Bishop(new Position("e9"));
            Assert.Throws<ArgumentException>(() => new Bishop(new Position("e9")));
        }
    }
}