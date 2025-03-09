using Microsoft.AspNetCore.Mvc;
using PhotoManagement.Models;
using System.Diagnostics;
using BLL;
namespace PhotoManagement.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        static string code;

        public IActionResult Index()
        {
           
            return View();
        }

        

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult size()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        public IActionResult CreateOrder()
        {
            return View(); // ודא שה-View קיים
        }

        //מקבל את הנתונים מדף open order 
        [HttpPost]
        public IActionResult SubmitOrder(string name, int phone)
        {
            // שמירה של הערכים שהתקבלו במתודעה
            string userName = name; // תוכן השם מה-input
            int userPhone = phone; // תוכן הטלפון מה-input
            ViewData["Name"] = userName; // החלף עם השם האמיתי
            ViewData["Phone"] = userPhone; // החלף עם הטלפון האמיתי
            string uniqueCodeOrder = BLL.Class1.GenerateShortUniqueCodeFromGuid();
            ViewBag.UniqueCode = uniqueCodeOrder; // מעביר לקוד הייחודי ל-View
            string uniqueCodeCustomer = BLL.Class1.GenerateShortUniqueCodeFromGuid();
            ViewBag.UniqueCode = uniqueCodeCustomer; // מעביר לקוד הייחודי ל-View
            code = uniqueCodeOrder;
            BLL.Class1.newOrder(userName, uniqueCodeCustomer, userPhone, uniqueCodeOrder,"path.....!!!!");
            return View("size");
        }


        [HttpPost]
        public IActionResult SaveSelection(string size)
        {
            // שמירה של הערכים שהתקבלו במתודעה
            ViewData["Size"] = size;
            ViewData["code"] = code;
            
            string userSize = size;
            Console.WriteLine("new size"+userSize);
            return View("Privacy");
        }

    }
}