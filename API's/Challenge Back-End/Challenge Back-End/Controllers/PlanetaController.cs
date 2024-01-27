using Challenge_Back_End.Model;
using Challenge_Back_End.Repositorio.IRepositorio;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Numerics;

namespace Challenge_Back_End.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class PlanetaController : Controller
    {
        private readonly IPlanetaRepositorio _planetaRepositorio;
        private readonly HttpClient _httpClient;

        public PlanetaController(IPlanetaRepositorio planetaRepositorio)
        {
            _planetaRepositorio = planetaRepositorio;
            _httpClient = new HttpClient();
        }

        [HttpPost("Cadastrar")]
        public async Task<ActionResult<PlanetaModel>> Cadastrar([FromBody]PlanetaModel planetaModel)
        {
            try
            {
                PlanetaModel planeta = await _planetaRepositorio.CriarPlaneta(planetaModel);
                return Ok(planeta);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Ocorreu um erro interno ao cadastrar o planeta.");
            }
        }

        [HttpGet]
        public async Task<ActionResult<PlanetaModel>> BuscarPlaneta()
        {
            try
            {
                List<PlanetaModel> planeta = await _planetaRepositorio.BuscarPlanetas();
                return Ok(planeta);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Ocorreu um erro interno ao buscar os planetas.{ex.Message}");
            }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<PlanetaModel>> BuscarPlanetaPorID(int id)
        {
            try
            {
                PlanetaModel Planeta = await _planetaRepositorio.BuscarPlanetaPorID(id);
                return Ok(Planeta);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Ocorreu um erro interno ao buscar o planeta com o id: {id}\n Message: {ex.Message}");

            }
        }
        [HttpGet("{nome}")]
        public async Task<ActionResult<PlanetaModel>> BuscarPlanetaPorNome(string nome)
        {
            try
            {
                PlanetaModel Planeta = await _planetaRepositorio.BuscarPlanetaPorNome(nome);
                return Ok(Planeta);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Ocorreu um erro interno ao buscar o planeta com o Nome: {nome}\n Message: {ex.Message}");

            }
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<bool>> DeletarPlaneta(int id)
        {
            try
            {
                bool status = await _planetaRepositorio.DeletarPlaneta(id);
                return Ok(status);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Ocorreu um erro interno ao buscar o planeta com o id: {id}\n Message: {ex.Message}");
            }
        }

        [HttpGet("{id}/films")]
        public async Task<ActionResult<IEnumerable<string>>> GetPlanetFilms(int planetId)
        {
            string apiUrl = $"https://swapi.dev/api/planets/{planetId}/";
            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync(apiUrl);

                if (response.IsSuccessStatusCode)
                {
                    var planet = await response.Content.ReadAsAsync<PlanetaModel>();
                    return Ok(planet.Nome);
                }
                else
                {
                    return StatusCode((int)response.StatusCode, $"Erro na requisição: {response.ReasonPhrase}");
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Erro ao fazer a requisição: {ex.Message}");
            }
        }
    }
}
