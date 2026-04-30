using Microsoft.AspNetCore.Mvc;

public class SettingsController : Controller
{
    public IActionResult Theme()
    {
        return View();
    }
}