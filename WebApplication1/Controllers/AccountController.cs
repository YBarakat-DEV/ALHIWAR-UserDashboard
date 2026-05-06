using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;

public class AccountController : Controller
{
    public IActionResult Login()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Login(string username, string password)
    {
        if (username == "admin" && password == "123")
        {
            HttpContext.Session.SetString("User", username);
            return RedirectToAction("Dashboard", "Home");
        }
        ViewBag.Error = "YOU HAVE WRONG PASSWORD";
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Logout()
    {
        HttpContext.Session.Clear();   // ✅ remove session
       

        return RedirectToAction("Login", "Account");
    }

}