using System;
using NUnit.Framework;
using Conway.Library;

namespace Conway.Library.Tests
{
    [TestFixture]
    public class LifeRulesTests
    {
        [Test]
        public void LiveCell_FewerThan2LiveNeighbours_Dies(
            [Values(0,1)] int liveNeighbour)
        {
            var currentState = CellState.Alive;
            CellState newState = LifeRules.GetNewState(currentState, liveNeighbour);
            Assert.AreEqual(CellState.Dead, newState);
        }

        [Test]
        public void LiveCell_2Or3LiveNeighbours_Live(
            [Values(2,3)] int liveNeighbour)
        {
            var currentState = CellState.Alive;
            CellState newState = LifeRules.GetNewState(currentState, liveNeighbour);
            Assert.AreEqual(CellState.Alive, newState);
        }

        [Test]
        public void LiveCell_MoreThan3LiveNeighbours_Dies(
            [Range(4,8)] int liveNeighbour)
        {
            var currentState = CellState.Alive;
            CellState newState = LifeRules.GetNewState(currentState, liveNeighbour);
            Assert.AreEqual(CellState.Dead, newState);
        }

        [Test]
        public void DeadCell_Exactly3LiveNeighbour_Lives()
        {
            int liveNeighbour = 3;
            var currentState = CellState.Dead;
            CellState newState = LifeRules.GetNewState(currentState, liveNeighbour);
            Assert.AreEqual(CellState.Alive, newState);
        }

        [Test]
        public void DeadCell_FewerThan3LiveNeighbours_StayDead(
            [Range(0,2)] int liveNeighbour)
        {
            var currentState = CellState.Dead;
            CellState newState = LifeRules.GetNewState(currentState, liveNeighbour);
            Assert.AreEqual(CellState.Dead, newState);
        }

        [Test]
        public void DeadCell_MoreThan3LiveNeighbours_StayDead(
            [Range(4, 8)] int liveNeighbour)
        {
            var currentState = CellState.Dead;
            CellState newState = LifeRules.GetNewState(currentState, liveNeighbour);
            Assert.AreEqual(CellState.Dead, newState);
        }
    }
}