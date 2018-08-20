using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using knight_moves_api.Models;
using knight_moves_api.Services;
using Microsoft.AspNetCore.Cors;

namespace knight_moves_api.Controllers
{
    public class HomeController : Controller
    {
        private IMoveService moveService;

        public HomeController(IMoveService _moveService)
        {
            moveService = _moveService;
        }

        public IActionResult Index()
        {
            return Json("Hello World!");
        }

        [EnableCors("SiteCorsPolicy")]
        public IActionResult Knight(string coordX, int coordY)
        {
            var knight = new Knight()
            {
                ActualPos = new Moves()
                {
                    coordx = coordX,
                    coordy = coordY
                }
            };
            knight.PossibleMoves = moveService.KnightPossibleMoves(knight);
            return Json(knight);
        }
    }
}
