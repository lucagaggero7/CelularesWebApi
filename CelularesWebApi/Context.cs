using CelularesWebApi.Entidades;
using Microsoft.EntityFrameworkCore;

namespace CelularesWebApi
{
    public class Context : DbContext
    {
        public Context(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Celular> Celulares {  get; set; }
    }
}
