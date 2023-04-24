using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AR_PROGRESO1.Data;
using AR_PROGRESO1.Models;

namespace AR_PROGRESO1.Controllers
{
    public class ARAURAsController : Controller
    {
        private readonly AR_PROGRESO1Context _context;

        public ARAURAsController(AR_PROGRESO1Context context)
        {
            _context = context;
        }

        // GET: ARAURAs
        public async Task<IActionResult> Index()
        {
              return _context.ARAURA != null ? 
                          View(await _context.ARAURA.ToListAsync()) :
                          Problem("Entity set 'AR_PROGRESO1Context.ARAURA'  is null.");
        }

        // GET: ARAURAs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.ARAURA == null)
            {
                return NotFound();
            }

            var aRAURA = await _context.ARAURA
                .FirstOrDefaultAsync(m => m.arCodigo == id);
            if (aRAURA == null)
            {
                return NotFound();
            }

            return View(aRAURA);
        }

        // GET: ARAURAs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ARAURAs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("arCodigo,arCalificacionFinal,arNombre,arCorreo,arCodigoPostal,arEstudianteNuevo,arFechaNacimiento,arPromedioConducta")] ARAURA aRAURA)
        {
            if (ModelState.IsValid)
            {
                _context.Add(aRAURA);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(aRAURA);
        }

        // GET: ARAURAs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.ARAURA == null)
            {
                return NotFound();
            }

            var aRAURA = await _context.ARAURA.FindAsync(id);
            if (aRAURA == null)
            {
                return NotFound();
            }
            return View(aRAURA);
        }

        // POST: ARAURAs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("arCodigo,arCalificacionFinal,arNombre,arCorreo,arCodigoPostal,arEstudianteNuevo,arFechaNacimiento,arPromedioConducta")] ARAURA aRAURA)
        {
            if (id != aRAURA.arCodigo)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(aRAURA);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ARAURAExists(aRAURA.arCodigo))
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
            return View(aRAURA);
        }

        // GET: ARAURAs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.ARAURA == null)
            {
                return NotFound();
            }

            var aRAURA = await _context.ARAURA
                .FirstOrDefaultAsync(m => m.arCodigo == id);
            if (aRAURA == null)
            {
                return NotFound();
            }

            return View(aRAURA);
        }

        // POST: ARAURAs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.ARAURA == null)
            {
                return Problem("Entity set 'AR_PROGRESO1Context.ARAURA'  is null.");
            }
            var aRAURA = await _context.ARAURA.FindAsync(id);
            if (aRAURA != null)
            {
                _context.ARAURA.Remove(aRAURA);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ARAURAExists(int id)
        {
          return (_context.ARAURA?.Any(e => e.arCodigo == id)).GetValueOrDefault();
        }
    }
}
