using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Vendas.Data;
using Vendas.Models;

namespace Vendas.Pages_FormaDePagamento
{
    public class CreateModel : PageModel
    {
        private readonly Vendas.Data.AppDbContext _context;

        public CreateModel(Vendas.Data.AppDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public FormaDePagamento FormaDePagamento { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.FormaDePagamento == null || FormaDePagamento == null)
            {
                return Page();
            }

            _context.FormaDePagamento.Add(FormaDePagamento);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
