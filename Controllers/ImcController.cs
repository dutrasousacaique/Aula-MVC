using Microsoft.AspNetCore.Mvc;

public class ImcController : Controller
{
    [HttpGet]
    public IActionResult Calcular()
    {
        return View(new ImcModel());
    }

    [HttpPost]
    public IActionResult Calcular(ImcModel model)
    {
        if (!ModelState.IsValid)
            return View(model);

        model.Resultado = model.Peso / (model.Altura * model.Altura);

        model.Classificacao = model.Resultado switch
        {
            < 18.5 => "Abaixo do peso",
            < 25.0 => "Peso normal",
            < 30.0 => "Sobrepeso",
            < 35.0 => "Obesidade Grau I",
            < 40.0 => "Obesidade Grau II",
            _      => "Obesidade Grau III"
        };

        return View(model);
    }
}
