using iman_elahy_hw09.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using iman_elahy_hw09.data;
using iman_elahy_hw09.Models.viewmodel;

namespace iman_elahy_hw09.Controllers
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



            var users = DBrepository.listlibrary();
            return View(users);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult create()
        {
           

             
            return View();
        }
        [HttpPost]
        public IActionResult create(Member member)
        {
            var id = 1;
            if (Memberrepository.ListUser.Count != 0)
            {
                id = (Memberrepository.ListUser[Memberrepository.ListUser.Count() -1 ].ID) + 1;
            }
            member.ID = id;
            member.RegistrationDate = DateTime.Now;
            Memberrepository.ListUser.Add(member);
            return RedirectToAction("Index");



            
        }
        public IActionResult edite(int id)
        {
           var user= Memberrepository.ListUser.FirstOrDefault(x => x.ID == id);

            return View(user);
        }
        [HttpPost]
        public IActionResult edite(Member member)
        {
            var user = Memberrepository.ListUser.FirstOrDefault(x => x.ID == member.ID);
            user.Name=member.Name;
            user.LastName=member.LastName;
            user.PhoneNumber=member.PhoneNumber;
            user.Genderindex=member.Genderindex;
            user.levelindex=member.levelindex;
            user.NationalCode=member.NationalCode;
            return RedirectToAction("Index");
        }
        
        public IActionResult delete(int id)
        { 

            
            memberDBContext member = new();
           var m=member.members.Where(x=> x.ID==id).FirstOrDefault();
            member.Remove(m);
            member.SaveChanges();
            return RedirectToAction("Memberview");
        }
        public IActionResult searchbox()
        {
            return View();
        }
        [HttpPost]
        public IActionResult search(listlibraryvm searchlist)
        {
            var result = DBrepository.searchDB(searchlist);

            return View("search",result);
        }
        public IActionResult Memberlist()
        {
            memberDBContext member = new();
            var result = member.members.ToList();
            return View("Memberview", result);
        }
    }
}