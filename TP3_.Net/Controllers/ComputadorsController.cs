using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TP3_.NET.Context;
using TP3_.NET.Models;

namespace TP3_.NET.Controllers
{
    public class ComputadorsController : Controller
    {
        private readonly InfnetDbContext _context;

        public ComputadorsController(InfnetDbContext context)
        {
            _context = context;
        }

        // GET: Computadors
        public async Task<IActionResult> Index()
        {
            return View(await _context.computador.ToListAsync());
        }

        // GET: Computadors/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var computador = await _context.computador
                .FirstOrDefaultAsync(m => m.Id == id);
            if (computador == null)
            {
                return NotFound();
            }

            return View(computador);
        }

        // GET: Computadors/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Computadors/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Marca,Processador,PlacaMae,Memoria,HD,NumeroPratrimonio,DataCompra")] Computador computador)
        {
            if (ModelState.IsValid)
            {
                _context.Add(computador);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(computador);
        }

        // GET: Computadors/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var computador = await _context.computador.FindAsync(id);
            if (computador == null)
            {
                return NotFound();
            }
            return View(computador);
        }

        // POST: Computadors/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Marca,Processador,PlacaMae,Memoria,HD,NumeroPratrimonio,DataCompra")] Computador computador)
        {
            if (id != computador.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(computador);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ComputadorExists(computador.Id))
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
            return View(computador);
        }

        // GET: Computadors/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var computador = await _context.computador
                .FirstOrDefaultAsync(m => m.Id == id);
            if (computador == null)
            {
                return NotFound();
            }

            return View(computador);
        }

        // POST: Computadors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var computador = await _context.computador.FindAsync(id);
            if (computador != null)
            {
                _context.computador.Remove(computador);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ComputadorExists(int id)
        {
            return _context.computador.Any(e => e.Id == id);
        }
    }
}
