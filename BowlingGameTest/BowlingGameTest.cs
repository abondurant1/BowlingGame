using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BowlingGame;

namespace BowlingGameTest
{
    [TestClass]
    public class BowlingGameTest
    {
        private Game bowlingGame;

        [TestInitialize]

        public void Setup()
        {
            bowlingGame = new Game();
        }

        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
