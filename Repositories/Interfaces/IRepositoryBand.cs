using ShowTime.Data;
using ShowTime.Enums;
using ShowTime.Models;
using ShowTime.Repositories.Interfaces;

namespace ShowTime.Repositories.Interfaces{

    public interface IRepositoryBand: IRepositoryBase<Band>
    {
        public Task<IEnumerable<Band>> GetByGenreAsync(Genre genre);
        
    }
}