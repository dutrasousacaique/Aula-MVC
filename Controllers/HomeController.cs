using Microsoft.AspNetCore.Mvc;

public class HomeController : Controller
{
    public IActionResult Index() => View();

    public IActionResult Boletim()
    {
        ViewBag.Disciplinas = new List<string> {
            "Matemática", "Português", "História", "Ciências"
        };
        ViewBag.Notas = new List<double> { 9.5, 6.0, 4.5, 7.8 };
        return View();
    }
}
