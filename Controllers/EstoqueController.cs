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

            IEnumerable<DoacoesModel> doacoes = _context.Doacoes;
            return View(doacoes);

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
        public IActionResult ContarDoacoes(DoacoesModel doacoes)
        {
            ViewBag.ContRoupa = _context.Doacoes.Sum(d => d.contRoupa);
            ViewBag.ContMateriais = _context.Doacoes.Sum(d => d.contMateriais);
            ViewBag.ContAlimentos = _context.Doacoes.Sum(d => d.contAlimento);
            ViewBag.ContOutros = _context.Doacoes.Sum(d => d.contOutros);
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
                string opc = Request.Form["opcao"];
                switch (opc)
                {
                    case "Roupa":
                        doacoes.contRoupa += doacoes.Quantidade;
                        break;
                    case "Materiais":
                        doacoes.contMateriais += doacoes.Quantidade;
                        break;
                    case "Alimentos":
                        doacoes.contAlimento += doacoes.Quantidade;
                        break;
                    case "Outros":
                        doacoes.contOutros += doacoes.Quantidade;
                        break;
                    default:
                        
                        return BadRequest("Tipo de doação inválido.");
                }
                _context.Doacoes.Add(doacoes);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(doacoes);
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
    }
}
