using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using pim.Data;
using pim.Models;

namespace pim.Pages
{
    public class CadastrarFuncionarioModel : PageModel
    {
        private readonly pim.Data.pimContext _context;

        public CadastrarFuncionarioModel(pim.Data.pimContext context)
        {
            _context = context;
        }

        [BindProperty]
        public LoginUsuario LoginUsuario { get; set; } = default!;

        public async Task<IActionResult> OnPostAsync()
        {

            var auth = await _context.LoginUsuario.FirstOrDefaultAsync(x => x.Login == LoginUsuario.Login && x.Senha == LoginUsuario.Senha);

            if (auth == null)
            {
                return Page();
            }

            return RedirectToPage("./Create");
        }
    }
}
