using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using pim.Data;
using pim.Models;

namespace pim.Controllers
{
    public class LoginUsuariosController : Controller
    {
        private readonly pimContext _context;

        public LoginUsuariosController(pimContext context)
        {
            _context = context;
        }

        // GET: LoginUsuarios
        public async Task<IActionResult> Index()
        {
              return _context.LoginUsuario != null ? 
                          View(await _context.LoginUsuario.ToListAsync()) :
                          Problem("Entity set 'pimContext.LoginUsuario'  is null.");
        }

        // GET: LoginUsuarios/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.LoginUsuario == null)
            {
                return NotFound();
            }

            var loginUsuario = await _context.LoginUsuario
                .FirstOrDefaultAsync(m => m.Id == id);
            if (loginUsuario == null)
            {
                return NotFound();
            }

            return View(loginUsuario);
        }

        // GET: LoginUsuarios/Create
        public IActionResult Create()
        {
            return View();
        }

        // GET: LoginUsuarios/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.LoginUsuario == null)
            {
                return NotFound();
            }

            var loginUsuario = await _context.LoginUsuario.FindAsync(id);
            if (loginUsuario == null)
            {
                return NotFound();
            }
            return View(loginUsuario);
        }

        // POST: LoginUsuarios/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Login,Senha")] LoginUsuario loginUsuario)
        {
            if (id != loginUsuario.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(loginUsuario);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LoginUsuarioExists(loginUsuario.Id))
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
            return View(loginUsuario);
        }

        // GET: LoginUsuarios/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.LoginUsuario == null)
            {
                return NotFound();
            }

            var loginUsuario = await _context.LoginUsuario
                .FirstOrDefaultAsync(m => m.Id == id);
            if (loginUsuario == null)
            {
                return NotFound();
            }

            return View(loginUsuario);
        }

        // POST: LoginUsuarios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.LoginUsuario == null)
            {
                return Problem("Entity set 'pimContext.LoginUsuario'  is null.");
            }
            var loginUsuario = await _context.LoginUsuario.FindAsync(id);
            if (loginUsuario != null)
            {
                _context.LoginUsuario.Remove(loginUsuario);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        
        [HttpPost]
        public IActionResult Login(LoginUsuarioModel model)
        {
            if (ModelState.IsValid)
            {
                var usuario = _context.LoginUsuario
                    .SingleOrDefault(u => u.Login == model.Login && u.Senha == model.Senha);

                if (usuario != null)
                {
                    return RedirectToAction("PaginaInicial", "Home");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Login ou senha inválidos.");
                    return View("Index", model);
                }
            }

            return View("Index", model);
        }


        private bool LoginUsuarioExists(int id)
        {
          return (_context.LoginUsuario?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
