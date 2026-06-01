using Microsoft.AspNetCore.Mvc;

namespace PerfilAlunoMVC.Controllers
{
    public class AlunoController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Nome = "João Silva";
            ViewBag.Curso = "Desenvolvimento Web";
            ViewBag.Semestre = 3;

            return View();
        }

        public IActionResult Detalhes(int id)
        {
            ViewBag.Id = id;
            return View();
        }
    }
}  
