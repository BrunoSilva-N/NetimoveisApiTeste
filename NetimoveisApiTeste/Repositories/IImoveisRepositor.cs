using NetimoveisApiTeste.Model;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NetimoveisApiTeste.Repositories
{
    public interface IImoveisRepositor
    {
        Task<IEnumerable<Imovel>> Get();
        Task<Imovel> Get(int Id);
        Task<Imovel> Create(Imovel imovel);
        Task Update(Imovel imovel);

        Task Delete(int Id);

    }
}
