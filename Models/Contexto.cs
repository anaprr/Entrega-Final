using Microsoft.EntityFrameworkCore;

namespace Projeto_Final.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {

        }
        public DbSet<Usuario> Usuario { get; set; }

        public DbSet<Pais> Pais { get; set; }

        public DbSet<Fornecedor> Fornecedor { get; set; }


    }
}
