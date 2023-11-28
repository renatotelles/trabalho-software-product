using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Vendas.Data;
using Vendas.Models;

namespace Vendas.Pages_FormaDePagamento
{
    public class EditModel : PageModel
    {
        private readonly Vendas.Data.AppDbContext _context;

        public EditModel(Vendas.Data.AppDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public FormaDePagamento FormaDePagamento { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.FormaDePagamento == null)
            {
                return NotFound();
            }

            var formadepagamento =  await _context.FormaDePagamento.FirstOrDefaultAsync(m => m.Id == id);
            if (formadepagamento == null)
            {
                return NotFound();
            }
            FormaDePagamento = formadepagamento;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(FormaDePagamento).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FormaDePagamentoExists(FormaDePagamento.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool FormaDePagamentoExists(int id)
        {
          return (_context.FormaDePagamento?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
