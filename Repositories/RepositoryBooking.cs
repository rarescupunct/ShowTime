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
            return Context.Bookings.Where(b => b.FestivalId == festivalId);
        }
        
        public async Task<int> GetBookingCountForFestivalAsync(Guid festivalId)
        {
            return await DbSet.CountAsync(b => b.FestivalId == festivalId);
        }
    }
}