using Auction.Data;
using Auction.Models;
using Auction.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Auction.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUnitOfWork dbcontext;

        public HomeController(IUnitOfWork dbcontext)
        {
            this.dbcontext = dbcontext;
        }


        public IActionResult Index()
        {
            var Player = dbcontext.Players.GetAll().ToList();
            return View(Player);
        }
       
    }
}
