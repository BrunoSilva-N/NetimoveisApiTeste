using Microsoft.EntityFrameworkCore;
using NetimoveisApiTeste.Model;

namespace NetimoveisApiTeste.Context
{
    public class ImovelContext : DbContext
    {
        public ImovelContext( DbContextOptions <ImovelContext >options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Imovel> imovels { get; set; }
    }
}
