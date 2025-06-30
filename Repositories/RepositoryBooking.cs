using ShowTime.Data;
using Microsoft.EntityFrameworkCore;
using ShowTime.Models;
using ShowTime.Repositories.Interfaces;

namespace ShowTime.Repositories.Implementation{

    public class RepositoryBooking : RepositoryBase<Booking>, IRepositoryBooking
    {
        public RepositoryBooking(ShowTimeContext context) : base(context)
        {
        }
        
        public async Task<IEnumerable<Booking>> GetBookingsByFestivalAsync(Guid festivalId)
        {
            return await _dbSet.Where(b => b.FestivalID == festivalId).ToListAsync();
        }
        
        public async Task<int> GetBookingCountForFestivalAsync(Guid festivalId)
        {
            return await _dbSet.CountAsync(b => b.FestivalID == festivalId);
        }
    }
}