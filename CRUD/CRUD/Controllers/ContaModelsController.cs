using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CRUD.Models;
using CRUD.Models.Data;

namespace CRUD.Controllers
{
    public class ContaModelsController : Controller
    {
        private readonly DataContext _context;

        public ContaModelsController(DataContext context)
        {
            _context = context;
        }

        // GET: ContaModels
        public async Task<IActionResult> Index()
        {
            var dataContext = _context.Tarefas.Include(c => c.Usuario);
            return View(await dataContext.ToListAsync());
        }

        // GET: ContaModels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contaModel = await _context.Tarefas
                .Include(c => c.Usuario)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (contaModel == null)
            {
                return NotFound();
            }

            return View(contaModel);
        }

        // GET: ContaModels/Create
        public IActionResult Create()
        {
            ViewData["IdUsuario"] = new SelectList(_context.Usuarios, "Id", "Email");
            return View();
        }

        // POST: ContaModels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,nomeTitular,saldoConta,dataCriacao,dataExclusao,IdUsuario")] ContaModel contaModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(contaModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdUsuario"] = new SelectList(_context.Usuarios, "Id", "Email", contaModel.IdUsuario);
            return View(contaModel);
        }

        // GET: ContaModels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contaModel = await _context.Tarefas.FindAsync(id);
            if (contaModel == null)
            {
                return NotFound();
            }
            ViewData["IdUsuario"] = new SelectList(_context.Usuarios, "Id", "Email", contaModel.IdUsuario);
            return View(contaModel);
        }

        // POST: ContaModels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,nomeTitular,saldoConta,dataCriacao,dataExclusao,IdUsuario")] ContaModel contaModel)
        {
            if (id != contaModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(contaModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ContaModelExists(contaModel.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdUsuario"] = new SelectList(_context.Usuarios, "Id", "Email", contaModel.IdUsuario);
            return View(contaModel);
        }

        // GET: ContaModels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contaModel = await _context.Tarefas
                .Include(c => c.Usuario)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (contaModel == null)
            {
                return NotFound();
            }

            return View(contaModel);
        }

        // POST: ContaModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var contaModel = await _context.Tarefas.FindAsync(id);
            if (contaModel != null)
            {
                _context.Tarefas.Remove(contaModel);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ContaModelExists(int id)
        {
            return _context.Tarefas.Any(e => e.Id == id);
        }
    }
}
