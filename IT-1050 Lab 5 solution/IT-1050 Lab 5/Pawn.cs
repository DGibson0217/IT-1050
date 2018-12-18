using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT_1050_Lab_5
{
    class Pawn
    {

        public const char PawnSymbol = 'X';
        public const char Space = ' ';
        public static char[,] pawns;

        public Pawn()
        {
            pawns = new char[ChessBoard.Size, ChessBoard.Size];
            startPawn();
        }

        private void startPawn()
        {
            for (int r = 0; r < ChessBoard.Size; r++)
            {
                for (int c =0; c< ChessBoard.Size; c++)
                {
                    if (r == 0 || r == 1 || r == ChessBoard.Size - 2 || r == ChessBoard.Size - 1)
                        pawns[r, c] = PawnSymbol;
                    else
                   pawns[ r, c] = Space;
                }
            }
        }
    }
}
