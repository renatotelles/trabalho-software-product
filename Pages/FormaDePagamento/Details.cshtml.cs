using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Vendas.Data;
using Vendas.Models;

namespace Vendas.Pages_FormaDePagamento
{
    public class DetailsModel : PageModel
    {
        private readonly Vendas.Data.AppDbContext _context;

        public DetailsModel(Vendas.Data.AppDbContext context)
        {
            _context = context;
        }

      public FormaDePagamento FormaDePagamento { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.FormaDePagamento == null)
            {
                return NotFound();
            }

            var formadepagamento = await _context.FormaDePagamento.FirstOrDefaultAsync(m => m.Id == id);
            if (formadepagamento == null)
            {
                return NotFound();
            }
            else 
            {
                FormaDePagamento = formadepagamento;
            }
            return Page();
        }
    }
}
