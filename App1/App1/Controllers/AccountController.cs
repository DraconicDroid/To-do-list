using Microsoft.AspNetCore.Mvc;
using App1.Models;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace App1.Controllers
{
    public class AccountController : Controller
    {
        
        //private readonly SignInManager<IdentityUser> Server;

        //public AccountController(SignInManager<IdentityUser> signInManager)
        //{
            //this.Server = signInManager;
        //}

        //[HttpPost]
        //public async Task<IActionResult> Logout()
        //{
           //await Server.SignOutAsync();
            //return RedirectToAction("Index", "Home");
        //}
        // GET
        public IActionResult Login()
        {
            return View();
        }
    


        public IActionResult Register()
        {
            return View();
        }

    }
}

//https://www.youtube.com/playlist?list=PL6n9fhu94yhVkdrusLaQsfERmL_Jh4XmU <----- For future work