using Microsoft.AspNetCore.Mvc;

public class EnderecoController : Controller
{
    [HttpGet]
    public IActionResult Buscar()
    {
        return View(new EnderecoModel());
    }

    [HttpPost]
    public IActionResult Buscar(EnderecoModel model)
    {
        if (!ModelState.IsValid)
            return View(model);

        return View("Resultado", model);
    }
}
