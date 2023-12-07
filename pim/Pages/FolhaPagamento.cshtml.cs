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
                var cf = await _context.CadastroFuncionario.FirstOrDefaultAsync(x => x.Email == Fp.Email);
                var salario = await _context.Salario.FirstOrDefaultAsync(x => x.Id == 1);

                Fp.Nome = cf.Nome;
                Fp.Salario = salario.ValorSalario;
                Fp.Faltas = "0";
                Fp.INSS = Math.Round((salario.ValorSalario / 100) * decimal.Parse("11.28"), 2).ToString("N2", new System.Globalization.CultureInfo("pt-BR"));
                Fp.Atestado = "0";
                Fp.Ferias = "0";
                Fp.Atrasos = "0";
                Fp.Beneficios = "600.00";
                Fp.DecimoSalario = salario.ValorSalario.ToString();
            }

            return Page();
        }
    }
}
