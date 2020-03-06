using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicTacToeGame.Models
{
    public class TicTacToeBoard
    {
        /*we're trying to follow the KISS principle*/
        //0 is top left, 1 is top mid, 2 is top right
        //3 is mid left...
        public char[] Squares { get; set; } = new char[9];

        public TicTacToeBoard()
        {

        }

 
        bool AreSpacesLeft()
        {
           
            for (int i=0;i<9;i++)
            {
                if (Squares[i] == '\x0000')
                    return true;
            }
            return false;
        }

        /// <summary>
        /// return X, O, or  '\x0000' for no winer
        /// </summary>
        /// <returns></returns>
        public char DetermineWinner()
        {
            if (Squares[0] == Squares[1] && Squares[1]==Squares[2] && Squares[0]!= '\x0000')
            {
                return Squares[0];
            }
            if (Squares[3] == Squares[4] && Squares[4] == Squares[5] && Squares[3] != '\x0000')
            {
                return Squares[3];
            }
            if (Squares[6] == Squares[7] && Squares[7] == Squares[8] && Squares[6] != '\x0000')
            {
                return Squares[6];
            }
            return '\x0000';
        }
     

        /// <summary>
        /// Return true if the computer was able to play
        /// </summary>
        /// <returns></returns>
        public bool ComputerPlay()
        {
            /*To Do replace with fancy schmancy AI*/
            //if the middle is open, pick that
            if (Squares[4]== '\x0000')
            {
                Squares[4] = 'O';
            }
            else //just pick the first open 
            {
                for (int i=0;i<9;i++)
                {
                    if (Squares[i]== '\x0000')
                    {
                        Squares[i] = 'O';
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
