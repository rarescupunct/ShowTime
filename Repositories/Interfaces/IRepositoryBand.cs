using ShowTime.Data;
using ShowTime.Enums;
using ShowTime.Models;
using ShowTime.Repositories.Implementation.Interfaces;

namespace ShowTime.Repositories.Implementation.Interfaces{

    public interface IRepositoryBand: IRepositoryBase<Band>
    {
        //public async Task GetByGenre(Genre genre);
    }
}