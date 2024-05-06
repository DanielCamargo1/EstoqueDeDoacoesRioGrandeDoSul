using System.ComponentModel.DataAnnotations;

namespace GerenciamentoDeEstoqueDoacoes.Models
{
    public class DoacoesModel
    {
        
        public int Id { get; set; }
        [Required(ErrorMessage ="Digite o nome do item")]
        public string NomeDoItem { get; set; }

        [Required(ErrorMessage = "Digite a quantidade")]
        public int Quantidade { get; set; }

        public bool EmEstoque { get; set; }
        public bool Entrege { get; set; }
        public DateTime HorarioDoacao { get; set; } = DateTime.Now;
    }
}
