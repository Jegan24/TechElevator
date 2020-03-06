using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SessionCart.Web.Extensions;
using TicTacToeGame.Models;

namespace TicTacToeGame.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult RegisterUser(UserInfo user)
        {
            if (!ModelState.IsValid)
            {
                return View("Index");
            }
            HttpContext.Session.Set("User_Info", user);
            HttpContext.Session.Set("Num_Games_Played", 0);
            TicTacToeBoard board = new TicTacToeBoard();
            HttpContext.Session.Set("board", board);

            ViewData["name"] = user.UserName;

            return View("GameBoard",board);
        }

        [HttpPost]
        public IActionResult MakePlay(int index)
        {
            TicTacToeBoard board = HttpContext.Session.Get<TicTacToeBoard>("board"); 
            if (board==null)
            {
                board = new TicTacToeBoard();
            }
            board.Squares[index] = 'X';
            board.ComputerPlay();
            HttpContext.Session.Set("board", board);

            UserInfo info = HttpContext.Session.Get<UserInfo>("User_Info");
            ViewData["name"] = info == null ? "Unknown Player" : info.UserName;

            return View("GameBoard", board);
        }
       
        //TO DO - add GameBaord and then always redirect to action
        //check in there if there's a winner or if the game is over

        public IActionResult Privacy()
        {
            return View();
        }
        

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
