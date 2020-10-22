using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LancJF.Data;
using LancJF.Models;
using Microsoft.EntityFrameworkCore;

namespace LancJF.Services
{
    public class CategoriaService
    {
        private readonly LancJFContext _context;

        public CategoriaService(LancJFContext context)
        {
            _context = context;
        }

        public async Task<List<Categoria>> FindAllAsync()
        {
            return await _context.Categoria.OrderBy(x => x.Nome).ToListAsync();
        }
    }
}
