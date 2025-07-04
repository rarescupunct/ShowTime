using Microsoft.EntityFrameworkCore;
using MudBlazor.Services;
using ShowTime.Components;
using ShowTime.Data;
using ShowTime.Enums;
using ShowTime.Models;
using ShowTime.Repositories.Interfaces;

namespace ShowTime.Repositories.Implementation{

    public class RepositoryBand: RepositoryBase<Band>, IRepositoryBand
    {
        public RepositoryBand(ShowTimeContext context) : base(context)
        {
        }

        
         public async Task<IEnumerable<Band>> GetByGenreAsync(Genre genre)
        {
            return await DbSet.Where(e => e.Genre == genre).ToListAsync(); 
        }
        
    }
}