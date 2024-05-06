namespace GerenciamentoDeEstoqueDoacoes.Models
{
    public class DoacoesModel
    {
        public int Id { get; set; }
        public string NomeDoItem { get; set; }
        public int Quantidade { get; set; }
        public bool EmEstoque { get; set; }
        public bool Entrege { get; set; }
        public DateTime HorarioDoacao { get; set; } = DateTime.Now;
    }
}
