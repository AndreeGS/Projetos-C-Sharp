
using Challenge_Back_End.Model;

namespace Challenge_Back_End.Repositorio.IRepositorio
{
    public interface IPlanetaRepositorio
    {
        Task<PlanetaModel> CriarPlaneta(PlanetaModel planeta);
        Task<List<PlanetaModel>> BuscarPlanetas();

        Task<PlanetaModel> BuscarPlanetaPorID(int id);

        Task<PlanetaModel> BuscarPlanetaPorNome(string nome);
        Task<bool> DeletarPlaneta(int id);
    }
}
