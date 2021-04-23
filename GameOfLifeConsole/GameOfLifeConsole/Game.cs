using System;

namespace GameOfLifeConsole
{
    public class Game
    {
        private Grid atGrid;
        public Grid GetGrid()
        {
            return atGrid;
        }
        
        public Game(int parRowsNb, int parColumnsNb)
        {
            ValidGameSettings(parRowsNb, parColumnsNb);
            atGrid = new Grid(parRowsNb, parColumnsNb);
        }

        private void ValidGameSettings(int parRowsNb, int parColumnsNb)
        {
            if (parRowsNb <= 0 || parColumnsNb <= 0)
                throw new ArgumentException("Game - isValidGameSettings : rowsNb or columnsNb are not strictly positive.");
        }
    }
}