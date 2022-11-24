using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace testapp
{
    public class Board
    {
        //Attributes
        private int boardSize;
        private Tile[,] myBoard;
        private int totalPossibleMines;
        private bool isGamePlayed;

        //Constructor
        public Board(int boardSize)
        {
            //Write method Here.
            setBoardSize(boardSize);
            myBoard = new Tile[boardSize, boardSize];
            this.totalPossibleMines = (int)(Math.Round((this.boardSize * this.boardSize) * .25));
            fillEmptyTiles();
            playGame();
        }

        //Methods
        private void setBoardSize(int bSize)
        {
            this.boardSize = bSize;
        }
        private void fillEmptyTiles()
        {
            int noOfMines = 0;
            Random rng = new Random();

            for (int i = 0; i < this.boardSize; i++)
            {
                for (int j = 0; j < this.boardSize; j++)
                {
                    myBoard[i, j] = new Tile();
                }
            }

            do
            {
                int bombCalcX = (int)(Math.Round(rng.NextDouble() * (boardSize - 1)));
                int bombCalcY = (int)(Math.Round(rng.NextDouble() * (boardSize - 1)));

                if (!this.myBoard[bombCalcX, bombCalcY].getIsMine())
                {
                    myBoard[bombCalcX, bombCalcY].setMine();
                    noOfMines++;
                }
            } while (noOfMines < this.totalPossibleMines);
        }
        private void playGame()
        {
            //add While Loop here to play game.
            //Add in a win condition
            //Add in a section for taking in user input to select and flag tiles
            for (int i = 0; i < boardSize; i++)
            {
                for (int j = 0; j < boardSize; j++)
                {
                    Console.Write(myBoard[i, j].getDisplayString());
                }
                Console.WriteLine("\n");

            }
        }

    }
}