using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using micro.Domain.Interface; 
using micro.Domain.Models;
using micro.Repository;

namespace micro.Controllers
{
    public class PreDefinidosController : Controller
    {
        private readonly IProgramaAquecimento programaRepository;

        public PreDefinidosController(IProgramaAquecimento programaRepository)
        {
            this.programaRepository = programaRepository;
        }

        public IActionResult Programas()
        {
            List<ProgramaAquecimento> _programas = programaRepository.ListarProgramasPreDefinidos();

            return View(_programas); 
        }
    }
}


