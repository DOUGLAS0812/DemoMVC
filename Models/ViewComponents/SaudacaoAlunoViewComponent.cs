using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace DemoMVC.Models.ViewComponents
{
    public class SaudacaoAlunoViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()

        {
            var aluno = new Aluno() { Name = "Douglas" };
            return View(aluno);

        }
    }
}
