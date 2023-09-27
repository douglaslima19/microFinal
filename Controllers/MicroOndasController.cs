
using micro.Service;
using Microsoft.AspNetCore.Mvc;

namespace micro.Controllers
{
    public class MicroOndasController : Controller
    {
        private readonly MicroOndasService microOndasService;

        public MicroOndasController(MicroOndasService microOndasService)
        {
            this.microOndasService = microOndasService;
        }

        public IActionResult Programas()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> IniciarAquecimento(int tempoEmSegundos)
        {
            int tempoRestante = await microOndasService.IniciarAquecimento(tempoEmSegundos);
            return Json(new { tempoRestante });
        }

        public IActionResult PausarAquecimento()
        {
            microOndasService.PausarAquecimento();
            return RedirectToAction("Programas");
        }

        public IActionResult RetomarAquecimento()
        {
            microOndasService.RetomarAquecimento();
            return RedirectToAction("Prog");
        }
    }
}
