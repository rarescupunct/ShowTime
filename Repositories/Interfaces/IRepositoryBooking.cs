using ShowTime.Models;

namespace ShowTime.Repositories.Interfaces{

    public interface IRepositoryBooking
    {
        Task<IEnumerable<Booking>> GetBookingsByFestivalAsync(Guid festivalId);
        Task<IEnumerable<Booking>> GetBookingsByBandAsync(Guid bandId);
        Task<int> GetBookingCountForFestivalAsync(Guid festivalId);
    }
}