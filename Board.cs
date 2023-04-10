using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeGames
{

    internal class Board
    {
        private static Piece[] piece = new Piece[9];
       
       

        public static int count { get; private set; }

        //метод для очистки поля
        public Board()
        {
            for(int i = 0; i < piece.Length; i++)
            {
                piece[i] = Piece.Empty;
            }
            
        }
        //первый ходит всегда крестик
        public void MakeMove(int index)
        {
            piece[index - 1] = count % 2 == 0 ? Piece.Crosse : Piece.Zerro;
            count++;
        }

        //получаем индексы поля
        public Piece GetPiece(int index)
        {
            return piece[index - 1];
        }
        //пользователь ходит если клетка только клетка пустая
        public void HumanPlayer(Piece piece)
        {
            Console.WriteLine("Enter number index: ");

            int indexes = int.Parse(Console.ReadLine());

            if (piece != Piece.Crosse || piece != Piece.Zerro)
            {
                MakeMove(indexes);
            }


        }
        //ходит компьютер
        public void ComputerPlayer(Piece piece)
        {
            Random random = new Random();
            int rand = random.Next(1, 9);

            if (piece != Piece.Crosse || piece != Piece.Zerro)
            {
                MakeMove(rand);
            }





        }





        public static int isWinner()
        {
            if (piece[0] == Piece.Crosse && piece[1] == Piece.Crosse && piece[2] == Piece.Crosse)
            {
                return 1;
            }
            else if (piece[3] == Piece.Crosse && piece[4] == Piece.Crosse && piece[5] == Piece.Crosse)
            {
                return 1;
            }
            else if (piece[6] == Piece.Crosse && piece[7] == Piece.Crosse && piece[8] == Piece.Crosse)
            {
                return 1;
            }
            else if (piece[0] == Piece.Crosse && piece[4] == Piece.Crosse && piece[8] == Piece.Crosse)
            {
                return 1;
            }
            else if (piece[6] == Piece.Crosse && piece[4] == Piece.Crosse && piece[2] == Piece.Crosse)
            {
                return 1;
            }
            else if (piece[0] == Piece.Crosse && piece[3] == Piece.Crosse && piece[6] == Piece.Crosse)
            {
                return 1;
            }
            else if (piece[1] == Piece.Crosse && piece[4] == Piece.Crosse && piece[7] == Piece.Crosse)
            {
                return 1;
            }
            else if (piece[3] == Piece.Crosse && piece[4] == Piece.Crosse && piece[5] == Piece.Crosse)
            {
                return 1;
            }



            if (piece[0] == Piece.Zerro && piece[1] == Piece.Zerro && piece[2] == Piece.Zerro)
            {
                return 2;
            }
            else if (piece[3] == Piece.Zerro && piece[4] == Piece.Zerro && piece[5] == Piece.Zerro)
            {
                return 2;
            }
            else if (piece[6] == Piece.Zerro && piece[7] == Piece.Zerro && piece[8] == Piece.Zerro)
            {
                return 2;
            }
            else if (piece[0] == Piece.Zerro && piece[4] == Piece.Zerro && piece[8] == Piece.Zerro)
            {
                return 2;
            }
            else if (piece[6] == Piece.Zerro && piece[4] == Piece.Zerro && piece[2] == Piece.Zerro)
            {
                return 2;
            }
            else if (piece[0] == Piece.Zerro && piece[3] == Piece.Zerro && piece[6] == Piece.Zerro)
            {
                return 2;
            }
            else if (piece[1] == Piece.Zerro && piece[4] == Piece.Zerro && piece[7] == Piece.Zerro)
            {
                return 2;
            }
            else if (piece[3] == Piece.Zerro && piece[4] == Piece.Zerro && piece[5] == Piece.Zerro)
            {
                return 2;
            }
            else
            {
                return -1;
            }

        }
    }





    }

        

    
