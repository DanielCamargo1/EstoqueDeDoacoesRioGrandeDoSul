using System.ComponentModel.DataAnnotations;

namespace GerenciamentoDeEstoqueDoacoes.Models
{
    public class relacoesModel
    {
        [Key]
        public string GridRadios { get; set; }
        public bool RoupaSelected { get { return GridRadios == "option1"; } }
        public bool MateriaisSelected { get { return GridRadios == "option2"; } }
        public bool AlimentosSelected { get { return GridRadios == "option3"; } }
        public bool OtrosSelected { get { return GridRadios == "option4"; } }
    }
}
