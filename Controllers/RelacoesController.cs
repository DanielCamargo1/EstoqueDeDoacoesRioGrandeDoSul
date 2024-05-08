using GerenciamentoDeEstoqueDoacoes.Data;
using GerenciamentoDeEstoqueDoacoes.Models;
using Microsoft.AspNetCore.Mvc;

namespace GerenciamentoDeEstoqueDoacoes.Controllers
{
    public class RelacoesController : Controller  
    {

        private readonly EstoqueDbContext _context;
        public RelacoesController(EstoqueDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult RelacoesAlimento(RelacoesModel relacao)
        {
            if(relacao.AlimentosSelected == true)
            {
                int cont = relacao.NumAlimentos + 1;
                return View("Index", cont);
            }
            return View("Index");
        }
    }
}
