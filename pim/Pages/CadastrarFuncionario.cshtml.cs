using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using pim.Data;
using pim.Models;
using pim.Models.Pages;

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
        public PageCadastroFuncionario PageCadastroFuncionario { get; set; } = default!;

        public async Task<IActionResult> OnPostAsync()
        {
            return RedirectToPage("./Home");
        }
    }
}
