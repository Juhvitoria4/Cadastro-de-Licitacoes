using LicitacaoAPI.Models; // Confirme que este namespace existe e está correto
using Microsoft.EntityFrameworkCore;

namespace LicitacoesAPI.Data
{
    public class LicitacaoContext : DbContext
    {
        public LicitacaoContext(DbContextOptions<LicitacaoContext> options) : base(options)
        {
        }

        public DbSet<Licitacao> Licitacoes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Licitacao>()
                .HasIndex(l => l.NumeroLicitacao)
                .IsUnique();

            base.OnModelCreating(modelBuilder);
        }
    }
}
