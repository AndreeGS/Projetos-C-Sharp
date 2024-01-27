using Challenge_Back_End.Data;
using Challenge_Back_End.Model;
using Challenge_Back_End.Repositorio.IRepositorio;
using Microsoft.EntityFrameworkCore;

namespace Challenge_Back_End.Repositorio
{
    public class PlanetaRepositorio : IPlanetaRepositorio
    {
        private readonly DataContext _dataContext;

        public PlanetaRepositorio(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<PlanetaModel> CriarPlaneta(PlanetaModel planeta)
        {
            await _dataContext.Planetas.AddAsync(planeta);
            await _dataContext.SaveChangesAsync();

            return planeta;
        }

        public async Task<List<PlanetaModel>> BuscarPlanetas()
        {
            return await _dataContext.Planetas.ToListAsync();
        }

        public async Task<PlanetaModel> BuscarPlanetaPorID(int id)
        {
            return await _dataContext.Planetas.FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task<PlanetaModel> BuscarPlanetaPorNome(string Nome)
        {
            return _dataContext.Planetas.FirstOrDefault(p => p.Nome == Nome);
        }


        public async Task<bool> DeletarPlaneta(int id)
        {
            PlanetaModel planeta = await BuscarPlanetaPorID(id);

            if (planeta == null)
            {
                throw new SystemException("Não encontrado o id do planeta no banco de dados");
            }

            _dataContext.Planetas.Remove(planeta);
            return true;
        }
    }

}
