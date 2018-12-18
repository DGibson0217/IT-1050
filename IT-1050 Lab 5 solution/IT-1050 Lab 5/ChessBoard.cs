using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT_1050_Lab_5
{
    class ChessBoard
    {
        private string[,] chessBoard;
        public const int Size = 8;
        private Move move;

        public ChessBoard()
        {
            move = new Move();
            chessBoard = new string[Size, Size];
            ChessBoardHorizontal = "+---";
            ChessBoardVertical = "| ";
 
        }
        public string ChessBoardVertical { get; set; }
        public string ChessBoardHorizontal { get; set; }

        public void displayChessBoard()
        {
            while (!move.Exit)
            {
                Console.Clear();
                Console.WriteLine("    0   1   2   3   4   5   6   7");

                for(int r = 0; r < Size; r++)
                {
                    Console.Write("  ");
                    for(int c =0; c < Size; c++)
                    {
                        Console.Write(ChessBoardHorizontal);
                    }

                    Console.Write("+\n");

                    for (int c=0; c < Size; c++)
                    {
                        if (c == 0)
                        Console.Write(r + " ");

                        Console.Write(ChessBoardVertical + Pawn.pawns[r, c] + " ");
                    }
                    Console.Write("|\n");

                }

                Console.Write("  ");
                for (int c = 0; c < Size; c++)
                {
                    Console.Write(ChessBoardHorizontal);
                }

                Console.Write("+\n\n");
                move.MakeMove();
            }
        }
    }
}
