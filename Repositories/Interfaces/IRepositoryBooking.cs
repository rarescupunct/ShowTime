using ShowTime.Models;

namespace ShowTime.Repositories.Interfaces{

    public interface IRepositoryBooking:IRepositoryBase<Booking>
    {
        Task<IEnumerable<Booking>> GetBookingsByFestivalAsync(Guid festivalId);
        Task<int> GetBookingCountForFestivalAsync(Guid festivalId);
    }
}