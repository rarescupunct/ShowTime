using ShowTime.Data;
using ShowTime.Models;
using ShowTime.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;


namespace ShowTime.Repositories.Implementation{

    public class RepositoryFestivals: RepositoryBase<Festival>, IRepositoryFestivals
    {
        public RepositoryFestivals(ShowTimeContext context) : base(context)
        {
        }
        public async Task<IEnumerable<Festival>> GetUpcomingFestivalsAsync(DateTime fromDate)
        {
            return await _context.Festivals
                .Where(f => f.StartDate >= fromDate)
                .ToListAsync();
        }

        public async Task<IEnumerable<Festival>> GetFestivalsByBandAsync(Guid bandId)
        {
            return await _dbSet.Where(f => f.Bands.Any(b => b.Id == bandId)).ToListAsync();
        }

        public async Task<Festival> GetFestivalByNameAsync(string festivalName)
        {
            return await _dbSet.Where(f=>f.Name == festivalName).FirstOrDefaultAsync();
        }
    }

}