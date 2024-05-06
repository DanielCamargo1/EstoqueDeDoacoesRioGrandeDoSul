using GerenciamentoDeEstoqueDoacoes.Data;
using GerenciamentoDeEstoqueDoacoes.Models;
using Microsoft.AspNetCore.Mvc;

namespace GerenciamentoDeEstoqueDoacoes.Controllers
{
    public class EstoqueController : Controller
    {

        private readonly EstoqueDbContext _context;
        public EstoqueController(EstoqueDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {

            IEnumerable<DoacoesModel> emprestimos = _context.Doacoes;
            return View(emprestimos);
        }

        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }
    }
}
