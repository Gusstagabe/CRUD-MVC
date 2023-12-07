using Microsoft.EntityFrameworkCore;
using WebMvcMysql.Models;

namespace WebMvcMysql.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        { }
        

        public DbSet<Contato> Contato { get; set; }
    }
}
