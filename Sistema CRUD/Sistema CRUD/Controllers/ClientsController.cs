using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sistema_CRUD.Models;

namespace Sistema_CRUD.Controllers
{
    public class ClientsController : Controller
    {
        private readonly AppDbContext _context;

        public ClientsController(AppDbContext context)
        { 
            _context = context;
        } 
        
        public async Task<IActionResult> Index()
        {
            var dados = await _context.Clientes.ToListAsync();

            return View(dados);
        }
    }
}
