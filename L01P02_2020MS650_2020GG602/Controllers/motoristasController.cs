using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using L01P02_2020MS650_2020GG602.Models;

namespace L01P02_2020MS650_2020GG602.Controllers
{
    public class motoristasController : Controller
    {
        private readonly restauranteDbContext _context;

        public motoristasController(restauranteDbContext context)
        {
            _context = context;
        }

        // GET: motoristas
        public async Task<IActionResult> Index()
        {
              return _context.motorista != null ? 
                          View(await _context.motorista.ToListAsync()) :
                          Problem("Entity set 'restauranteDbContext.motorista'  is null.");
        }

        // GET: motoristas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.motorista == null)
            {
                return NotFound();
            }

            var motoristas = await _context.motorista
                .FirstOrDefaultAsync(m => m.motoristaId == id);
            if (motoristas == null)
            {
                return NotFound();
            }

            return View(motoristas);
        }

        // GET: motoristas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: motoristas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("motoristaId,nombreMotorista")] motoristas motoristas)
        {
            if (ModelState.IsValid)
            {
                _context.Add(motoristas);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(motoristas);
        }

        // GET: motoristas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.motorista == null)
            {
                return NotFound();
            }

            var motoristas = await _context.motorista.FindAsync(id);
            if (motoristas == null)
            {
                return NotFound();
            }
            return View(motoristas);
        }

        // POST: motoristas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("motoristaId,nombreMotorista")] motoristas motoristas)
        {
            if (id != motoristas.motoristaId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(motoristas);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!motoristasExists(motoristas.motoristaId))
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
            return View(motoristas);
        }

        // GET: motoristas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.motorista == null)
            {
                return NotFound();
            }

            var motoristas = await _context.motorista
                .FirstOrDefaultAsync(m => m.motoristaId == id);
            if (motoristas == null)
            {
                return NotFound();
            }

            return View(motoristas);
        }

        // POST: motoristas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.motorista == null)
            {
                return Problem("Entity set 'restauranteDbContext.motorista'  is null.");
            }
            var motoristas = await _context.motorista.FindAsync(id);
            if (motoristas != null)
            {
                _context.motorista.Remove(motoristas);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool motoristasExists(int id)
        {
          return (_context.motorista?.Any(e => e.motoristaId == id)).GetValueOrDefault();
        }
    }
}
