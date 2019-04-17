﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Locadora.Models;

namespace Locadora.Controllers
{
    public class LocacaosController : Controller
    {
        private readonly LocadoraContext _context;

        public LocacaosController(LocadoraContext context)
        {
            _context = context;
        }

        // GET: Locacaos
        public async Task<IActionResult> Index()
        {
            return View(await _context.Locacao.ToListAsync());
        }

        // GET: Locacaos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var locacao = await _context.Locacao
                .FirstOrDefaultAsync(m => m.Id == id);
            if (locacao == null)
            {
                return NotFound();
            }

            return View(locacao);
        }

        // GET: Locacaos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Locacaos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,RentalPrice")] Locacao locacao)
        {
            if (ModelState.IsValid)
            {
                _context.Add(locacao);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(locacao);
        }

        // GET: Locacaos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var locacao = await _context.Locacao.FindAsync(id);
            if (locacao == null)
            {
                return NotFound();
            }
            return View(locacao);
        }

        // POST: Locacaos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,RentalPrice")] Locacao locacao)
        {
            if (id != locacao.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(locacao);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LocacaoExists(locacao.Id))
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
            return View(locacao);
        }

        // GET: Locacaos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var locacao = await _context.Locacao
                .FirstOrDefaultAsync(m => m.Id == id);
            if (locacao == null)
            {
                return NotFound();
            }

            return View(locacao);
        }

        // POST: Locacaos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var locacao = await _context.Locacao.FindAsync(id);
            _context.Locacao.Remove(locacao);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Rent()
        {
            return View (await _context.Filme.ToListAsync());
        }

        private bool LocacaoExists(int id)
        {
            return _context.Locacao.Any(e => e.Id == id);
        }
    }
}
