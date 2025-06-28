using ShowTime.Data;
using ShowTime.Models;
using ShowTime.Repositories.Implementation.Interfaces;

namespace ShowTime.Repositories.Implementation{

    public class RepositoryBooking : RepositoryBase<Booking>, IRepositoryBooking
    {
        public RepositoryBooking(ShowTimeContext context) : base(context)
        {
        }
    }
}