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
    public class HomeModel : PageModel
    {
        private readonly pim.Data.pimContext _context;

        public HomeModel(pim.Data.pimContext context)
        {
            _context = context;
        }

        [BindProperty]
        public LoginUsuario LoginUsuario { get; set; } = default!;

        public async Task<IActionResult> OnPostAsync()
        {
            string submitButton = Request.Form["submitButton"];

            if (submitButton == "Cadastro de Funcionário")
            {
                return RedirectToPage("./CadastrarFuncionario");
            }

            if (submitButton == "Folha de Pagamento")
            {
                return RedirectToPage("./FolhaPagamento");
            }

            return Page();
        }
    }
}
