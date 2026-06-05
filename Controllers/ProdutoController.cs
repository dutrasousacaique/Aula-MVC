using Microsoft.AspNetCore.Mvc;

public class ProdutoController : Controller
{
    public IActionResult Index()
    {
        ViewBag.Nomes = new List<string> {
            "Notebook", "Mouse", "Teclado", "Monitor", "Headset"
        };
        ViewBag.Precos = new List<double> {
            3500.00, 89.90, 149.90, 999.00, 79.90
        };
        return View();
    }
}
