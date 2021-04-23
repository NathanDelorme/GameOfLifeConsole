namespace GameOfLifeConsole
{
    public class Display
    {
        public static string Grid(Grid parGrid)
        {
            string board = "";

            for (int row = 0; row < parGrid.GetColumnsNb(); row++)
            {
                for (int column = 0; column < parGrid.GetColumnsNb(); column++)
                {
                    bool cellVal = parGrid.GetBoard()[row][column].GetIsAlive();
                    if (cellVal)
                        board += "■";
                    else
                        board += "-";
                }
                board += "\n";
            }
            
            return board;
        }
    }
}