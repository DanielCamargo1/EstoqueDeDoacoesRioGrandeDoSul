using GerenciamentoDeEstoqueDoacoes.Models;
using Microsoft.EntityFrameworkCore;

namespace GerenciamentoDeEstoqueDoacoes.Data
{
    public class EstoqueDbContext : DbContext
    {
        public EstoqueDbContext(DbContextOptions<EstoqueDbContext> options) : base(options)
        {

        }
        public DbSet<DoacoesModel> Doacoes { get; set; }
        public DbSet<RelacoesModel> Relacoes { get; set; }
    }
}
