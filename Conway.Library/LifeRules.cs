using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conway.Library
{
    public enum CellState
    {
        Alive,
        Dead
    }

    public class LifeRules
    {
        public static CellState GetNewState(CellState currentState, int liveNeighbour)
        {
            switch (currentState)
            {
                case CellState.Alive:
                    if (liveNeighbour < 2 || liveNeighbour > 3)
                        return CellState.Dead;
                    break;
                case CellState.Dead:
                    if (liveNeighbour == 3)
                        return CellState.Alive;
                    break;
            }
            return currentState;
        }
    }
}
