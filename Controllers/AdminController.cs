using Auction.Models;
using Auction.Repository.IRepository;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace Auction.Controllers
{
    public class AdminController : Controller
    {
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly IUnitOfWork _unitOfWork;

        public AdminController(IUnitOfWork unitOfWork, IWebHostEnvironment webHostEnvironment)
        {
            _unitOfWork = unitOfWork;
            _webHostEnvironment = webHostEnvironment;
        }
        [HttpGet]
        public IActionResult AddPlayer()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddPlayer(Players obj, IFormFile? file)
        {
            if (ModelState.IsValid)
            {
                string wwwRootPath = _webHostEnvironment.WebRootPath;

                if (file != null)
                {

                    string filename = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);
                    string productPath = Path.Combine(wwwRootPath, @"Images\Players");

                    using (var fileStream = new FileStream(Path.Combine(productPath, filename), FileMode.Create))
                    {
                        file.CopyTo(fileStream);
                    }


                    obj.ImageUrl = @"\Images\Players\" + filename;
                    
                    var Player = new Players
                    {
                        Name = obj.Name,
                        role = obj.role,
                        Team = obj.Team,
                        ImageUrl = obj.ImageUrl,
                    };

                    _unitOfWork.Players.Add(Player);


                }
                _unitOfWork.Save();
                TempData["success"] = "Player Added successfully";
                return RedirectToAction("Index", "Home");
            }
            return View();
        }
    }
}
//hello  this is rahul jadhav

