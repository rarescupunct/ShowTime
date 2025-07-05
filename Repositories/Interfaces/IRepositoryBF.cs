using ShowTime.Models;

namespace ShowTime.Repositories.Interfaces;

public interface IRepositoryBF : IRepositoryBase<BandFestival>
{
    Task AddAsync(Guid bandId, Guid festivalId, int order = 1);
    Task<bool> ExistsAsync(Guid bandId, Guid festivalId);
}