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
    public class FolhaPagamentoModel : PageModel
    {
        private readonly pim.Data.pimContext _context;

        public FolhaPagamentoModel(pim.Data.pimContext context)
        {
            _context = context;
        }

        [BindProperty]
        public LoginUsuario LoginUsuario { get; set; } = default!;

        public async Task<IActionResult> OnPostAsync()
        {
            string submitButton = Request.Form["submitCreateButton"];

            if (submitButton == "Voltar")
            {
                return RedirectToPage("./Home");
            }

            return Page();
        }
    }
}
