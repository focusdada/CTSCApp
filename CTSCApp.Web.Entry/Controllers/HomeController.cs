using CTSCApp.Application;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Security.Claims;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Furion.Web.Entry.Controllers
{
    [AllowAnonymous]
    public class HomeController : Controller
    {
        private readonly ISystemService _systemService;

        public HomeController(ISystemService systemService)
        {
            _systemService = systemService;
        }

        public IActionResult Index()
        {
            var userName = User.Identity.Name;
            ViewBag.Description = _systemService.GetDescription();

            return View();
        }

        [AllowAnonymous]
        public IActionResult Login(string userName, string password)
        {
            var user = (WindowsIdentity)HttpContext.User.Identity;


            
            ViewBag.Description = "Login";
            return View();
        }
    }
}