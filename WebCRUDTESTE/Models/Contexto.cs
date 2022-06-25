using Microsoft.EntityFrameworkCore;

namespace WebCRUDTESTE.Models
{
    public class Contexto : DbContext
    {

        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {

        }

        public DbSet<produto> Produtos { get; set; }

        public DbSet<cliente> Cliente { get; set; }

        public DbSet<Vendas> Vendas { get; set; }
    }
}
