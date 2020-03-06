using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TicTacToeGame.Models
{
    public class UserInfo
    {
        public string UserName { get; set; }

        [Range(1,5) ]
        public int NumberOfRounds { get; set; }

        public int NumWins { get; set; }
    }
}
