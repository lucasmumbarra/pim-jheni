using System;
using System.Collections.Generic;
using System.Globalization;
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
        public PageCadastroFuncionario pageCadastroFuncionario { get; set; } = default!;

        public async Task<IActionResult> OnPostAsync()
        {
             string submitButton = Request.Form["submitCreateButton"];

            if (submitButton == "Voltar")
            {
                return RedirectToPage("./Home");
            }
            
            if (submitButton == "Cadastro")
            {
                var cargo = await _context.Cargo.FirstOrDefaultAsync(x => x.Nome == pageCadastroFuncionario.Cargo.ToUpper());
                var genero = await _context.Genero.FirstOrDefaultAsync(x => x.Descricao == pageCadastroFuncionario.Genero.ToUpper());
                
                Endereco endereco = new Endereco();
                endereco.CEP = pageCadastroFuncionario.Cep;
                endereco.CidadeId = 21;
                endereco.Logradouro = pageCadastroFuncionario.Endereco;
                endereco.Numero = pageCadastroFuncionario.Numero;
                endereco.Bairro = pageCadastroFuncionario.Bairro;
                endereco.Complemento = pageCadastroFuncionario.Complemento;

                _context.Add(endereco);
                await _context.SaveChangesAsync();

                CadastroFuncionario func = new CadastroFuncionario();
                func.RG = pageCadastroFuncionario.Rg;
                func.Nome = pageCadastroFuncionario.Nome;
                func.Telefone = pageCadastroFuncionario.Telefone;
                func.DataNascimento = DateTime.ParseExact(pageCadastroFuncionario.DataNascimento, "dd/MM/yyyy", null);
                func.CPF = pageCadastroFuncionario.Cpf;
                func.DataAdmissao = DateTime.Now;
                func.DataDemissao = null;
                func.Email = pageCadastroFuncionario.Email;
                func.EnderecoId = endereco.Id;
                func.CargoId = cargo.Id;
                func.GeneroId = genero.Id;

                _context.Add(func);
                await _context.SaveChangesAsync();

                if (func.Id != null)
                {
                    

                    return RedirectToPage("./Home");
                }
            }

            return Page();
        }
    }
}
