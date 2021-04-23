namespace GameOfLifeConsole
{
    public class Cell
    {
        private bool atIsAlive;

        public bool GetIsAlive()
        {
            return atIsAlive;
        }
        public void SetIsAlive(bool parIsAlive)
        {
            atIsAlive = parIsAlive;
        }

        public Cell(bool parIsAlive)
        {
            this.atIsAlive = parIsAlive;
        }
    }
}