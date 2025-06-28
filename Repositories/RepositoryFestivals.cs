using ShowTime.Data;
using ShowTime.Models;
using ShowTime.Repositories.Implementation.Interfaces;

namespace ShowTime.Repositories.Implementation{

    public class RepositoryFestivals: RepositoryBase<Festival>, IRepositoryFestivals
    {
        public RepositoryFestivals(ShowTimeContext context) : base(context)
        {
        }
    }

}