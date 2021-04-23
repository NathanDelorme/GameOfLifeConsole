using System;
using System.Threading;

namespace GameOfLifeConsole
{
    static class Program
    {
        static void Main()
        {
            int delayBetweenGen = 100;
            int maxGen = 100;
            int rowsNb = 20;
            int columnsNb = 20;
            Game game = new Game(rowsNb, columnsNb);
            
            Grid.InitGrid(game.GetGrid(), false);
            Grid.RandomGeneration(game.GetGrid());
            
            Console.WriteLine("Generation 0 ========");
            Console.WriteLine(Display.Grid(game.GetGrid()));

            int i = 1;
            while (i <= maxGen)
            {
                Grid.NextGeneration(game.GetGrid());
                Thread.Sleep(delayBetweenGen);
                Console.WriteLine("Generation " + i + " ========");
                Console.WriteLine(Display.Grid(game.GetGrid()));
                i++;
            }
        }
    }
}