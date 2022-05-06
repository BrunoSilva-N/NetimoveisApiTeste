using Microsoft.EntityFrameworkCore;
using NetimoveisApiTeste.Context;
using NetimoveisApiTeste.Model;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetimoveisApiTeste.Repositories
{


    public class ImoveisRepositor : IImoveisRepositor
    {

        public readonly ImovelContext _context;

        public ImoveisRepositor(ImovelContext context)
        {
            _context = context;
        }

            public async Task<Imovel> Create(Imovel imovel)
        {
          _context.imovels.Add(imovel);
           await _context.SaveChangesAsync();
            return imovel;
        }

        public async Task Delete(int id)
        {
         var imovelToDelete = await _context.imovels.FindAsync(id);
            _context.imovels.Remove(imovelToDelete);
            await _context.SaveChangesAsync(); 
        }

        public async Task<IEnumerable<Imovel>> Get()
        {
            return await _context.imovels.ToListAsync();
        }

        public async Task<Imovel> Get(int id)
        {

            return await _context.imovels.FindAsync();     }

        public async Task Update(Imovel imovel)
        {
        _context.Entry(imovel).State = EntityState.Modified;
            await _context.SaveChangesAsync();  
        }
    }
}
