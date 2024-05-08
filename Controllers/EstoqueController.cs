using GerenciamentoDeEstoqueDoacoes.Data;
using GerenciamentoDeEstoqueDoacoes.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

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

        [HttpGet]
        public IActionResult Editar(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var doacao = _context.Doacoes.FirstOrDefault(x => x.Id == id);

            if (doacao == null)
            {
                return NotFound();
            }
            return View(doacao);
        }

        [HttpGet]
        public IActionResult Excluir(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var doacao = _context.Doacoes.FirstOrDefault(x => x.Id == id);

            if (doacao == null)
            {
                return NotFound();
            }
            return View(doacao);
        }

        [HttpGet]
        public IActionResult ContarDoacoes()
        {
           
            return View();
        }

        [HttpGet]
        public IActionResult Enviar(int id)
        {
            var doacao = _context.Doacoes.Find(id);
            if (doacao == null)
            {
                return NotFound();
            }
            return View(doacao);
        }
        [HttpPost]
        public IActionResult Cadastrar(DoacoesModel doacoes)
        {
            if (ModelState.IsValid)
            {
                _context.Doacoes.Add(doacoes);
                _context.SaveChanges();
                doacoes.Quantidade += 1;
 
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpPost]
        public IActionResult Editar(DoacoesModel doacoes)
        {
            if (ModelState.IsValid)
            {
                _context.Doacoes.Update(doacoes);
                if(doacoes.Entrege == false)
                {
                    doacoes.Entrege = false;
                }
                doacoes.Entrege = true;
                _context.SaveChanges(); 
                return RedirectToAction("Index");
            }
            return View(doacoes);
        }

        [HttpPost]
        public IActionResult Excluir(DoacoesModel doacoes)
        {
            if (doacoes == null)
            {
                return NotFound();

            }
            _context.Doacoes.Remove(doacoes);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Enviar(int? id)
        {
            var doacao = _context.Doacoes.Find(id);
            if (doacao == null)
            {
                return NotFound();
            }
            else
            {
                doacao.Entrege = true;
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public IActionResult ContarDoacoes(string opc, DoacoesModel model)
        {
            switch (opc)
            {
                case "Roupa":
                    model.contRoupa++;
                    break;
                case "Materiais":
                    model.contMateriais++;
                    break;
                case "Alimentoa":
                    model.contAlimento++;
                    break;
                case "Outros":
                    model.contOutros++;
                    break;
            }
            return View();
        }
    }
}
