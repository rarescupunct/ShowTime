using ShowTime.Data;
using ShowTime.Enums;
using ShowTime.Models;
using ShowTime.Repositories.Interfaces;

namespace ShowTime.Repositories.Interfaces{

    public interface IRepositoryBand: IRepositoryBase<Band>
    {
        Task<IEnumerable<Band>> GetByGenreAsync(Genre genre);
        Task<IEnumerable<Band>> GetAvailableByIdAsync(Guid festivalID);
        Task AddBFContextAsync(Band band, Festival festival);
    }
}