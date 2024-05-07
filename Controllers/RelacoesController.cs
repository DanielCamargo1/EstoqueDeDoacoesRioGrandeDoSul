using GerenciamentoDeEstoqueDoacoes.Data;
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
    }
}
