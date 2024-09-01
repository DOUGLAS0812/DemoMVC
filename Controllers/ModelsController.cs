using DemoMVC.Data.Migrations;
using Microsoft.AspNetCore.Mvc;

namespace DemoMVC.Controllers
{
    public class ModelsController : Controller
    {
        public IActionResult Index()
        {
            var aluno = new Aluno();

            if (TryValidateModel(aluno))
            {
                return View(aluno);
            }

            var ms = ModelState;

            var erros = ModelState.Select( x => x.Value.Errors)
                                               .Where(y => y.Count > 0)
                                               .ToList();

            erros.ForEach(r => Console.WriteLine(r.First().ErrorMessage));

            return View();
        }
    }
}
