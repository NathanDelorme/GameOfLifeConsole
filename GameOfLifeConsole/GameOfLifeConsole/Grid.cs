using System.Collections.Generic;

namespace GameOfLifeConsole
{
    public class Grid
    {
        private int atRowsNb;
        private int atColumnsNb;
        private Cell[][] atBoard;

        public int GetRowsNb()
        {
            return atRowsNb;
        }
        public int GetColumnsNb()
        {
            return atColumnsNb;
        }
        public Cell[][] GetBoard()
        {
            return atBoard;
        }
        
        public Grid(int parRowsNb, int parColumnsNb)
        {
            atRowsNb = parRowsNb;
            atColumnsNb = parColumnsNb;
        }
        
        public static void InitGrid(Grid parGrid, bool parDefaultValue)
        {
            parGrid.atBoard = new Cell[parGrid.atRowsNb][];
            
            for (int row = 0; row < parGrid.atRowsNb; row++)
            {
                parGrid.atBoard[row] = new Cell[parGrid.atColumnsNb];
                for (int column = 0; column < parGrid.atColumnsNb; column++)
                    parGrid.atBoard[row][column] = new Cell(parDefaultValue);
            }
        }

        public static void NextGeneration(Grid parGrid)
        {
            Grid res = new Grid(parGrid.atRowsNb, parGrid.atColumnsNb);
            InitGrid(res, false);
            
            for (int row = 0; row < parGrid.atRowsNb; row++)
            {
                for (int column = 0; column < parGrid.atColumnsNb; column++)
                {
                    int counter = 0;
                    List<Cell> neighbors = GetNeighbors(parGrid, row, column);

                    foreach (Cell c in neighbors)
                    {
                        if (c.GetIsAlive())
                            counter++;
                    }

                    if (parGrid.atBoard[row][column].GetIsAlive())
                    {
                        if(counter != 2 && counter != 3)
                            res.atBoard[row][column].SetIsAlive(false);
                        else
                            res.atBoard[row][column].SetIsAlive(true);
                            
                    }
                    else
                    {
                        if(counter == 3)
                            res.atBoard[row][column].SetIsAlive(true);
                        else
                            res.atBoard[row][column].SetIsAlive(false);
                    }
                }
            }

            for (int row = 0; row < parGrid.atRowsNb; row++)
            {
                for (int column = 0; column < parGrid.atColumnsNb; column++)
                {
                    parGrid.atBoard[row][column].SetIsAlive(res.atBoard[row][column].GetIsAlive());
                }
            }
        }

        private static List<Cell> GetNeighbors(Grid parGrid, int parRowsNb, int parColumnsNb)
        {
            List<Cell> neighbors = new List<Cell>(8);

            for (int row = parRowsNb - 1; row <= parRowsNb + 1; row++)
            {
                for (int column = parColumnsNb - 1; column <= parColumnsNb + 1; column++)
                {
                    if ((parRowsNb != row || parColumnsNb != column) && row >= 0 && column >= 0 && row < parGrid.atRowsNb && column < parGrid.atColumnsNb)
                        neighbors.Add(parGrid.atBoard[row][column]);
                }
            }
            
            return neighbors;
        }

        public static void RandomGeneration(Grid parGrid)
        {
            for (int row = 0; row < parGrid.atRowsNb; row++)
            {
                for (int column = 0; column < parGrid.atColumnsNb; column++)
                {
                    parGrid.atBoard[row][column] = new Cell(Utils.Random.Bool());
                }
            }
        }
    }
}