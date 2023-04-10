using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeGames
{
    internal class Game
    {
        Board board = new Board();
        //стартовый метод
        public void StartGame()
        {
            PrintStates();

            while (Board.isWinner() == -1)
            {
                if (Board.count % 2 == 0)
                    board.HumanPlayer(Piece.Crosse);
                else
                {
                    board.ComputerPlayer(Piece.Zerro);
                    PrintStates();
                }



            }
            PrintStates();
            Console.WriteLine();
            Console.WriteLine($"Result : {GetWinners().ToString()}");
            
            Console.ReadLine();

        }
        // вставляем в индексы X либо О
        public string ShowPiece(int index)
        {
            Piece piece = board.GetPiece(index);

            if (piece == Piece.Empty)
                return index.ToString();

            return piece == Piece.Crosse ? "X" : "O";

        }
        //выявляем победителя
        public static string GetWinners()
        {

            if (Board.isWinner() == 1)

                return "Winner Crosses";

            else if (Board.isWinner() == 2)
                return "Winner Zeros";

            if (Board.count < 9)
                return "Game is not finished!";
            return "Draw";
        }

        //печатаем поле
        public void PrintStates()
        {

            Console.WriteLine($"     |     |     |");
            Console.WriteLine($"  {ShowPiece(1)}  |  {ShowPiece(2)}  |  {ShowPiece(3)}  |");
            Console.WriteLine($"_____|_____|_____|");
            Console.WriteLine($"     |     |     |");
            Console.WriteLine($"  {ShowPiece(4)}  |  {ShowPiece(5)}  |  {ShowPiece(6)}  |");
            Console.WriteLine($"_____|_____|_____| ");
            Console.WriteLine($"     |     |     |");
            Console.WriteLine($"  {ShowPiece(7)}  |  {ShowPiece(8)}  |  {ShowPiece(9)}  |");
            Console.WriteLine($"_____|_____|_____|");
        }



    }
}
