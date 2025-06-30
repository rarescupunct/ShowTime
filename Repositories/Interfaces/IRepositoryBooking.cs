using ShowTime.Models;

namespace ShowTime.Repositories.Interfaces{

    public interface IRepositoryBooking
    {
        Task<IEnumerable<Booking>> GetBookingsByFestivalAsync(Guid festivalId);
        Task<int> GetBookingCountForFestivalAsync(Guid festivalId);
    }
}