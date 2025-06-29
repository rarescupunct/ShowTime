using ShowTime.Models;

namespace ShowTime.Repositories.Interfaces{

    public interface IRepositoryFestivals : IRepositoryBase<Festival>
    {
        Task<IEnumerable<Festival>> GetUpcomingFestivalsAsync(DateTime fromDate);
        Task<IEnumerable<Festival>> GetFestivalsByBandAsync(Guid bandId);
    }
}