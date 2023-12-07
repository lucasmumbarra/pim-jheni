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
    public class FolhaPagamentoModel : PageModel
    {
        private readonly pim.Data.pimContext _context;

        public FolhaPagamentoModel(pim.Data.pimContext context)
        {
            _context = context;
        }

        [BindProperty]
        public PageFp Fp { get; set; } = default!;

        public async Task<IActionResult> OnPostAsync()
        {
            string submitButton = Request.Form["submitFpButton"];

            if (submitButton == "Voltar")
            {
                return RedirectToPage("./Home");
            }

            if (submitButton == "Gerar Folha")
            {
                Fp.Nome = "teste";
                Fp.Salario = decimal.Parse("0.00");
                Fp.Faltas = "teste";
                Fp.INSS = "teste";
                Fp.Atestado = "teste";
                Fp.Ferias = "teste";
                Fp.Atrasos = "teste";
                Fp.Beneficios = "teste";
                Fp.DecimoSalario = "teste";
            }

            return Page();
        }
    }
}
