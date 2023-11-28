using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Vendas.Data;
using Vendas.Models;

namespace Vendas.Pages.Produtos
{
    public class IndexModel : PageModel
    {
        private readonly Vendas.Data.AppDbContext _context;

        public IndexModel(Vendas.Data.AppDbContext context)
        {
            _context = context;
        }

        public IList<Produto> Produto { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Produto != null)
            {
                Produto = await _context.Produto.ToListAsync();
            }
        }
    }
}
