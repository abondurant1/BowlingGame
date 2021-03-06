﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BowlingGame;

namespace BowlingGameTest
{
    [TestClass]
    public class BowlingGameTest
    {
        private Game g;

        [TestInitialize]
        public void Setup()
        {
            g = new Game();
        }

        private void RollMany(int n, int pins)
        {
            for (int i = 0; i < n; i++)
                g.roll(pins);
        }

        [TestMethod]
        public void TestGutterGame()
        {
            RollMany(20, 0);
            Assert.AreEqual(0, g.Score());
        }

        [TestMethod]
        public void TestAllOnes()
        {
            RollMany(20, 1);
            Assert.AreEqual(20, g.Score());
        }

        [TestMethod]
        public void TestOneSpare()
        {
            RollSpare();
            g.roll(3);
            RollMany(17, 0);
            Assert.AreEqual(16, g.Score());
        }

        [TestMethod]
        public void TestOneStrike()
        {
            RollStrike();
            g.roll(3);
            g.roll(4);
            RollMany(16, 0);
            Assert.AreEqual(24, g.Score());
        }

        [TestMethod]
        public void TestPerfectGame()
        {
            RollMany(12, 10);
            Assert.AreEqual(300, g.Score());
        }

        private void RollStrike()
        {
            g.roll(10);
        }

        private void RollSpare()
        {
            g.roll(5);
            g.roll(5);
        }
    }
}
